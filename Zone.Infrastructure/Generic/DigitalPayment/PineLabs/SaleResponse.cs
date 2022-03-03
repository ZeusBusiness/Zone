using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone.Infrastructure.Genric.DigitalPayment.PineLabs
{
    public class SaleResponse
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public int PlutusTransactionReferenceID { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
