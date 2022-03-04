using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone.Infrastructure.Genric.DigitalPayment.PineLabs
{
    public class SaleRequest
    {
        public string TransactionNumber { get; set; }
        public int SequenceNumber { get; set; }
        public string AllowedPaymentMode { get; set; }
        public float Amount { get; set; }
        public int MerchantID { get; set; }
        public string SecurityToken { get; set; }
        public string MerchantStorePosCode { get; set; }
        public string IMEI { get; set; }
        public int AutoCancelDurationInMinutes { get; set; }
        

    }
}
