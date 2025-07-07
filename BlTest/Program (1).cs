using BlApi;

using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using BO;
using DalTest;
using BIImplementation;
namespace BlTest
{
    internal class Program
    {
        public static readonly BlApi.IBI s_bl = BlApi.Factory.Get();

        public static void StartOrder()
        {
            int userId;
            Console.WriteLine("Enter user ID (or 0 for a guest):");
            userId = int.Parse(Console.ReadLine());

            int totalPayment = 0;
            bool continueOrdering = true;

            while (continueOrdering)
            {
                Console.WriteLine("Enter product code:");
                int code = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter amount:");
                int amount = int.Parse(Console.ReadLine());

                ProductImplementation productImplementation = new ProductImplementation();
                BO.Product? product = productImplementation.Read(code);

                if (product != null)
                {
                    Console.WriteLine($"Product Price: {product.Price}");

                    SaleImplementation saleImplementation = new SaleImplementation();
                    List<BO.Sale?> sales = saleImplementation.ReadAll();

                    int paymentForThisProduct = 0;

                    foreach (var sale in sales)
                    {
                        if (sale != null && sale.ProductId == code)
                        {
                            while (sale.CountInSale >= amount)
                            {
                                paymentForThisProduct += sale.TotalPrice;
                                amount -= sale.CountInSale;
                            }
                            if (amount > 0)
                                paymentForThisProduct += amount * (int)product.Price;
                        }
                    }

                    if (amount > 0)
                    {
                        paymentForThisProduct += amount * (int)product.Price;
                    }

                    totalPayment += paymentForThisProduct;
                    Console.WriteLine($"Current total payment for this order: {totalPayment}");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }

                Console.WriteLine("Do you want to add another product? (yes/no)");
                string response = Console.ReadLine();
                continueOrdering = response.Equals("yes", StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine($"Final total payment for the order: {totalPayment}");
            Console.WriteLine("Do you want to start a new order or exit the program? (new/exit)");
            string nextStep = Console.ReadLine();
            if (nextStep.Equals("new", StringComparison.OrdinalIgnoreCase))
            {
                StartOrder(); // להתחיל הזמנה חדשה
            }
            else
            {
                Console.WriteLine("Exiting the program.");
            }
        }

        static void Main(string[] args)
        {
            Initialization.Initialize();
            StartOrder();
            Console.ReadLine();
        }
    }
}



