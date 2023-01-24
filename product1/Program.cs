using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static product1.salesperson;

namespace product1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("Kishor", 41000);
            m1.CalculateSalary();
            Console.WriteLine(m1.DisplayManagerDetails());


            salesperson s1 = new salesperson("Tushar", 27000);
            s1.CalculateSalary();
            Console.WriteLine(s1.salespersonDetails());


        }
    }
}
