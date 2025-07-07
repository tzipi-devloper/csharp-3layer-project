using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IOrder
    {
        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int amount, int idCustomer);
        public void SearchSaleForProduct(ProductInOrder product, bool isPreferred);
        public void CalcTotalPriceForProduct(ProductInOrder product);
        public void CalcTotalPrice(Order order);
        public void DoOrder(Order order);
    }
 
}
