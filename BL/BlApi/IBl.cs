
using BIImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlApi
{
     public  interface IBI
    {
        ICustomer customer { get; }
        IOrder order { get; }
        IProduct product { get; }
        ISale sale { get; }
 
    }
}
