using System;
using System.Threading;
using System.Threading.Tasks;

namespace SethRudesill.IntegerPackerDemo
{
    class Program
    {
        private static readonly string Prompt1 = $"Left integer between 1 and {UInt16.MaxValue}: ";
        private static readonly string Prompt2 = $"Right integer between 1 and {UInt16.MaxValue}: ";
        private static readonly string Prompt3 = "Try again? Y/N: ";
        private static volatile string Input;
        private static UInt16 Left;
        private static UInt16 Right;
        private static UInt32 Result;

        static Program()
        {
            Console.Title = "Integer Packer Demo";
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write(Prompt1);
                Input = Console.ReadLine();
                if (UInt16.TryParse(Input, out Left))
                {
                    Console.WriteLine();
                    Console.Write(Prompt2);
                    Input = Console.ReadLine();
                    if (UInt16.TryParse(Input, out Right))
                    {
                        Console.WriteLine();
                        Result = (UInt32) Left << 16 | Right;
                        var resultLeft = Result >> 16;
                        var resultRight = Result & ((1 << 16) - 1);

                        Console.WriteLine("The result is {0} ({1} | {2})", Result, resultLeft, resultRight);
                        
                        Console.Write(Prompt3);
                        if (Console.ReadKey().Key.Equals(ConsoleKey.Y) == false)
                            break;
                    }
                }
            } while (true);
        }
    }
}