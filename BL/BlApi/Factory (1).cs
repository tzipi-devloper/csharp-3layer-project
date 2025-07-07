using BIImplementation;
using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{

    public static class Factory
    {
        public static IBI Get()
        {
            return new BI(); // Return an instance of the BI class
        }
    }


}
