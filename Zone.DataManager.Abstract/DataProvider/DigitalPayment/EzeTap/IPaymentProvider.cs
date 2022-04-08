using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zone.Infrastructure.Generic.DigitalPayment.EzeTap;

namespace Zone.DataManager.Abstract.DataProvider.DigitalPayment.EzeTap
{
    public interface IPaymentProvider
    {
        public Task<PaymentResponse> SendData(string file);
    }
}
