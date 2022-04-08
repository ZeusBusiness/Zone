using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone.Infrastructure.Generic.DigitalPayment.EzeTap
{
    public class PaymentRequest
    {
        public string appKey { get; set; }
        public Device pushTo { get; set; }
        public string username { get; set; }
        public float amount { get; set; }
        public string externalRefNumber { get; set; }

    }
}
