using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class Knock_87
    {
        public static void Main(String[] args)
        {
            Console.Write("誕生日をYYYYMMDDの形式で入力してください:");
            int number = int.Parse(Console.ReadLine());
            int fate_number = Kabara(number);
            Console.WriteLine("運命数は" + fate_number);
        }

        public static int Kabara(int a)
        {
            int fate = 0;
            int result = 0;
            while(a > 0)
            {
                fate += a % 10;
                a = a / 10;
            }

            if(fate % 11 == 0)
            {
                result = fate;
            }
            else if (fate >= 10)
            {
                result = Kabara(fate);
            }
            else if(fate < 10)
            {
                result = fate;
            }
            return result;
        }
    }
}
