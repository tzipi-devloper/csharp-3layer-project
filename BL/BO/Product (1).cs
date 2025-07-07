using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int Code { get;set; }
        public string ProductName {  get;set; }
        public Category c {  get;set; }
        public double Price {  get;set; }
        public int CountInStock {  get;set; }
        public List<SaleInProduct> SaleInProducs { get;set; }
        public Product(int code, string productName,Category c ,double price,int countInStack)
        {
            Code = code;
            ProductName = productName;
            Price = price;
            this.c= c;
            this.Price = price;
            CountInStock= countInStack;
            SaleInProducs=new List<SaleInProduct>();
        }
    }
}
