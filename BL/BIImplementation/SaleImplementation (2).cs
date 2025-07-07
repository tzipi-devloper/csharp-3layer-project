using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace BIImplementation
{
    public class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.Sale.Create(item.convertBOSaleToDOSale());
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
                _dal.Sale.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public BO.Sale? Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id).convertDOSaleToBOSale();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(s => filter(s.convertDOSaleToBOSale())).convertDOSaleToBOSale();
            }
            catch(Exception ex) 
            {
                return null;
            }       
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Sale.ReadAll().Select(s => s.convertDOSaleToBOSale()).ToList();
                return _dal.Sale.ReadAll(s => filter(s.convertDOSaleToBOSale())).Select(s => s.convertDOSaleToBOSale()).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while reading all customers", ex);
            }
        }
        public void Update(BO.Sale item)
        {
            try
            {
                _dal.Sale.Update(item.convertBOSaleToDOSale());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
