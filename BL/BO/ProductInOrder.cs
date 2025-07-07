using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int productId {  get; set; }
        public string productName { get; set; }
        public int basePrice {  get; set; }
        public int amountInOrder {  get; set; }
        public List<SaleInProduct> saleList { get; set; }=new List<SaleInProduct>();
        public double endPrice {  get; set; }


    }
}
