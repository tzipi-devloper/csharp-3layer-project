using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;
namespace BIImplementation
{
    public class ProductImplementation:IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;


        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(item.convertDOPrductToBOProduct());
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
                _dal.Product.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public BO.Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(id).convertDOPrductToBOProduct();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(s => filter(s.convertDOPrductToBOProduct())).convertDOPrductToBOProduct();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Product.ReadAll().Select(p => p.convertDOPrductToBOProduct()).ToList();
                return _dal.Product.ReadAll(p => filter(p.convertDOPrductToBOProduct())).Select(p => p.convertDOPrductToBOProduct()).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while reading all products", ex);
            }
        }
        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item.convertDOPrductToBOProduct());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
