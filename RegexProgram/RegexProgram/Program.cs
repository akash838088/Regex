using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexPatten regexPatten = new RegexPatten();
            regexPatten.ValidateName("Akash", "Girase");
            Console.ReadLine();

        }
    }
}
