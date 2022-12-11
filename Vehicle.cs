using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordPOC
{
    class Vehicle
    {
        public static string Model_color = "Black";
    }
    public class  DriverClassVehicle
    {
        static public void Main()
        {
         // Accessing the static variable using its class name
         Console.WriteLine("Color of ABC model is  : {0} ",Vehicle.Model_color);
        }
    }
}
