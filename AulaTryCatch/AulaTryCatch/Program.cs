using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            //catch (Exception e)..... sempre colocar o tipo de exceção mais específico possivel
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ERROR " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("FORMAT ERROR " + e.Message);
            }


        }
    }
}
