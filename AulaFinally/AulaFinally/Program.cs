using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\Users\Lucas Rodrigues\temp\herança e polimorfismo\AulaFinally\aulaFinally.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
