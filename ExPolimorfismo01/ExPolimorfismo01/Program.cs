using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using ExPolimorfismo01.Entities;

namespace ExPolimorfismo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar lista para funcionarios
            List<Employee> List = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    List.Add(new OutsourcedEmployee(name, hours, valuePerhour, additionalCharge));
                }
                else
                {
                    List.Add(new Employee(name, hours, valuePerhour));
                }


            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in List)
            {
                Console.WriteLine(emp.Name+" - $ "+emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
