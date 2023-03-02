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
            regexPatten.ValidateName("Akash", "Girase");
            regexPatten.ValidateEmail("abc.xyz@bl.co.in");
            regexPatten.ValidateMobileNumber("91 8380885318");
            regexPatten.ValidatePasswordRoule1("password");
            regexPatten.ValidatePasswordRoule2("pasSword");
            Console.ReadLine();

        }
    }
}
