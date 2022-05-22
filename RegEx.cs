using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _21MayTest
{
    internal class RegEx
    {
        public static string REGEX_PHONE = "^[6-9][0-9]{9}$";
        public static string REGEX_EMAIL = @"^[\w \- . ]{1,}@?[a-z A-Z]{2,}.?(com)$";


        public bool validatePhone(string phone)
        {

            return Regex.IsMatch(phone, REGEX_PHONE);
        }


        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
