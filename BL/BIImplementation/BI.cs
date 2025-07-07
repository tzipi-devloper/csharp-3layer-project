using BlApi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIImplementation
{
    internal class BI:IBI
    {
        public ICustomer customer => new CustomerImplementation();
        public ISale sale => new SaleImplementation();
        public IProduct product => new ProductImplementation();
        public IOrder order => new OrderImplemtation();
    }
}
