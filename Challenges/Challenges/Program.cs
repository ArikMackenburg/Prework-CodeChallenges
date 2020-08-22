using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1");
            Console.Write(Environment.NewLine);
            //int[] arr = new int[5] { 2, 2, 2, 2, 2 };
            //Console.WriteLine($"[{arr[0]},{arr[1]},{arr[2]},{arr[3]},{arr[4]}]");
            Console.WriteLine($"Final Score: {Challenge1.Grade(Challenge1.GradedArray(), Challenge1.SelectNumber())}");
        }
    }
    class Challenge1
    {
        public static int Grade(int[] numbers, int selection)
        {
            int times = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (selection == numbers[i])
                {
                    times++;
                }
            }
            int score = selection * times;
            return score;
        }

        public static int[] GradedArray()
        {
            Console.WriteLine("Select 5 Numbers between 1-10");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                int arrSpot = i + 1;
                Console.WriteLine($"Pick number {arrSpot}");
                var input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                arr[i] = num;
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine($"[{arr[0]},{arr[1]},{arr[2]},{arr[3]},{arr[4]}]");
            Console.Write(Environment.NewLine);
            return arr;
        }
        public static int SelectNumber()
        {
            Console.WriteLine("Pick a number to be graded");
            var input = Console.ReadLine();
            int selection = Convert.ToInt32(input);
            return selection;
        }

    }
}
