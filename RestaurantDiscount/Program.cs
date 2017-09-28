using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double hallPrice = 0;
            double packPrice = 0;
            double discount = 0;
            string place = null;
            switch (package)
            {
                case "Normal": packPrice = 500; discount = 0.05; break;
                case "Gold": packPrice = 750; discount = 0.10; break;
                case "Platinum": packPrice = 1000; discount = 0.15; break;
                default:
                    break;
            }

            if (groupSize<=50)
            {
                place = "Small Hall";
                hallPrice = 2500;
               
            }
            if (groupSize>50 && groupSize<=100)
            {
                place = "Terrace";
                hallPrice = 5000;
            }
            if (groupSize>100 && groupSize<=120)
            {
                place = "Great Hall";
                hallPrice = 7500;
            }
            double finalPrice = (hallPrice + packPrice) - ((hallPrice + packPrice) * discount);
            Console.WriteLine("We can offer you the {0}",place);
            Console.WriteLine("The price per person is {0}$",finalPrice/groupSize);
        }
    }
}
