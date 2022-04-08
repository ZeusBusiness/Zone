using Newtonsoft.Json;
using System.Text;
using Zone.DataManager.Abstract.DataProvider.DigitalPayment.EzeTap;
using Zone.Infrastructure.Generic.DigitalPayment.EzeTap;

namespace Zone.DataProvider.DigitalPayment.EzeTap
{
    public class PaymentProvider: IPaymentProvider
    {
        public async Task<PaymentResponse> SendData(string file)
        {
            int NumberOfRetries = 5;
            int DelayOnRetry = 2000;
            PaymentResponse saleResponse = new PaymentResponse();
            for (int i = 1; i <= NumberOfRetries; ++i)
            {
                try
                {
                    using (StreamReader r = new StreamReader(file))
                    {
                        string json = r.ReadToEnd();
                        PaymentRequest request = JsonConvert.DeserializeObject<PaymentRequest>(json);
                        r.Close();
                        File.Delete(file);
                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri("https://www.ezetap.com/api/3.0/p2p/start");
                        var response = await client.PostAsync("", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
                        saleResponse = JsonConvert.DeserializeObject<PaymentResponse>(await response.Content.ReadAsStringAsync());
                        saleResponse.Date = DateTime.Now;
                        break;
                    }
                }
                catch(Exception ex) when (i <= NumberOfRetries)
                {
                    Thread.Sleep(DelayOnRetry);
                    saleResponse.Date = DateTime.Now;
                    //saleResponse.ResponseCode = true;
                }
            }
            return saleResponse;
        }
    }
}
