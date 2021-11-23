using System;

namespace Lab04
{
    class target
    {

        public struct ShotRes
        {
            public int x;
            public int y;

        }
        static void Main(string[] args)
        {
            ShotRes Shot;
            int Score = new();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите значение x");
                Shot.x = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите значение y");
                Shot.y = int.Parse(Console.ReadLine());

                double Result = Math.Sqrt(Shot.x * Shot.x + Shot.y * Shot.y);

                switch (Result)
                {
                    case <= 5:
                        Score += 10;
                        break;

                    case <= 10:
                        Score += 5;
                        break;

                    case <= 30:
                        Score += 1;
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Score: " + Score);
            }

        }
    }
}
