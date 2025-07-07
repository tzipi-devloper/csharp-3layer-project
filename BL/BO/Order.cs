using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool priorityCus { get; set; }
        public List<ProductInOrder> productInOrder { get; set; }=new List<ProductInOrder>();
        public double totalPrice {  get; set; }

    }
}
