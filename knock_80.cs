using System;
using System.Collections.Generic;
using System.Text;

namespace Example.hundred_knock
{
    class knock_80
    {
        public static int Gcd(int a, int b)
        {
            if(a%b == 0 )
            {
                return b;
            }
            else 
            {
                return Gcd(a, a % b);
            }

        }

        public static void Main(String[] args)
        {
            Console.WriteLine("正の整数を入力してください。");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("正の整数を入力してください。");
            int b = int.Parse(Console.ReadLine());

            if(Gcd(a, b) == 1)
            {
                Console.WriteLine("2つの整数は互いに素");
            }
            else
            {
                Console.WriteLine("2つの整数は互いに素ではない");
            }
            
        }



    }
}
