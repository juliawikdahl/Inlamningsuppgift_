using Inlamningsuppgift;


List<Customer> mycustomer = new List<Customer>();

string filePath = "minakunder.txt";
try
{
    var minakunder = File.ReadAllLines(filePath);
    foreach (var customerInText in minakunder)
    {
        var splitCustomerInText = customerInText.Split(',');
        mycustomer.Add(new Customer(splitCustomerInText[0], splitCustomerInText[1], splitCustomerInText[2], mycustomer.Count, splitCustomerInText[3]));

    }
}
catch (Exception ex)
{
    Console.WriteLine("FEL! Meddelande " + ex.Message);
}

bool isrunning = true;
while (isrunning)
{

    {
        Console.WriteLine("[1] Lägg till i listan");
        Console.WriteLine("[2] Ta bort en ur listan");
        Console.WriteLine("[3] Visa alla i listan");
        Console.WriteLine("[4] Få en rabattkod");
        if (int.TryParse(Console.ReadLine(), out int menyval))
        {
            switch (menyval)
            {
                case 1:
                    {
                        var customer = new Customer();
                        Console.WriteLine("Förnamn: ");
                        customer.Firstname = Console.ReadLine();
                        Console.WriteLine("Efternamn: ");
                        customer.Lastname = Console.ReadLine();
                        Console.WriteLine("Epostadress: ");
                        customer.Email = Console.ReadLine();
                        Console.WriteLine("matpreferenser?");
                        customer.SpecialFood = Console.ReadLine();
                        customer.Index = mycustomer.Count;
                        mycustomer.Add(customer);

                        FileHandler.SaveToFile(filePath, mycustomer);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Radera en kund genom att skriva indexnumret på den du vill ta bort");

                        foreach (var custom in mycustomer)
                            Console.WriteLine(custom.GetCustomerData());

                        mycustomer.RemoveAt(int.Parse(Console.ReadLine()));
                        FileHandler.SaveToFile(filePath, mycustomer);
                        break;
                    }
                case 3:
                    {

                        for (int i = 0; i < mycustomer.Count(); ++i)

                            foreach (var custom in mycustomer)
                                Console.WriteLine(custom.GetCustomerData());
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine(DiscountCode.GenerateDiscountCode());
                        DiscountCode.SendOutDiscountCode(mycustomer);
                        break;
                    }

                case 5:
                    {
                        isrunning = false;
                        break;

                    }
            }
        }
    }
}
