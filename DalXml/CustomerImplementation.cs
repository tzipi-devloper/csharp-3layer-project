using DalApi;
using DO;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal class CustomerImplementation:Icustomer
    {
        const string PATH = @"..\xml\customers.xml";

        public int Create(Customer customer)
        {
            List<Customer> customers = LoadList();
            customers.Add(customer);
            SaveList(customers);
            return customer.Id;
        }

        public void Delete(int id)
        {
            List<Customer> customers = LoadList();
            Customer customer = customers.FirstOrDefault(customer => customer.Id == id);
            customers.Remove(customer);
            SaveList(customers);
        }

        public Customer? Read(int id)
        {
            List<Customer> customers = LoadList();
            return customers.FirstOrDefault(customer => customer.Id == id);
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            List<Customer> customers = LoadList();
            return customers.FirstOrDefault(filter);
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            List<Customer> customers = LoadList();
            if (!customers.Any())
            {
                throw new DalIdNotExistException("customers not found");
            }
            if (filter != null)
            {
                IEnumerable<Customer> customersList = customers.Where(c => filter(c)).Select(c => c);
                return (List<Customer?>)customersList;
            }
            return customers;
        }

        //public void Update(Customer item)
        //{
        //    List<Customer> customers = LoadList();
        //    Customer? customer = customers.FirstOrDefault(c => c.Id == item.Id);
        //    if (customer == null)
        //    {
        //        throw new DalIdNotExistException("customer not found");
        //    }
        //    customers.Remove(customer);
        //    SaveList(customers);
        //}
        public void Update(Customer item)
        {
            List<Customer> customers = LoadList();
            Customer? customer = customers.FirstOrDefault(c => c.Id == item.Id);
            if (customer == null)
            {
                throw new DalIdNotExistException("customer not found");
            }

            customers.Remove(customer);      
            customers.Add(item);             
            SaveList(customers);             
        }

        public List<Customer> LoadList()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            List<Customer> customers;
            using (StreamReader sr = new StreamReader(PATH))
            {
                try
                {
                    customers = serializer.Deserialize(sr) as List<Customer>;
                }
                catch
                {
                    return new List<Customer>();
                }
            }
            return customers;
        }
        public void SaveList(List<Customer> customers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamWriter sw = new StreamWriter(PATH))
            {
                serializer.Serialize(sw, customers);
            }
        }
    }
}
