﻿using System;
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
           Console.WriteLine( us1.validateFirstName("Rohit"));
            Console.WriteLine(us1.validateLastName("Soni"));
        }
    }
}