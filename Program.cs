using System;

namespace hw1
{
    class Program
    {
        public static void sum(int num1, int num2, out int? result)
        {
            result = num1 + num2;
        }
        public static void dif(int num1, int num2, out int? result)
        {
            result = num1 - num2;
        }
        public static void mult(int num1, int num2, out int? result)
        {
            result = num1 * num2;
        }
        public static void div(int num1, int num2, ref int? result)
        {
            if (num2 != 0) result = num1 / num2;
            else Console.WriteLine("Error. Division to zero doen't exist!");
        }
        static void Main(string[] args)
        {
            int a, b;
            int? result = null;
            Console.Write("Number1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operator: ");
            bool isOkay = Char.TryParse(Console.ReadLine(), out char opera);
            Console.Write("Number2: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (isOkay)
            {
                switch (opera)
                {
                    case '+':
                        sum(a, b, out result);
                        break;
                    case '-':
                        dif(a, b, out result);
                        break;
                    case '*':
                        mult(a, b, out result);
                        break;
                    case '/':
                        div(a, b, ref result);
                        break;
                    default:
                        System.Console.WriteLine("Operator is unavailable");
                        break;
                }
                System.Console.WriteLine($"Result = {result}");
            }
            else System.Console.WriteLine("Char can't converted");

        }
    }
}
