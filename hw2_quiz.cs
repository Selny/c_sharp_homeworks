using System;

namespace hw
{
    class Program
    {
        public const byte row = 10;
        public const byte col = 4;
        static string[,] questions = new string[row,col] 
            {
                //Easy level
                {
                    "1. Which one of these programming languages isn't object-oriented:",
                    "C",
                    "C#",
                    "Java"
                },
                {
                    "2. Choose the fastest sorting algorithm from below:",
                    "Quicksort",
                    "Bubble",
                    "Insertion sort"
                },
                {
                    "3. Name of the default C# compiler in .NET platform:",
                    "Roslyn",
                    "clang",
                    "gcc"
                },
                //Medium level
                {
                    "4. Which one of programming language is the oldest from below:",
                    "Java",
                    "C#",
                    "F#"
                },
                {
                    "5. Which one is the new feature of C# 9.0:",
                    "Top-level statements",
                    "Readonly members",
                    "Tuples"
                },
                {
                    "6. Which one of these is C# program extension?",
                    ".csx",
                    ".csharp",
                    ".obj"
                },
                //Hard level
                {
                    "7. Choose the difference between Struct and Class in C# programming language:",
                    "Struct can't be inherited to other type but Class can",
                    "Structers can be abstract but Classes can't",
                    "Unlikely Classes, Structers are usually used for large amount of data's"
                },
                {
                    "8. What is the result of following expression:\n\nstring nullString = (string) null;\nConsole.WriteLine(nullString is string)\n",
                    "False",
                    "True",
                    "Invalid value exception"
                },
                {
                    "9. What is the result of following expression:\n\nstring x = new string(new char[0]);\nstring y = new string(new char[0]);\nConsole.WriteLine(object.ReferenceEquals(x, y));\n",
                    "True",
                    "False",
                    "NullReferenceException"
                },
                {
                    "10. If you overload a function with parameterless, string and object type arguments\nthen call this function with null parameter which one of them should called?",
                    "string",
                    "int",
                    "parameterless"
                }
            };

        static byte score = 0, quiz_num = 0, c_index = 0, w_index = 0;
        static Random random = new Random();
        static bool[] check = new bool[col-1];
        static byte[] options = new byte[col-1];

        static bool input(char choice){
            if((int) choice == c_index+97) return true;
            w_index = Convert.ToByte(choice - 97);
            return false;
        }
        
        static void display(bool format = false, bool result = false) {
            Console.Clear();
            System.Console.Write("Level: ");
            if(quiz_num > 8) System.Console.WriteLine("4 (FINAL LEVEL)");
            else if(quiz_num > 5) System.Console.WriteLine("3 (Hard)");
            else if(quiz_num > 2) System.Console.WriteLine("2 (Medium)");
            else System.Console.WriteLine("1 (Easy)");
            System.Console.WriteLine(questions[quiz_num,0]);
            for(byte i = 1; i < col; i++) {
                if(format == true) {
                    if(result == true && i == c_index + 1) Console.BackgroundColor = ConsoleColor.Green;
                    if(result == false) {
                        if(i == c_index + 1) Console.BackgroundColor = ConsoleColor.Gray;
                        if(i == w_index + 1) Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                System.Console.WriteLine($"{(char)(96 + i)}) {questions[quiz_num, options[i-1]+1]}");
                Console.ResetColor();
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Score: {score}");
        }

        static void play() {
            for(byte i = 0; i < col-1; i++){
                check[i] = false;
                options[i] = i;
            }

            for(byte i = 0, j = 0; i < options.Length; i++) {
                while(true) {
                    j = Convert.ToByte(random.Next(col-1));
                    if(check[j] == false) {
                        check[j] = true;
                        options[i] = j;
                        if(j == 0) c_index = i;
                        break;
                    }
                }
            }

            display();

            if(input(Console.ReadKey(intercept: true).KeyChar)) {
                score+=10;
                display(true, true);
            }
            else {
                if (score>=10) score-=10;
                display(true, false);
            }

            quiz_num++;

            System.Threading.Thread.Sleep(1400);

        }

        static void Main(string[] args)
        {
            while(quiz_num != row){
                play();
            }
            System.Console.WriteLine($"Quiz finished. Your score is: {score}");
        }

    }
}
