using DO;
using DalApi;
using System.Runtime.InteropServices;
using System.Reflection;
using Tools;
namespace Dal;
internal class ProductImplementation : Iproduct
{
    public int Create(Product p)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" insert sale in id:{p.Code}");

        bool inPro = DataSource.products.Any(p1 => p1.Code == p.Code);
        if (inPro)
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"the code is exist:{p.Code}");
            throw new Exception("the code is exist");

        }
        else
        {
            DataSource.products.Add(p);
            return p.Code;
        }
        
    }

    public Product? Read(int code)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read product in code:{code}");
        foreach (Product pro in DataSource.products)
        {
            if (code == pro.Code)
                return pro;
        }
        throw new DalIdNotExistException("The code is not exist");
    }
    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read product in code:{filter}");
        var pro = DataSource.products.FirstOrDefault(p => filter(p));
        if (pro is Product)
            return pro;
        else
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read product in code:{filter}");
            throw new DalIdNotExistException("The code is not exist");
        }
           
    }
    public List<Product> ReadAll(Func<Product, bool>? filter)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read all products");

        if (filter == null)
            return new List<Product>(DataSource.products);
        else
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"can'not read products");
            var allPro = DataSource.products.Where(p => filter(p)).ToList();
            return allPro;
        }
    }
    public void Update(Product p)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update the product id{p.Code}");
        Delete((int)p.Code);
        DataSource.products.Add(p);
    }
    public void Delete(int code)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete the product id{code}");
        Product p = Read(code);
        DataSource.products.Remove(p);
    }

  
}
