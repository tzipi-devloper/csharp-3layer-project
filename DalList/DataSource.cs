

namespace Dal;
using DO;

internal static class DataSource
{
    internal static List<Customer> customers = new List<Customer>();
    internal static List<Product> products = new List<Product>();
    internal static List<Sale> sales = new List<Sale>();

    internal static class Config
    {
        internal const int minProductNumber = 1000;
        private static int prevProductNumber = minProductNumber;


        internal const int minSaleNumber = 5000;
        private static int prevSaleNumber = minSaleNumber;

        public static int GetProductNum
        {
            get { return prevProductNumber++; }
        }
        public static int GetSaleNum
        {
            get { return prevSaleNumber++; }
        }


    }
}