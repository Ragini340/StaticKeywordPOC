using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordPOC
{
    static class StaticClass
    {
        public static string Topic = "Static class topic";
    }
   public class StaticDriver
    {
        static public void Main()
        {
            // Accessing the static data members of StaticClass
            Console.WriteLine("Topic name is : {0} ", StaticClass.Topic);
        }
    }
}
