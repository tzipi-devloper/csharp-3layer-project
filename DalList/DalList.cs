using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList:IDal
    {
        static readonly DalList instance = new DalList();
        public static DalList Instance { get { return instance; } }
        private DalList() { }
        public Icustomer Customer => new CustomerImplementation();
        public Iproduct Product => new ProductImplementation();
        public Isale Sale => new SaleImplementation();
      
    }
}
