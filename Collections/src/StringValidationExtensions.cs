using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Collections
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string phoneNumber)
        {
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                if (phoneNumber.Length <= 10)
                    Console.WriteLine("false — only 10 digits");
                if (phoneNumber.Any(char.IsLetter))
                    Console.WriteLine("false - contian letter");
                return Regex.IsMatch(phoneNumber, @"^(?:\+20|0)1[0125]\d{8}$");
            }    
                
            return false;
        }

        public static bool IsValidEgyptianNationalId(this string IdentifyNumber)
        {
            if (!string.IsNullOrEmpty(IdentifyNumber))
                return Regex.IsMatch(IdentifyNumber, @"^[23]\d{13}$");
            return false;
        }
    }
}
