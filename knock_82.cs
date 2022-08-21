using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class knock_82
    {

        public static void Main(String[] args)
        {
            int[,] Pascal = new int[2000, 2000];
            for (int i = 0; i < 15; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    if (i == 0 && j == 0)
                    {
                        Pascal[i, j] = 1;
                        Console.Write(Pascal[i, j]);
                        Console.WriteLine();
                        continue;
                    }
                    else if (i != 0 && j == 0)
                    {
                        Pascal[i, j] = 1;
                        Console.Write(Pascal[i, j]);
                        Console.Write(",");
                        continue;
                    }
                    else if (i == j)
                    {
                        Pascal[i, j] = 1;
                        Console.Write(Pascal[i, j]);
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Pascal[i, j] = Pascal[i - 1, j - 1] + Pascal[i - 1, j];
                        Console.Write(Pascal[i, j]);
                        Console.Write(",");
                    }
                }
            }
        }
    }
}
