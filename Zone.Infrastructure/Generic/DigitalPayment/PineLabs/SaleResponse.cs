using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zone.Infrastructure.Generic.DigitalPayment.PineLabs;

namespace Zone.Infrastructure.Genric.DigitalPayment.PineLabs
{
    public class SaleResponse
    {
        public bool ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public int PlutusTransactionReferenceID { get; set; }
        public IList<AdditionalInfo> AdditionalInfo { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
