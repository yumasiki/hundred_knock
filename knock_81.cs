using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class knock_81
    {
    
    public static int Central(int a,int b, int c)
        {
            List<int> suuchi = new List<int>();
            suuchi.Add(a);
            suuchi.Add(b);
            suuchi.Add(c);

            suuchi.Sort();
            int d = suuchi[1];
            return d;

        }


    public static void Main(String[] args)
        {
            //３つの整数値を入力させ、3つの値のうち2番目に大きい値を表示するプログラムを作成せよ。
            Console.WriteLine("整数値を一つ入れてください");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("整数値を一つ入れてください");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("整数値を一つ入れてください");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Central(a,b,c));
            

        }


    }


}
