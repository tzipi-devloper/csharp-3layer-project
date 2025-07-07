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
    internal class SaleImplementation:Isale
    {
        const string PATH = @"..\xml\sales.xml";

        public int Create(Sale sale)
        {
            Sale s = sale with { IdNumber = Config.MinSaleNumber };
            List<Sale> sales = LoadList();
            sales.Add(s);
            SaveList(sales);
            return s.IdNumber;
        }

        public void Delete(int id)
        {
            List<Sale> sales = LoadList();
            Sale Sale = sales.FirstOrDefault(Sale => Sale.IdNumber == id);
            sales.Remove(Sale);
            SaveList(sales);
        }

        public Sale? Read(int id)
        {
            List<Sale> sales = LoadList();
            return sales.FirstOrDefault(sale => sale.IdNumber == id);
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            List<Sale> sales = LoadList();
            return sales.FirstOrDefault(filter);
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            List<Sale> sales = LoadList();
            if (!sales.Any())
            {
                throw new DalIdNotExistException("Sales not found");
            }
            if (filter != null)
            {
                IEnumerable<Sale> SalesList = sales.Where(c => filter(c)).Select(c => c);
                return SalesList.Cast<Sale?>().ToList();
            }
            return sales;
        }

        public void Update(Sale item)
        {
            List<Sale> sales = LoadList();
            Sale? sale = sales.FirstOrDefault(c => c.IdNumber == item.IdNumber);
            if (sale == null)
            {
                throw new DalIdNotExistException("Sale not found");
            }
            sales.Remove(sale);
            sales.Add(item);
            SaveList(sales);
        }
        public List<Sale> LoadList()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> sales;
            using (StreamReader sr = new StreamReader(PATH))
            {
                try
                {
                    sales = serializer.Deserialize(sr) as List<Sale>;
                }
                catch
                {
                    return new List<Sale>();

                }
            }
            return sales;
        }
        public void SaveList(List<Sale> sales)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (StreamWriter sw = new StreamWriter(PATH))
            {
                serializer.Serialize(sw, sales);
            }
        }
    }
}
