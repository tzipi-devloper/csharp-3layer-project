
using DO;
using Tools;
using DalApi;
namespace Dal;
using System.Reflection;
internal class SaleImplementation : Isale
{
    public int Create(Sale s)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" insert sale in id:{s.IdNumber}");
        bool inSale = DataSource.sales.Any(s1 => s1.IdNumber==s.IdNumber);
        if (inSale)
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"The id is exist:{s.IdNumber}");
            throw new Exception("the code is exist");
        }

        else
        {
            DataSource.sales.Add(s);
            return s.IdNumber;
        }
          

     

        //Sale newSale = s with { IdNumber = DataSource.Config.GetSaleNum };
        //DataSource.sales.Add(newSale);
        //return (int)newSale.IdNumber;
    }
    public Sale? Read(int idNumber)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read sale in id:{idNumber}");
        Sale sale;
        sale=DataSource.sales.FirstOrDefault(x=> x.IdNumber==idNumber);
        if (sale == null)
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" The idNumber is not exist:{idNumber}");
            throw new DalIdNotExistException("The code is not exist");
        }      
        else
            return sale;
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        var sale = DataSource.sales.FirstOrDefault(s => filter(s)); 
        if (sale is Sale)
            return sale;
        else
            throw new DalIdNotExistException("The idNumber is not exist");
    }
   

    public List<Sale> ReadAll(Func<Sale, bool>? filter)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read all sales");

        if (filter == null)
            return new List<Sale>(DataSource.sales);
        else
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"is not read all sales");
            var allSale = DataSource.sales.Where(s => filter(s)).ToList();
            return allSale;
        }
    }
    public void Update(Sale s)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update the sale id{s.IdNumber}");
        Delete((int)s.IdNumber);
        DataSource.sales.Add(s);
    }
    public void Delete(int idNumber)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delate the sale  id{idNumber}");
        Sale s= Read(idNumber);
        DataSource.sales.Remove(s);
    }

}
