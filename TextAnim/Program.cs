using System;
using System.Collections.Generic;
using System.Linq;

namespace TextAnim
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int color = 4;
            Console.ForegroundColor = (ConsoleColor)color;
            string input = Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(input);
            }
            color++;
            Console.ForegroundColor = (ConsoleColor)color;
            int curPos = 0;
            for (int a = 0; a < 2; a++)
            {
                for (int i = 0; i < 20; i++)
                {
                    //input = " " + input;
                    curPos++;
                    Console.SetCursorPosition(curPos, Console.CursorTop);
                    Console.WriteLine(input);
                }
                color++;
                Console.ForegroundColor = (ConsoleColor)color;
                for (int i = 0; i < 20; i++)
                {
                    //input = input.Remove(0, 1);
                    curPos--;
                    Console.SetCursorPosition(curPos, Console.CursorTop);
                    Console.WriteLine(input);
                }
                color++;
                Console.ForegroundColor = (ConsoleColor)color;
            }
            char[] characters = input.ToCharArray();
            int maxPos = (int)Math.Round(3.75 * characters.Length - 1, MidpointRounding.ToZero);
            int[] pos = new int[characters.Length];
            string temp = string.Empty;
            /*for (int i = 0; i < characters.Length; i++)
            {
                //pos[characters.Length - i - 1] = i;
                temp += characters[i] + "  ";
            }
            List<int> indexesUsed = new List<int>();
            for (int i = 0; i < characters.Length; i++)
            {
                int index = 0;
                bool found = false;
                while (true)
                {
                    int positoin = temp.IndexOf(characters[i], index);
                    if (!indexesUsed.Contains(positoin))
                    {
                        pos[i] = positoin;
                        break;
                    }
                    else
                    {
                        index = positoin + 1;
                    }
                }
            }*/

            for (int i = 0; i < pos.Length; i++)
            {
                pos[i] = i * 3;
            }

            for (int i = 0; i < 7.5 * characters.Length; i++)
            {
                //input = input.Insert(input.Length - 1, " ");
                //string send = string.Empty;
                //for (int a = characters.Length - 1; a > -1; a--)

                for (int a = 0; a < characters.Length; a++)
                {
                    ////send.Insert(i - characters.Length + a * 2 < 0 ? 0 : i - characters.Length + a * 2, " ");
                    ////int spaces = i - characters.Length + (a + 1) * 2 < 0 ? 0 : i - characters.Length + (a + 1) * 2;
                    ////send += String.Concat(Enumerable.Repeat(" ", spaces > maxPos ? maxPos : spaces));
                    ////send += characters[a].ToString();
                    //int spaces = a + 1 * (i + 1) - (characters.Length + a + 1) * 3;
                    //spaces = spaces < 0 ? 0 : spaces;

                    //int spaces = (a + 1) * i;

                    //int spaces = i + a - (int)Math.Round(Math.Pow(characters.Length, 2));
                    //if (a+)
                    //int spaces = a+ (startedMoving[a]? i: 0);
                    //int spaces = characters.Length - a - 1 + (i * a);
                    int spaces = pos[a] - characters.Length + i - characters.Length * 2;
                    if (spaces < a)
                    {
                    }
                    spaces = spaces < a ? a : spaces;
                    if (spaces >= maxPos)
                    {
                    }
                    //spaces = spaces >= maxPos ? a + maxPos - 3 : spaces;

                    spaces = spaces + characters.Length - a - 1 >= maxPos ? maxPos - (characters.Length - a) : spaces;

                    //Console.SetCursorPosition(pos[characters.Length - a - 1], Console.CursorTop);
                    //Console.Write(characters[characters.Length - a - 1].ToString());
                    Console.SetCursorPosition(spaces, Console.CursorTop);
                    Console.Write(characters[a]);
                }
                Console.WriteLine();
                //Console.WriteLine(send);
            }
            //color++;
            //Console.ForegroundColor = (ConsoleColor)color;
            //Console.SetCursorPosition(maxPos - characters.Length, Console.CursorTop);
            //Console.Write(input);

            color++;
            Console.ForegroundColor = (ConsoleColor)color;
            //for (int i = 0; i < 30; i++)
            for (int i = (int)Math.Round(7.5 * characters.Length - 1, MidpointRounding.ToZero); i > -1; i--)
            {
                //input = input.Insert(input.Length - 1, " ");
                //string send = string.Empty;
                //for (int a = characters.Length - 1; a > -1; a--)

                for (int a = 0; a < characters.Length; a++)
                {
                    ////send.Insert(i - characters.Length + a * 2 < 0 ? 0 : i - characters.Length + a * 2, " ");
                    ////int spaces = i - characters.Length + (a + 1) * 2 < 0 ? 0 : i - characters.Length + (a + 1) * 2;
                    ////send += String.Concat(Enumerable.Repeat(" ", spaces > maxPos ? maxPos : spaces));
                    ////send += characters[a].ToString();
                    //int spaces = a + 1 * (i + 1) - (characters.Length + a + 1) * 3;
                    //spaces = spaces < 0 ? 0 : spaces;

                    //int spaces = (a + 1) * i;

                    //int spaces = i + a - (int)Math.Round(Math.Pow(characters.Length, 2));
                    //if (a+)
                    //int spaces = a+ (startedMoving[a]? i: 0);
                    //int spaces = characters.Length - a - 1 + (i * a);
                    int spaces = pos[a] - characters.Length + i - characters.Length * 2;
                    if (spaces < a)
                    {
                    }
                    spaces = spaces < a ? a : spaces;
                    if (spaces >= maxPos)
                    {
                    }
                    //spaces = spaces >= maxPos ? a + maxPos - 3 : spaces;

                    spaces = spaces + characters.Length - a - 1 >= maxPos ? maxPos - (characters.Length - a) : spaces;

                    //Console.SetCursorPosition(pos[characters.Length - a - 1], Console.CursorTop);
                    //Console.Write(characters[characters.Length - a - 1].ToString());
                    Console.SetCursorPosition(spaces, Console.CursorTop);
                    Console.Write(characters[a]);
                }
                Console.WriteLine();
                //Console.WriteLine(send);
            }

            Console.ReadKey(true);
        }
    }
}