using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexPatten regexPatten = new RegexPatten();
            regexPatten.ValidateNameFirstName("Akash");
            regexPatten.ValidateNameLastName("Girase");
            regexPatten.ValidateEmail("abc@yahoo.com");
            regexPatten.ValidateMobileNumber("91 8380885318");
            regexPatten.ValidatePasswordRoule1("password");
            regexPatten.ValidatePasswordRoule2("pasSword");
            regexPatten.ValidatePasswordRoule3("pasSwor1");
            regexPatten.ValidatePasswordRoule4("1234@aka");
            Console.ReadLine();
        }
    }
}