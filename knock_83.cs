using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class Knock_83
    {
        public static int number = 0;
        public static int player_win = 0;
        public static int computer_win = 0;

        public static void Main(String[] args)
        {
            while (number < 5)
            {
                Console.Write("あなたの手を選んでください(グー0、チョキ1、パー2):");
                int a = int.Parse(Console.ReadLine());
                Random r1 = new System.Random();
                int b = r1.Next(0, 3);
                var rpc = new Dictionary<int, string>()
                {
                    {0, "グー"},
                    {1, "チョキ"},
                    {2, "パー"}
                };


                if (a < 0 || a > 2) {
                    number += 1;
                    computer_win += 1;
                    Console.Write("そんな手はありません。あなたの負けです。");
                    continue;
                }

                if (Janken(a,b) == 0)
                {
                    computer_win += 1;
                }
                else if (Janken(a,b) == 1){
                    player_win += 1;
                }
                else if(Janken(a,b) == 2){
                    Console.WriteLine("あいこです。");
                    continue;
                }
                number += 1;
                Console.WriteLine("コンピューターは" + rpc[b]);
                Console.WriteLine("あなた：" + player_win + "勝、" + "コンピューター：" + computer_win + "勝");

            }

            Console.WriteLine(Judge(player_win, computer_win));

        }

        //じゃんけんを行い、その結果を判定(０：コンピューターの勝ち、１：プレイヤーの勝ち、２：あいこ）
        public static int Janken(int a, int b)
        {
            if(a == b - 1 || b == a + 2)
            {
                return 0;
            }
            else if(b == a - 1 || a == b + 2)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        } 

        //どちらかが多く勝利したかを判定
        public static string Judge(int a,int b)
        {
            if (a > b)
            {
                string result = "あなたの総合勝利です。参りました。";
                return result;
            }
            else
            {
                string result = "コンピューターの総合勝利です。ありがとうございました。";
                return result;
            }
        }
    }
}
