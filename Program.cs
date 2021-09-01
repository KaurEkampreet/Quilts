using System;
using System.Linq;

namespace sellquilts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What size quilt would you like?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sure!Coming right up..");

            int totalLength = 18 * num + (num - 1);
            for (int i = 1; i <= num; i++)
            {
                Console.Write("#");
                for (int z = 1; z <= 16; z++)
                    Console.Write("=");
                Console.Write("#");
            }

            Console.WriteLine("");
            string second = "|";
            for (int i = 1; i <= 2 * num; i++)
                second += "<>";
            second += "|";
            Console.WriteLine(CenterString(second, totalLength));
            for (int i = 4; i <= 12; i = 4)
            {
                string print = "|<>";
                for (int j = 1; j <= num * i; j++)
                    print += ".";
                print += "<> |";
                Console.WriteLine(CenterString(print, totalLength));

                for (int e = 12; e >= 4; e -= 4)
                {
                    string print1 = "| <>";
                    for (int j = 1; j <= num * i; j++)
                        print1 += ".";
                    print1 += "<>|";
                    Console.WriteLine(CenterString(print1, totalLength));
                }
                Console.WriteLine(CenterString(second, totalLength));
                for (int n = 1; n <= num; n++)
                {
                    Console.Write("#");
                    for (int j = 1; j <= 16; j++)
                    {
                        Console.Write("=");
                        Console.Write("#");
                        Console.WriteLine();
                    }
                }

            }
        }

        private static bool CenterString(string stringToCenter, int totalLength)
        {
            return stringToCenter.PadLeft(((totalLength - stringToCenter.Length) / 2)
                + stringToCenter.Length);
        }
    }
}
    

