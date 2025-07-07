using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class Config
    {
        const string filePath = @"../xml/data-config.xml";
        static XElement runNumber;

        public static int MinSaleNumber
        {
            get{
                runNumber = XElement.Load(filePath);
                int minSaleNumber;
                if (!int.TryParse(runNumber.Element("MinSaleNumber").Value, out minSaleNumber))
                    minSaleNumber = 100;

                runNumber.Element("MinSaleNumber").SetValue(minSaleNumber + 1);
                runNumber.Save(filePath);
                return minSaleNumber;
            }
        }


        public static int MinProductNumber
        {
            get{
                runNumber = XElement.Load(filePath);
                int minProductNumber;
                if (!int.TryParse(runNumber.Element("MinProductNumber").Value, out minProductNumber))
                    minProductNumber = 100;

                runNumber.Element("MinProductNumber").SetValue(minProductNumber +1);
                runNumber.Save(filePath);
                return minProductNumber;
            }
        }
    }
}
