using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using aula01HerPol.Entities;

namespace aula01HerPol
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            //Console.WriteLine(account.Balance);

            // account.Balance = 200.0;

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //testes de upcasting

            //Upcasting, da classe sub para a super, Polimorfismo
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //Downcasting, da classe super para a sub, é preciso explicitar, só usado quando necessário, não é uma operação segura para o compilador
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // não compila pois o método loan não pertence a account acc2.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; erro que o compilador não pode prever, quando uma sub tenta executar o método de outra.
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
