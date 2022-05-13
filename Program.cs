using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegX
{
    class Program
    {
        public static void Main(String []arg)
        {
            User us1 =new User();
            Console.WriteLine(us1.validateFirstName("Rohit"));
            Console.WriteLine(us1.validateLastName("Soni"));
            Console.WriteLine(us1.validateMobNo("91 8319871184"));
            Console.WriteLine(us1.validateEmail("rohit.soni2018@vitbhopal.ac.in"));
            Console.WriteLine(us1.validatePassWd("Rx@570soni"));

        }
    }
}