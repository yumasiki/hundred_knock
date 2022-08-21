using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class Knock_86
    {
        public static void Main(String[] args)
        {
            int stone = 0;
            while (stone < 10) {
                Console.Write("石の数を入力してください。（10以上）：");
                stone = int.Parse(Console.ReadLine());
            }

            if ((stone - 1) % 4 == 0)
            {
                Console.WriteLine(Koukou(stone));
            }
            else
            {
                Console.WriteLine(Senkou(stone));
            }
        }

        public static int pick_of_computer(int a)
        {
            int b = 4 - a;
            Console.WriteLine(b + "個とります。");
            return b;
        }

        public static string Koukou(int a)
        {
            int player_pick = 0;
            int computer_pick = 0;
            string result = null;
            Console.WriteLine("石の数:" + a + "個");
            Console.WriteLine("あなたからどうぞ。");
            while (a > 1)
            {
                //１～３個の間で石をとるまで何度もやり直し
                while (player_pick <= 0 || player_pick > 3)
                {
                    Console.Write("何個取る（1~3個）?：");
                    player_pick = int.Parse(Console.ReadLine());
                }
                a -= player_pick;
                Console.WriteLine("石の数:" + a + "個");

                //プレイヤーの勝ち負けを判定
                //プレイヤーが石をとった後の個数が1個の場合
                if (a == 1)
                {
                    result = "プレイヤーの勝ち";
                    break;
                }
                //残りの石を1個以上残さずに石を取った場合
                else if (a <= 0)
                {
                    result = "プレイヤーの負け";
                    break;
                }

                //（4 - "プレイヤーがとった石の数"）分、コンピューターは石をとる
                computer_pick = pick_of_computer(player_pick);
                player_pick = 0;
                a -= computer_pick;
                Console.WriteLine("石の数:" + a + "個");

                //コンピューターの勝ち負けを判定
                //コンピューターが石をとった後の個数が1個の場合
                if (a == 1)
                {
                    result = "コンピューターの勝ち";
                    break;
                }
                //残りの石を1個以上残さずに石を取った場合
                else if (a <= 0)
                {
                    result = "コンピューターの負け";
                    break;
                }
            }
            return result;
        }

        public static string Senkou(int a)
        {
            int player_pick = 0;
            int computer_pick = 0;
            string result = null;
            Console.WriteLine("石の数:" + a + "個");
            Console.WriteLine("では私から。");
            computer_pick = (a - 1) % 4;
            Console.WriteLine(computer_pick + "個取ります。");
            a -= computer_pick;
            Console.WriteLine("石の数:" + a + "個");


            while (a > 1)
            {
                //１～３個の間で石をとるまで何度もやり直し
                while (player_pick <= 0 || player_pick > 3)
                {
                    Console.Write("何個取る（1~3個）?：");
                    player_pick = int.Parse(Console.ReadLine());
                }
                a -= player_pick;
                Console.WriteLine("石の数:" + a + "個");

                //プレイヤーの勝ち負けを判定
                //プレイヤーが石をとった後の個数が1個の場合
                if (a == 1)
                {
                    result = "プレイヤーの勝ち";
                    break;
                }
                //残りの石を1個以上残さずに石を取った場合
                else if (a <= 0)
                {
                    result = "プレイヤーの負け";
                    break;
                }

                //（4 - "プレイヤーがとった石の数"）分、コンピューターは石をとる
                computer_pick = pick_of_computer(player_pick);
                player_pick = 0;
                a -= computer_pick;
                Console.WriteLine("石の数:" + a + "個");

                //コンピューターの勝ち負けを判定
                //コンピューターが石をとった後の個数が1個の場合
                if (a == 1)
                {
                    result = "コンピューターの勝ち";
                    break;
                }
                //残りの石を1個以上残さずに石を取った場合
                else if (a <= 0)
                {
                    result = "コンピューターの負け";
                    break;
                }
            }
            return result;
        }


    }
}
