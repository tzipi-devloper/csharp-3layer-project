using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //ישות זו פועלת על מוצרי החנות 
    public record Product 
        (int Code,
        string ProductName,
        Category c,
        double Price,
        int CountInStock)
    {
        public Product():this(-1,"???",Category.Adidas,0,0)
        {
            
        }
    }
}
