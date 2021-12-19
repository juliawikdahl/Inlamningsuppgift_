using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift
{

    public static class FileHandler
    {
        public static void SaveToFile(string filePath, List<Customer> mycustomer)
        {
            File.WriteAllText(filePath, String.Empty);
            foreach (var c in mycustomer)
            {
                File.AppendAllText(filePath, c.ConvertToCommaSeparatedList() + "\n");
            }
        }
    }
}

