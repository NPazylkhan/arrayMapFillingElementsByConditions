using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayRiskMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[10, 10];
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            for(int i = 0; i < n.GetLength(0); i++)
            {
                for(int j = 0; j < n.GetLength(1); j++)
                {
                    if (i-2 > j)
                    {
                        n[i, j] = 0;
                    }

                    else if (i < j-2)
                    {
                        n[i, j] = 0;
                    }
                    
                    else
                    {
                        n[i, j] = 5;
                    }
                }
            }

            for(int i = 0; i < n.GetLength(0); i++)
            {
              for(int j = 0; j < n.GetLength(1); j++)
                {
                    Console.Write(n[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
