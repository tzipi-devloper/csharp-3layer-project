using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //פרטי הלקוחות בחנות
    public record Customer
        (int Id,
       string CustomerName,
       string Address,
       string Phone
        )
    {

        public Customer():this(999,"???","???","000")
        {
            
        }
    }
}
