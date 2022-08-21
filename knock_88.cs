using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class Knock_88
    {
        public static void Main(String[] args)
        {
            Random r = new Random();
            int random_value = r.Next(1, 100);
            int count = 0;
            int number = 0;
            Judge(random_value, count, number);
        }

        public static int Judge(int random,int count,int number)
        {
            while (random != number)
            {
                count += 1;
                Console.Write("数を入力: ");
                number = int.Parse(Console.ReadLine());
                if (random == number)
                {
                    break;
                }
                else if(random > number)
                {
                    Console.WriteLine("それより大きいです");
                }
                else
                {
                    Console.WriteLine("それより小さいです");
                }
            }
            Console.WriteLine("正解!! " + count +"回でクリア");
            return 0;
        }
    }
}
