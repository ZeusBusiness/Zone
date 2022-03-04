using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zone.DataManager.Abstract.DataProvider.DigitalPayment.PineLabs;
using Zone.Infrastructure.Genric.DigitalPayment.PineLabs;

namespace Zone.DataProvider.DigitalPayment.PineLabs
{
    public class SaleRequestProvider: ISaleRequestProvider
    {
        public async Task<SaleResponse> SendData(string file)
        {
            int NumberOfRetries = 5;
            int DelayOnRetry = 2000;
            SaleResponse saleResponse = new SaleResponse();
            for (int i = 1; i <= NumberOfRetries; ++i)
            {
                try
                {
                    using (StreamReader r = new StreamReader(file))
                    {
                        string json = r.ReadToEnd();
                        SaleRequest request = JsonConvert.DeserializeObject<SaleRequest>(json);
                        r.Close();
                        File.Delete(file);
                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri("https://www.plutuscloudserviceuat.in:8201/API/CloudBasedIntegration/V1/UploadBilledTransaction");
                        var response = await client.PostAsync("", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
                        saleResponse = JsonConvert.DeserializeObject<SaleResponse>(await response.Content.ReadAsStringAsync());
                        saleResponse.InvoiceDate = DateTime.Now;
                        break;
                        }
                }
                catch (Exception ex) when (i <= NumberOfRetries)
                {
                    Thread.Sleep(DelayOnRetry);
                    saleResponse.InvoiceDate = DateTime.Now;
                    saleResponse.ResponseCode = true;
                }
            }
            return saleResponse;
        }
    }
}
