using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using ExfixaçãoException01.Entities;
using ExfixaçãoException01.Entities.Exceptions;

namespace ExfixaçãoException01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New Balance: "+ acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: "+e.Message);
            }



        }
    }
}
