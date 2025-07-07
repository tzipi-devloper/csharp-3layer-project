using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tools;

namespace Dal
{
    internal class ProductImplementation:Iproduct
    {
        const string PATH = @"..\xml\products.xml";
        const string PRODUCTS = "Products";
        const string PRODUCT = "Product";
        const string CODE = "Code";
        const string PRODUCT_NAME = "ProductName";
        const string CATEGORY = "Category";
        const string PRICE = "Price";
        const string COUNT_IN_STOCK = "CountInStock";

        public int Create(Product item)
        {
            XElement productElement = XElement.Load(PATH);
            Product p =  item with { Code = Config.MinProductNumber};
            productElement.Add(new XElement(PRODUCT, new XElement(CODE, p.Code),
                new XElement(PRODUCT_NAME, p.ProductName),
                new XElement(CATEGORY, p.c),
                new XElement(PRICE, p.Price),
                new XElement(COUNT_IN_STOCK, p.CountInStock)
                ));
            productElement.Save(PATH);
            return p.Code;
        }
        public Product? Read(Func<Product, bool> filter)
        {
            XElement productElement = XElement.Load(PATH);
            Product productByID = productElement.Descendants(PRODUCT)
                .Select(p=> new Product(int.Parse(p.Element(CODE).Value),
                                        p.Element(PRODUCT_NAME).Value, 
                                        Enum.Parse<Category>(p.Element(CATEGORY).Value),
                                        double.Parse(p.Element(PRICE).Value),
                                        int.Parse(p.Element(COUNT_IN_STOCK).Value)))
                .FirstOrDefault(p => filter != null && filter(p));
            if (productByID == null)
                throw new DalIdNotExistException("");
            return productByID;
        }
        public Product? Read(int code)
        {
            XElement productElement = XElement.Load(PATH);
            Product productByID = productElement.Descendants(PRODUCT)
                .Select(p => new Product(
                    int.Parse(p.Element(CODE).Value),
                    p.Element(PRODUCT_NAME).Value,
                    Enum.Parse<Category>(p.Element(CATEGORY).Value),
                    double.Parse(p.Element(PRICE).Value),
                    int.Parse(p.Element(COUNT_IN_STOCK).Value)))
                .FirstOrDefault(p => p.Code == code);

            if (productByID == null)
                throw new DalIdNotExistException("Product ID does not exist.");

            return productByID;
        }
        public void Delete(int code)
        {
           
                XElement productXml = XElement.Load(PATH);
                 XElement productElement = productXml.Descendants(CODE).FirstOrDefault(p => int.Parse(p.Value) == code)?.Parent;
                if (productElement == null)
                    throw new DalIdNotExistException($"Product with id {code} not found.");

                productElement.Remove();
                productXml.Save(PATH);
               
        }
        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
                XElement productXml = XElement.Load(PATH);
                var products = productXml.Descendants(PRODUCT)
                    .Select(p => new Product(
                        int.Parse(p.Element(CODE).Value),
                        p.Element(PRODUCT_NAME).Value,
                        (Category)Enum.Parse(typeof(Category), p.Element(CATEGORY).Value),
                        double.Parse(p.Element(PRICE).Value),
                        int.Parse(p.Element(COUNT_IN_STOCK).Value))).ToList();
                return filter != null ? products.Where(filter).ToList() : products;             
        }


        public void Update(Product item)
        {
          
                XElement productXml = XElement.Load(PATH);
                var s = productXml.Descendants(CODE).FirstOrDefault(id => int.Parse(id.Value) == item.Code)?.Parent;
                if (s == null)
                    throw new DalIdNotExistException($"Product with id {item.Code} not found.");
                Delete(item.Code);
                s.Element(PRICE).SetValue(item.Price);
                s.Element(PRODUCT_NAME).SetValue(item.ProductName);
                s.Element(COUNT_IN_STOCK).SetValue(item.CountInStock);
                s.Element(CATEGORY).SetValue(item.c.ToString());

                productXml.Save(PATH);
            
         
        }
    }
}
