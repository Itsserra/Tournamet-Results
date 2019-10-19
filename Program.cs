using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tournament_Results
{
    class Program
    {
        
        private static Random rng = new Random();
        static void Main(string[] args)
        {
            var logFile = File.ReadAllLines("Teams.txt");
            var logList = new List<string>(logFile);
            for (int i = 0; i < logList.Count; i++)
            {
                Console.WriteLine($"logList { i } is {logList[i]}");
            };
            Shuffle(logList);
            Console.WriteLine("The shuffled list is: ");
            for (int i = 0; i < logList.Count; i++)
            {
                Console.WriteLine($"logList { i } is {logList[i]}");
            };


        }

        public static void Shuffle(List<string> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
