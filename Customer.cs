using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift
{
    public class Customer
    {
        public Customer(string firstname, string lastname, string email, int index, string specialFood)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Index = index;
            SpecialFood = specialFood;
        }
        public Customer()
        { }


        public string Firstname { get; set; }
        public String Lastname { get; set; }
        public String Email { get; set; }
        public int Index { get; set; }
        public string SpecialFood { get; set; }
        public string Fullname => $"{Firstname} {Lastname}";



        public string GetCustomerData()
        {
            return ("Indexnummer: " + Index + "\n" + "Namn: " + Fullname + "\n" + "Epostadress: " + Email);
        }

        public string ConvertToCommaSeparatedList()
        {
            return $"{Firstname},{Lastname},{Email},{SpecialFood}";
        }
    }
}
