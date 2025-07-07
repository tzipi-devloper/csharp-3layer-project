using DalApi;
using Dal;
using DO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
namespace DalTest
{
    internal class Program
    {
        public delegate void CreateUpdateDel();
        private readonly static IDal s_dal = DalApi.Factory.Get;

        public static void PrintMainMenu()
        {
            Console.WriteLine("To product press 1");
            Console.WriteLine("To sale press 2");
            Console.WriteLine("To customer press 3");
            int select;
            if (!(int.TryParse(Console.ReadLine(), out select))) select = -1;             
            try
            {                 
                while (select != 0)
                {
                    switch (select)
                    {
                        case 1:                          
                            SubMenu("product",s_dal.Product, AddProduct, UpdateProduct);
                            break;
                        case 2:
                            SubMenu("sale",s_dal.Sale, AddSale, UpdateSale);

                            break;
                        case 3:
                            SubMenu("client",s_dal.Customer, AddCustomer, UpdateCustomer);

                            break;
                        default:
                            Console.WriteLine("Worng choose");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static int PrintSubMenu(string item)
        {
            Console.WriteLine();
            int select;
            if (!(int.TryParse(Console.ReadLine(), out select)))
                select = -1;

            return select;
        }
        public static void SubMenu<T>(string item, ICrud<T> crud, CreateUpdateDel createDel, CreateUpdateDel updateDel)
        {
            Console.WriteLine($"to add {crud} press 1");
            Console.WriteLine($"to show {crud} press 2");
            Console.WriteLine($"to show all {crud} press 3");
            Console.WriteLine($"to update {crud} press 4");
            Console.WriteLine($"to delete {crud} press 5");
            Console.WriteLine("to back press 0");
            int select = PrintSubMenu(item); 
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        createDel();
                        break;
                    case 2:
                        Read(crud);
                        break;
                    case 3:
                        ReadAll(crud);
                        break;
                    case 4:
                        updateDel();
                        break;
                    case 5:
                        Delete(crud);
                        break;
                    default:
                        Console.WriteLine("בחירה שגויה");
                        break;
                }
                select = PrintSubMenu(item); //הדפסת תת תפריט
            }
        }

        public static void AddProduct()
        {
            Product p = AskProduct();
            int code = s_dal.Product.Create(p);
            Console.WriteLine("The product is succsfull");
            Console.WriteLine(p);
        }
        public static void AddCustomer()
        {
            Customer c = AskCustumer();
            int code = s_dal.Customer.Create(c);
            Console.WriteLine("The customer is succsfull");
            Console.WriteLine(c);
        }
        public static void AddSale()
        {
            Sale s = AskSale();
            int code = s_dal.Sale.Create(s);
            Console.WriteLine("The sale is succsfull");
            Console.WriteLine(s);
        }
        public static void UpdateProduct()
        {
            try
            {
                Console.WriteLine("Enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(s_dal.Product.Read(code));
                Product p = AskProduct(code);
                s_dal.Product.Update(p);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateCustomer()
        {
            try
            {
                Console.WriteLine("Enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(s_dal.Customer.Read(code));
                Customer c = AskCustumer();
                s_dal.Customer.Update(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateSale()
        {
            try
            {
                Console.WriteLine("Enter code");
                int code = int.Parse(Console.ReadLine());
                Sale s = AskSale(code);
                s_dal.Sale.Update(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Product AskProduct(int code = 0)
        {
            string productName;
            Category category;
            double price;
            int countInStock;
            Console.WriteLine("Press product name");
            productName = Console.ReadLine();
            int cat;
            Console.WriteLine("Enter category: \n to puma press 0 \n to adidas press 1 \n to Nike press 2 \n to NewBalance press 3 ");
            if (!int.TryParse(Console.ReadLine(), out cat)) category = 0;
            else
                category = (Category)cat;
            Console.WriteLine("Enter Price");
            if (!double.TryParse(Console.ReadLine(), out price)) price = 0;
            Console.WriteLine("Enter coun of stack");
            if (!int.TryParse(Console.ReadLine(), out countInStock)) countInStock = 0;
            return new Product(code, productName, category, price, countInStock);
        }
        public static Customer AskCustumer()
        {
            int id;
            string customerName;
            string address;
            string phone;
            Console.WriteLine("Enter id");
            if (!int.TryParse(Console.ReadLine(), out id)) id = 0;
            Console.WriteLine("Press customer name");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter adress");
            address = Console.ReadLine();
            Console.WriteLine("Enter phone");
            phone = Console.ReadLine();
            return new Customer(id, customerName, address, phone);
        }
        public static Sale AskSale(int code = 0)
        {
            int productId;
            int countInSale;
            int totalPrice;
            bool allCustomer;
            DateTime startSale;
            DateTime endSale;
            int select;
            Console.WriteLine("Press productId");
            if (!int.TryParse(Console.ReadLine(), out productId)) productId = 0;
            Console.WriteLine("Press countInSale");
            if (!int.TryParse(Console.ReadLine(), out countInSale)) countInSale = 0;
            Console.WriteLine("Press totalPrice");
            if (!int.TryParse(Console.ReadLine(), out totalPrice)) totalPrice = 0;
            Console.WriteLine("Press allCustomer 0/1");
            if (!int.TryParse(Console.ReadLine(), out select)) select = 1;
            allCustomer = (select == 1);
            Console.WriteLine("Enter how many day is start a sale");
            if (!int.TryParse(Console.ReadLine(), out select)) select = 0;
            startSale = DateTime.Now.AddDays(select);
            Console.WriteLine("Enter how many day is start a sale");
            if (!int.TryParse(Console.ReadLine(), out select)) select = 0;
            endSale = startSale.AddDays(select);
            return new Sale(code,productId, countInSale, totalPrice, allCustomer, startSale, endSale);
        }
        private static void Read<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(crud.Read(code));
            }
            catch (Exception e)
            {
                //{
                //    Console.WriteLine(e.Message);
                //}
                throw new DalCodeExistException("code is not found", e);
            }
        }
        private static void ReadAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        private static void Delete<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("enter code");
                int code = int.Parse(Console.ReadLine());
                crud.Delete(code);
            }
            catch (Exception e)
            {
                //    {
                //        Console.WriteLine(e.Message);
                //    }
                 throw new DalCodeExistException("code is not found", e);
            }
        }
        static void Main(string[] args)
        {
            Initialization.Initialize();
            PrintMainMenu();
            Console.ReadLine();
        }
    }
    }



