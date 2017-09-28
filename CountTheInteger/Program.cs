using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    counter += 1;
                }
                catch (OverflowException)
                {

                    break;
                }
                catch (FormatException) { break; }
            }
            Console.WriteLine(counter);
        }
    }
}
