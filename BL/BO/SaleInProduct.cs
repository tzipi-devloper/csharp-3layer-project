using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int saleId {  get; set; }
        public int amountToSale {  get; set; }
        public double price { get; set; }
        public bool forAllCustomer {  get; set; }
    }
}
