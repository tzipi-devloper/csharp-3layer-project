using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tools;
using static BO.Tools;
namespace BIImplementation
{
    public class CustomerImplementation:ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;


        public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.convertBOCustomerToDOCustomer());

            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        public BO.Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id).convertDOCustomerToBOCustomer();

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(s => filter(s.convertDOCustomerToBOCustomer())).convertDOCustomerToBOCustomer();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {

                return _dal.Customer.ReadAll()
                    .Select(c => c.convertDOCustomerToBOCustomer())
                    .Where(c => filter == null || filter(c))
                    .ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("Error while reading all customers", ex);
            }
        }
        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(item.convertBOCustomerToDOCustomer());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
