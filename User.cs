using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegX
{
    internal class User
    {
        public static String FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool validateFirstName(String fname)
        {
            return Regex.IsMatch(fname, FirstName);
        }

    }
}
