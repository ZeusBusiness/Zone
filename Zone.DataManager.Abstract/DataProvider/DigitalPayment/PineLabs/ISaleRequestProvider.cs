using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zone.Infrastructure.Genric.DigitalPayment.PineLabs;

namespace Zone.DataManager.Abstract.DataProvider.DigitalPayment.PineLabs
{
    public interface ISaleRequestProvider
    {
        public Task<SaleResponse> SendData(string file);
    }
}
