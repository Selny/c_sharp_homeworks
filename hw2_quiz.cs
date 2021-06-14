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
                    "8. What is the result of following expression:\nstring nullString = (string) null;\nConsole.WriteLine(nullString is string)",
                    "False",
                    "True",
                    "Invalid value exception"
                },
                {
                    "9. What is the result of following expression:\nstring x = new string(new char[0]);\nstring y = new string(new char[0]);\nConsole.WriteLine(object.ReferenceEquals(x, y));",
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

        static byte quiz_num = 0;
        static byte c_index = 0;
        static Random random = new Random();
        static bool[] check = new bool[col-1];
        static byte[] options = new byte[col-1];
        static bool input(char choice){
            //byte i = 0, j = 0;
            //System.Console.WriteLine(questions[i,j]);
            if((int) choice == c_index+97) return true;
            else return false;
        }
        
        static void display(bool format = false) {
            Console.Clear();
            System.Console.WriteLine(questions[quiz_num,0]);
            for(byte i = 1; i < col; i++) {
                if(format == true && i == c_index) Console.BackgroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine($"{(char)(96 + i)}) {questions[quiz_num, options[i-1]+1]}");
                Console.ResetColor();
            }
        }

        static void generate() {
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

            if(input(Console.ReadKey(intercept: true).KeyChar) || true) {
                display(true);
                System.Threading.Thread.Sleep(1200);
            }

        }

        static void result() {
            
        }

        static void Main(string[] args)
        { 
            while(true){
                generate();
            }
        }

    }
}
