namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------ Extention Methods Egyption phoneNumber valition extention -------");
            Console.WriteLine($"test 1 {StringValidationExtensions.IsValidEgyptianPhone("01012345678")}");
            Console.WriteLine($"test 2 {StringValidationExtensions.IsValidEgyptianPhone("+201512345678")}");
            Console.WriteLine($"test 3 {StringValidationExtensions.IsValidEgyptianPhone("01312345678")}");
            Console.WriteLine($"test 4 {StringValidationExtensions.IsValidEgyptianPhone("0101234567")}");
            Console.WriteLine($"test 5 {StringValidationExtensions.IsValidEgyptianPhone("0101234567a")}");

            Console.WriteLine("------ Extention Methods Egyption Identify number valition extention -------");
            Console.WriteLine($"test 1 {StringValidationExtensions.IsValidEgyptianNationalId("29901011234567")}");
            Console.WriteLine($"test 2 {StringValidationExtensions.IsValidEgyptianNationalId("19901011234567")}");
            Console.WriteLine($"test 3 {StringValidationExtensions.IsValidEgyptianNationalId("2990101123456")}");
           
        }
    }
}
