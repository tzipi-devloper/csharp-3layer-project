using DalApi;
using System.Diagnostics;


namespace Dal
{
    internal sealed class DalXml:IDal
    {
        private DalXml() { }
        public Iproduct Product => new ProductImplementation();
        public Isale Sale => new SaleImplementation();
        public Icustomer Customer => new CustomerImplementation();
        public static DalXml Instance { get; } = new DalXml();
    }
}
