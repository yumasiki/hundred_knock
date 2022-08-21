using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class Knock_85
    {
        public static void Main(String[] args)
        {
            int stone = 0;
            while (stone < 10) {
                Console.Write("石の数を入力してください。（10以上）：");
                stone = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Pick_Up(stone));
        }

        public static string Pick_Up(int a)
        {
            int pick_up_stone1 = 0;
            int pick_up_stone2 = 0;
            string result = null;
            Console.WriteLine("石の数:" + a + "個");

            while (a > 1)
            {
                Console.WriteLine("プレイヤー1の番です。");

                //１～３個の間で石をとるまで何度もやり直し
                while (pick_up_stone1 <= 0 || pick_up_stone1 > 3)
                {
                    Console.Write("何個取る（1~3個）?：");
                    pick_up_stone1 = int.Parse(Console.ReadLine());
                }
                a -= pick_up_stone1;
                Console.WriteLine("石の数:" + a + "個");

                //プレイヤー１の勝ち負けを判定
                //プレイヤー１が石をとった後の個数が1個の場合
                if (a == 1)
                {
                    result = "プレイヤー1の勝ち";
                    break;
                }
                //残りの石を1個以上残さずに石を取った場合
                else if (a <= 0)
                {
                    result = "プレイヤー1の負け";
                    break;
                }
                //まだ勝敗がついていない場合
                else
                {
                    pick_up_stone1 = 0;
                }

                Console.WriteLine("プレイヤー2の番です。");

                //１～３個の間で石をとるまで何度もやり直し
                while (pick_up_stone2 <= 0 || pick_up_stone2 > 3)
                {
                    Console.Write("何個取る（1~3個）?：");
                    pick_up_stone2 = int.Parse(Console.ReadLine());
                }
                a -= pick_up_stone2;
                Console.WriteLine("石の数:" + a + "個");

                //プレイヤー2の勝ち負けを判定
                //プレイヤー2が石をとった後の個数が1個の場合
                if (a == 1)
                {
                    result = "プレイヤー2の勝ち";
                    break;
                }
                //残りの石を1個以上残さずに石を取った場合
                else if (a <= 0)
                {
                    result = "プレイヤー2の負け";
                    break;
                }
                //まだ勝敗がついていない場合
                else
                {
                    pick_up_stone2 = 0;
                }
            }
            return result;
        }
    }
}
