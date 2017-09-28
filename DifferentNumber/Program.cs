using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if (endNum - startNum >= 5)
            {
                for (int i = startNum; i <= endNum - 4; i++)
                {
                    for (int j = i + 1; j <= endNum - 3; j++)
                    {
                        for (int k = j + 1; k <= endNum - 2; k++)
                        {
                            for (int l = k + 1; l <= endNum - 1; l++)
                            {
                                for (int m = l + 1; m <= endNum; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
            else Console.WriteLine("No");
        }
    }
}
