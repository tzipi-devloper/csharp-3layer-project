using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DO
{
    // מבצעים והנחות בחנות
    public record Sale
        (int IdNumber,
        int ProductId,
        int CountInSale,
        int TotalPrice,
        bool AllCustomer,
        DateTime StartSale,
        DateTime EndSale
        )
    {
        public Sale():this(-1,0,0,0,false,DateTime.Now, DateTime.Now)
        {
           
        }

    }
}
