using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLambda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegistrationLambda registrationLambda = new RegistrationLambda();
            registrationLambda.CheckFirstName("Akash");
            Console.ReadLine();
        }
    }
}