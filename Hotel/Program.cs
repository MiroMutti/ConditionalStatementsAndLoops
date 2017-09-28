using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceDoubleRoom = 0;
            double priceSuite = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50 * nights;
                priceDoubleRoom = 65 * nights;
                priceSuite = 75 * nights;

                if (nights > 7)
                { priceStudio = 50 * nights * 0.95; }
                
                if (month=="October" && nights>7)
                {
                    priceStudio = (50 * nights * 0.95)-50*0.95; 
                }
            }
            if (month =="June" || month=="September")
            {
                priceStudio = 60 * nights;
                priceDoubleRoom = 72 * nights;
                priceSuite = 82 * nights;

                if (nights>14)
                {
                    priceDoubleRoom = 72 * nights * 0.90;
                }
                if (month=="September" && nights>7)
                {
                    priceStudio = (60 * nights) - 60;
                }
            }
            if (month == "July" || month  == "August" || month== "December")
            {
                priceStudio = 68*nights;
                priceDoubleRoom = 77 * nights;
                priceSuite = 89 * nights;
                if (nights>14)
                {
                    priceSuite = 89 * nights * 0.85;
                }
            }
            Console.WriteLine("Studio: {0:F2} lv.", priceStudio);
            Console.WriteLine("Double: {0:F2} lv.",priceDoubleRoom);
            Console.WriteLine("Suite: {0:F2} lv.",priceSuite);
        }
    }
}
