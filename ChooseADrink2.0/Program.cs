using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete": Console.WriteLine("The {0} has to pay {1:F2}.", profession, (0.70*quantity)); break;
                case "Businessman":Console.WriteLine("The {0} has to pay {1:F2}.", profession, (1.00 * quantity)); break;
                case "Businesswoman": Console.WriteLine("The {0} has to pay {1:F2}.", profession, (1.00 * quantity)); break;
                case "SoftUni Student": Console.WriteLine("The {0} has to pay {1:F2}.", profession, (1.70 * quantity)); break;
                default:
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, (1.20 * quantity));
                    break;
            }
        }
    }
}
