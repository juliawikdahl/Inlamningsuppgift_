using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift
{
    public static class DiscountCode
    {
        public static string GenerateDiscountCode()
        {
            return "Rabatt" + DateTime.Now.Date.ToShortDateString();
        }

        public static void SendOutDiscountCode(List<Customer> mycustomer)
        {
            foreach (var customer in mycustomer)
                Console.WriteLine($"Skickar ut rabattkod {GenerateDiscountCode()} till {customer.Email}");
        }

    }
}