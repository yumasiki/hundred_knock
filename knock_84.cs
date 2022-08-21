using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example.hundred_knock
{
    class Knock_84
    {
        public static void Main(String[] args)
        {
            var trumps = new List<string>();
            var suutes = new Dictionary<int, string>()
                {
                    {0, "ダイヤ"},
                    {1, "クローバー"},
                    {2, "スペード"},
                    {3, "ハート"}
                };
            string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            for (int i = 0; i < 4; ++i)
            {
                foreach (string value in values)
                {
                    string temp = suutes[i] + value;
                    trumps.Add(temp);
                }
            }

            var random = new Random();

            trumps = trumps.OrderBy(t => random.Next()).ToList();

            foreach(var trump in trumps)
            {
                Console.WriteLine(trump);
            }
        }
    }
}
