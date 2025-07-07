using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int IdNumber { get; set; }
        public int ProductId {  get; set; }
        public int CountInSale {  get; set; }
        public int TotalPrice {  get; set; }
        public bool AllCustomer {  get; set; }
        public DateTime StartSale {  get; set; }
        public DateTime EndSale {  get; set; }
        public Sale(int idNumber, int productId, int countInSale, int totalPrice, bool allCustomer, DateTime startSale, DateTime endSale)
        {
            IdNumber = idNumber;
            ProductId = productId;
            CountInSale = countInSale;
            TotalPrice = totalPrice;
            AllCustomer = allCustomer;
            StartSale = startSale;
            EndSale = endSale;
        }
    }
}
