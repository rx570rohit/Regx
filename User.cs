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
        public static String LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static String MobNo = "^[1-9]{2}[: :][0-9]{10}$";
        public static String Email = @"^([a-z]+)(\.[a-z0-9_\+\-]+)@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";
        public bool validateFirstName(String fname)
        {
            return Regex.IsMatch(fname, FirstName);
        }

        public bool validateLastName(String lname) 
        {
            return Regex.IsMatch(lname, LastName);
        }
        public bool validateMobNo(String mobno)
        {
            return Regex.IsMatch(mobno, MobNo);
        }
        public bool validateEmail(String email)
        {
            return Regex.IsMatch(email,Email);
        }

    }
}
