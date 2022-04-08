using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone.Infrastructure.Generic.DigitalPayment.EzeTap
{
    public class PaymentResponse
    {
        public bool Success { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime Date { get; set; }
        public string p2pRequestId { get; set; }
        public string RealCode { get; set; }
    }
}
