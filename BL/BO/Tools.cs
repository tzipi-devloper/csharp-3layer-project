using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace BO
{
    internal static class Tools
    {
        public static string toStringProperty<T>(this T obj)
        {
            if (obj == null) return "null";

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            List<string> propertyStrings = new List<string>();

            foreach (var property in properties)
            {
                object value = property.GetValue(obj);
                if (value is IEnumerable)
                {
                    List<string> listItems = new List<string>();
                    foreach (var item in (IEnumerable)value)
                    {
                        listItems.Add(item?.ToString());
                    }
                    propertyStrings.Add($"{property.Name}: [{string.Join(", ", listItems)}]");
                }
                else
                {
                    propertyStrings.Add($"{property.Name}: {value?.ToString()}");
                }
            }

            return string.Join(", ", propertyStrings);

        }
        public static BO.Sale convertDOSaleToBOSale(this DO.Sale doSale)
        {
            return new BO.Sale(doSale.IdNumber, doSale.ProductId, doSale.CountInSale, doSale.TotalPrice, doSale.AllCustomer, doSale.StartSale, doSale.EndSale);
        }
        public static BO.Customer convertDOCustomerToBOCustomer(this DO.Customer doCustomer)
        {
            return new BO.Customer(doCustomer.Id, doCustomer.CustomerName, doCustomer.Address, doCustomer.Phone);
        }
        public static BO.Product convertDOPrductToBOProduct(this DO.Product doProduct)
        {
            return new BO.Product(doProduct.Code, doProduct.ProductName, (BO.Category)doProduct.c, doProduct.Price, doProduct.CountInStock);
        }
        public static DO.Sale convertBOSaleToDOSale(this BO.Sale boSale)
        {
            return new DO.Sale(boSale.IdNumber, boSale.ProductId, boSale.CountInSale, boSale.TotalPrice, boSale.AllCustomer, boSale.StartSale, boSale.EndSale);
        }
        public static DO.Customer convertBOCustomerToDOCustomer(this BO.Customer boCustomer)
        {
            return new DO.Customer(boCustomer.Id, boCustomer.CustomerName, boCustomer.Address, boCustomer.Phone);
        }
        public static DO.Product convertDOPrductToBOProduct(this BO.Product boProduct)
        {
            return new DO.Product(boProduct.Code, boProduct.ProductName, (DO.Category)boProduct.c, boProduct.Price, boProduct.CountInStock);
        }
    }
}
