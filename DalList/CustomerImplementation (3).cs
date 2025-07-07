
using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace Dal;

internal class CustomerImplementation : Icustomer
{

    public int Create(Customer c)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" insert customer in id:{c.Id}");

        bool cus = DataSource.customers.Any(cus => cus.Id == c.Id);
        if (cus)
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"this code is exist:{c.Id}");
            throw new DalCodeExistException("this code is exist");
        }
        else
        {
            DataSource.customers.Add(c);
            return c.Id;
        }
      
    }
    public Customer? Read(Func<int, bool> filter)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read customer in code:{filter}");
        var cus = DataSource.customers.Where(c => filter(c.Id)).FirstOrDefault();
        if (cus is Customer)
            return cus;
        else
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read customer in code:{filter}");
            throw new DalIdNotExistException("The id is not exist");
        }
           
    }
    public Customer? Read(int id)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read customer in code:{id}");
        Customer cus;
        cus= DataSource.customers.FirstOrDefault(c => c.Id == id);
        if (cus == null)
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read customer in code:{id}");
            throw new DalIdNotExistException("this code is not exist");
        }
        else
            return cus;
    }
    public List<Customer> ReadAll(Func<Customer, bool>? filter)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" read all customers");

        if (filter == null)
            return new List<Customer>(DataSource.customers);
        else
        {
            LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"is'not read all customers");

            var allCus = DataSource.customers.Where(c => filter(c)).ToList();
            return allCus;
        }
    }
    public void Update(Customer c)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update the customer id{c.Id}");
        Delete(c.Id);
        DataSource.customers.Add(c);
    }
    public void Delete(int id)
    {
        LogManager.writeIntoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update the customer id{id}");
        Customer c = Read(id);
        DataSource.customers.Remove(c);
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        throw new NotImplementedException();
    }
}