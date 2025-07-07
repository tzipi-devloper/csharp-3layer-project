
using DO;
using DalApi;
namespace DalTest;
public static class Initialization
{ 
    private static IDal? s_dal;

    private static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(123, "Tzipi", "Shagat", "0504170765"));
        s_dal.Customer.Create(new Customer(1235, "Ayala", "Rashi", "0534189017"));
        s_dal.Customer.Create(new Customer(2345, "Sara", "Rambam", "0503134631"));
        s_dal.Customer.Create(new Customer(1345, "Chana", "Meromey Sade", "0524114531"));
        s_dal.Customer.Create(new Customer(135, "Mira", "Mesilat Yosef", "0549012388"));
        s_dal.Customer.Create(new Customer(123455, "Shira", "Rashba", "0534189945"));
    }
    private static void CreateProduct()
    {
        s_dal.Product.Create(new Product(1, "נעלי ספורט לגברים - כחול", Category.Nike, 750, 10));
        s_dal.Product.Create(new Product(2, "נעלי בית לנשים - ורוד", Category.Adidas, 320, 15));
        s_dal.Product.Create(new Product(3, "כפכפים לילדים - ירוק", Category.Puma, 210, 20));
        s_dal.Product.Create(new Product(4, "סנדלים לנשים - חום", Category.NewBalance, 480, 12));
        s_dal.Product.Create(new Product(5, "מגפיים לגברים - שחור", Category.Nike, 990, 7));
        s_dal.Product.Create(new Product(6, "נעלי עקב לנשים - אדום", Category.Adidas, 860, 5));
        s_dal.Product.Create(new Product(7, "נעלי ספורט לילדים - צהוב", Category.Puma, 390, 25));
        s_dal.Product.Create(new Product(8, "נעלי אלגנט לגברים - אפור", Category.NewBalance, 670, 9));
    }

    private static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(2, 5001, 7, 500, true, DateTime.Now, DateTime.Now.AddDays(10)));
        s_dal.Sale.Create(new Sale(1, 5002, 4, 80, false, DateTime.Now, DateTime.Now.AddYears(1)));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateSale();
        CreateProduct();
        CreateCustomer();
    }
}
