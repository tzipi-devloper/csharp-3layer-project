using BlApi;
using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace BIImplementation
{
    public class OrderImplemtation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
      
       public List<SaleInProduct> AddProductToOrder(Order order, int productId, int amount, int idCustomer)
        {
            var product = _dal.Product.Read(productId)
                ?? throw new BLIdNotExistException("המוצר עם הברקוד " + productId + " לא נמצא");

            
            var existing = order.productInOrder.FirstOrDefault(p => p.productId == productId);
            if (existing != null)
            {
                if (existing.amountInOrder + amount > product.CountInStock)
                {
                    throw new BO.BlInvalidOperationException("אין מספיק במלאי למוצר: " + product.ProductName);
                 //   LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "אין מספיק במלאי למוצר: " + product.ProductName);
                }
                existing.amountInOrder += amount;
            }

            else
            {
                if (amount > product.CountInStock)
                {
                    throw new BO.BlInvalidOperationException("אין מספיק במלאי למוצר: " + product.ProductName);
               //     LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "אין מספיק במלאי למוצר: " + product.ProductName);

                }

                existing = new ProductInOrder
                {
                    productId = product.Code,
                    productName = product.ProductName,
                    basePrice = (int)product.Price,
                    amountInOrder = amount
                };
                order.productInOrder.Add(existing);

            }
            try
            {
                bool isPreferred = _dal.Customer.Read(idCustomer) != null;
                SearchSaleForProduct(existing, isPreferred);
            //    LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "חבר מועדון: " + product.ProductName);

            }
            catch (Exception e)
            {
           //     LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "לא חבר מועדון " );

            }

            CalcTotalPriceForProduct(existing);
            CalcTotalPrice(order);
           // LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,"");

            return existing.saleList;
        }

        public void SearchSaleForProduct(ProductInOrder product, bool isPreferred)
        {
            var sales = _dal.Sale.ReadAll(s =>
                s.ProductId == product.productId &&
                s.StartSale <= DateTime.Now &&
                s.EndSale >= DateTime.Now &&
                product.amountInOrder >= s.CountInSale &&
                (!s.AllCustomer || isPreferred)
            );

            product.saleList = sales
                .Select(s => new SaleInProduct
                {
                    saleId = s.ProductId,
                    amountToSale = s.CountInSale,
                    price = s.TotalPrice,
                    forAllCustomer = s.AllCustomer
                })
                .OrderBy(s => s.price)
                .ToList();
        
       }
        //
        // חישוב מחיר מינימלי למוצר לפי כמות מבוקשת, באמצעות בחירת שילוב מבצעים אופטימלי ודילוג על הצעות לא משתלמות.
        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
           // LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,"");

            int n = product.amountInOrder;
            double[] minCost = new double[n + 1];
            List<SaleInProduct>[] bestSales = new List<SaleInProduct>[n + 1];

            for (int i = 0; i <= n; i++)
            {
                minCost[i] = i * product.basePrice; 
                bestSales[i] = new List<SaleInProduct>();
            }

            for (int i = 1; i <= n; i++)
            {
                foreach (var sale in product.saleList)
                {
                    if (i >= sale.amountToSale)
                    {
                        double newCost = minCost[i - sale.amountToSale] + sale.price;
                        if (newCost < minCost[i])
                        {
                            minCost[i] = newCost;
                            bestSales[i] = new List<SaleInProduct>(bestSales[i - sale.amountToSale]) { sale };
                        }
                    }
                }
            }

            product.endPrice = minCost[n];
            product.saleList = bestSales[n];
        }

        public void CalcTotalPrice(Order order)
        {
            order.totalPrice = order.productInOrder.Sum(p => p.endPrice);
        }

        public void DoOrder(Order order)
        {
            var updates = order.productInOrder.Select(p =>
            {
                var product = _dal.Product.Read(p.productId)
                    ?? throw new BLIdNotExistException("המוצר עם ברקוד " + p.productId + " לא קיים");

                if (product.CountInStock < p.amountInOrder)
                {
                    throw new BO.BlInvalidOperationException("אין מספיק מלאי למוצר " + product.ProductName);
                }

                return product with { CountInStock = product.CountInStock - p.amountInOrder };
            });

            foreach (var updated in updates)
            {
                _dal.Product.Update(updated);
            }
        }
    }

}
