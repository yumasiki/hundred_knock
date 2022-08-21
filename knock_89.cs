using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class Knock_89
    {
        public static void Main(String[] args)
        {
            int max = 99;
            int min = 1;
            int count = 0;
            Judge(max,min,count);
        }

        public static int Judge(int max,int min,int count)
        {
            int answer = 1;
            int middle_point = (min + max) / 2;

            while(answer != 0)
            {
                count += 1;
                Console.Write(middle_point + "ですか?");
                answer = int.Parse(Console.ReadLine());
                if(answer == 0)
                {
                    break;
                }
                else if (answer > 0)
                {
                    min = middle_point;
                    middle_point = (min + max) / 2;
                }
                else if (answer < 0)
                {
                    max = middle_point;
                    middle_point = (min + max) / 2;
                }
            }
            Console.WriteLine(count + "回で当てました");
            return 0;
        }

    }
}
