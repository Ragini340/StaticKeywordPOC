using StaticKeywordPOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordPOC
{
    public class NationalParks
    {
        static public int n = 104;

        public static void Total()
        {
            Console.WriteLine("Total number of national parks present in India is :{0}", n);
        }
    }

    public class DriverClassNationalParks
    {
        static public void Main()
        {

            // Accessing the static method using its class name
            NationalParks.Total();

        }
    }
}


