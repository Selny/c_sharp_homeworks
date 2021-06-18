using System;

namespace hw2
{
    class Program
    {

        class Point {
            public int x, y;

            public Program() {
                x = y = 0;
            }
            public Program(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            void ShowData()
            {
                Console.WriteLine($"X: {x}\nY: {y}");
            }
        }

        
        static void Main(string[] args)
        {
            
        }
    }
}
