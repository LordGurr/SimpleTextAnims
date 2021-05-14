using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextAnim
{
    internal class Program
    {
        private static Random rng = new Random();

        private static void Main(string[] args)
        {
            MyConsole.WriteLine("Hallå ja");
            MyConsole.SetCursorPosition(2, 4);
            MyConsole.WriteLine("Jodå");
            int color = 4;
            //MyConsole.ForegroundColor = (MyConsoleColor)color;
            StringWriter writer = new StringWriter();
            //writer = MyConsole.Out;
            //MyConsole.SetOut(writer);
            string input = Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                MyConsole.WriteLine(input);
            }
            color++;
            //MyConsole.ForegroundColor = (MyConsoleColor)color;
            int curPos = 0;
            for (int a = 0; a < 2; a++)
            {
                //Move to the Right
                for (int i = 0; i < 20; i++)
                {
                    //input = " " + input;
                    curPos++;
                    MyConsole.SetCursorPosition(curPos, MyConsole.CursorTop);
                    MyConsole.WriteLine(input);
                }
                color++;
                //MyConsole.ForegroundColor = (MyConsoleColor)color;
                //Move to the left
                for (int i = 0; i < 20; i++)
                {
                    //input = input.Remove(0, 1);
                    curPos--;
                    MyConsole.SetCursorPosition(curPos, MyConsole.CursorTop);
                    MyConsole.WriteLine(input);
                }
                color++;
                //MyConsole.ForegroundColor = (MyConsoleColor)color;
            }
            char[] characters = input.ToCharArray();
            int maxPos = (int)Math.Round(3.75 * characters.Length - 1, MidpointRounding.ToZero);
            int[] pos = new int[characters.Length];
            //string temp = string.Empty;
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
            // Cha cha to the right
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

                    //MyConsole.SetCursorPosition(pos[characters.Length - a - 1], MyConsole.CursorTop);
                    //MyConsole.Write(characters[characters.Length - a - 1].ToString());
                    MyConsole.SetCursorPosition(spaces, MyConsole.CursorTop);
                    MyConsole.Write(characters[a]);
                }
                MyConsole.WriteLine();
                //MyConsole.WriteLine(send);
            }

            color++;
            //MyConsole.ForegroundColor = (MyConsoleColor)color;
            //for (int i = 0; i < 30; i++)
            // Cha cha to the left
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

                    //MyConsole.SetCursorPosition(pos[characters.Length - a - 1], MyConsole.CursorTop);
                    //MyConsole.Write(characters[characters.Length - a - 1].ToString());
                    MyConsole.SetCursorPosition(spaces, MyConsole.CursorTop);
                    MyConsole.Write(characters[a]);
                }
                MyConsole.WriteLine();
                //MyConsole.WriteLine(send);
            }
            color++;
            //MyConsole.ForegroundColor = (MyConsoleColor)color;
            // Move to the right
            curPos = 0;
            for (int i = 0; i < 15; i++)
            {
                //input = " " + input;
                curPos++;
                MyConsole.SetCursorPosition(curPos, MyConsole.CursorTop);
                MyConsole.WriteLine(input);
            }
            // Wiggle in the middle
            string[] splitted = SplitTheString(input, 3);
            int[] positions = new int[3];
            for (int i = 0; i < positions.Length; i++)
            {
                //positions[i] = curPos + (i == 0 ? 0 : splitted[i].Length - 1);
                positions[i] = curPos;
                //if (i > 0)
                //{
                //    positions[i] += splitted[i - 1].Length;
                //}
                for (int a = 0; a < i; a++)
                {
                    positions[i] += splitted[a].Length;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < splitted.Length; a++)
                {
                    if (a == 0)
                    {
                        positions[a]--;
                    }
                    else if (a == 2)
                    {
                        positions[a]++;
                    }
                    MyConsole.SetCursorPosition(positions[a], MyConsole.CursorTop);
                    MyConsole.Write(splitted[a]);
                }
                MyConsole.WriteLine();
            }
            bool movingLeft = false;
            int original = positions[1];
            for (int i = 0; i < 30; i++)
            {
                if (positions[1] > positions[2] - splitted[1].Length - 4)
                {
                    movingLeft = true;
                }
                else if (positions[1] < positions[0] + splitted[0].Length + 4)
                {
                    movingLeft = false;
                }
                positions[1] += movingLeft ? -1 : 1;
                for (int a = 0; a < splitted.Length; a++)
                {
                    MyConsole.SetCursorPosition(positions[a], MyConsole.CursorTop);
                    MyConsole.Write(splitted[a]);
                }
                MyConsole.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < splitted.Length; a++)
                {
                    if (a == 0)
                    {
                        positions[a]++;
                    }
                    else if (a == 2)
                    {
                        positions[a]--;
                    }
                    else if (a == 1 && positions[a] != original)
                    {
                        if (original < positions[a])
                        {
                            positions[a]--;
                        }
                        else
                        {
                            positions[a]++;
                        }
                    }
                    MyConsole.SetCursorPosition(positions[a], MyConsole.CursorTop);
                    MyConsole.Write(splitted[a]);
                }
                MyConsole.WriteLine();
            }
            // Move to the left
            MyConsole.SetCursorPosition(curPos, MyConsole.CursorTop);
            MyConsole.WriteLine(input);
            for (int i = 0; i < 15; i++)
            {
                //input = " " + input;
                curPos--;
                MyConsole.SetCursorPosition(curPos, MyConsole.CursorTop);
                MyConsole.WriteLine(input);
            }

            // Offsets!
            string offsetted = input;
            int timesToRun = GetNearestMultiple(20, input.Length);
            int offset = 1 * (rng.Next(0, 2) == 0 ? 1 : -1);
            for (int i = 0; i < timesToRun; i++)
            {
                offsetted = Offset(offsetted, offset);
                MyConsole.WriteLine(offsetted);
            }
            color++;
            // Move to the right
            //MyConsole.ForegroundColor = (MyConsoleColor)color;
            for (int i = 0; i < 15; i++)
            {
                //input = " " + input;
                curPos++;
                MyConsole.SetCursorPosition(curPos, MyConsole.CursorTop);
                MyConsole.WriteLine(input);
            }
            // Twist around
            splitted = SplitTheString(input, 2);
            positions = new int[2];
            for (int i = 0; i < positions.Length; i++)
            {
                //positions[i] = curPos + (i == 0 ? 0 : splitted[i].Length - 1);
                positions[i] = curPos;
                //if (i > 0)
                //{
                //    positions[i] += splitted[i - 1].Length;
                //}
                for (int a = 0; a < i; a++)
                {
                    positions[i] += splitted[a].Length;
                }
            }
            movingLeft = true;
            int[] originalPos = new int[positions.Length];
            for (int i = 0; i < originalPos.Length; i++)
            {
                originalPos[i] = positions[i];
            }
            for (int i = 0; i < 50; i++)
            {
                if (positions[0] < 1)
                {
                    movingLeft = false;
                }
                else if (positions[1] < 1)
                {
                    movingLeft = true;
                }
                for (int a = 0; a < splitted.Length; a++)
                {
                    if (a == 0)
                    {
                        positions[a] += movingLeft ? -1 : 1;
                    }
                    else if (a == 1)
                    {
                        positions[a] += movingLeft ? 1 : -1;
                    }
                    MyConsole.SetCursorPosition(positions[a], MyConsole.CursorTop);
                    MyConsole.Write(splitted[a]);
                }
                MyConsole.WriteLine();
            }
            for (int i = 0; i < 30; i++)
            {
                for (int a = 0; a < splitted.Length; a++)
                {
                    if (positions[a] != originalPos[a])
                    {
                        positions[a] += positions[a] < originalPos[a] ? 1 : -1;
                    }
                    MyConsole.SetCursorPosition(positions[a], MyConsole.CursorTop);
                    MyConsole.Write(splitted[a]);
                }
                MyConsole.WriteLine();
            }
            color++;
            //MyConsole.ForegroundColor = (MyConsoleColor)color;
            // Move to the left
            for (int i = 0; i < 15; i++)
            {
                //input = " " + input;
                curPos--;
                MyConsole.SetCursorPosition(curPos, MyConsole.CursorTop);
                MyConsole.WriteLine(input);
            }
            for (int i = 0; i < 15; i++)
            {
                MyConsole.WriteLine(input);
            }
            string temp = writer.ToString();
            Console.WriteLine(MyConsole.GetString());
            Console.ReadKey(true);
        }

        private static string Offset(string str, int offset)
        {
            if (offset > 0)
            {
                string end = str.Substring(str.Length - offset);
                str = str.Remove(str.Length - offset);
                str = str.Insert(0, end);
            }
            else
            {
                offset *= -1;
                string start = str.Substring(0, offset);
                str = str.Remove(0, offset);
                str = str.Insert(str.Length, start);
            }
            return str;
        }

        private static string[] SplitTheString(string input, int parts)
        {
            string[] split = input.Split();
            if (split.Length != parts)
            {
                split = ChunksUpto(input, input.Length / parts).ToArray();
                if (split.Length > parts)
                {
                    string[] temp = new string[parts];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = split[i];
                    }
                    for (int i = parts; i < split.Length; i++)
                    {
                        temp[temp.Length - 1] += split[i];
                    }
                    split = temp;
                }
            }
            else
            {
                for (int i = 0; i < split.Length; i++)
                {
                    split[i] = split[i].Insert(0, " ");
                }
            }
            return split;
        }

        //private static IEnumerable<string> Split(string str, int chunkSize)
        //{
        //    return Enumerable.Range(0, str.Length / chunkSize)
        //        .Select(i => str.Substring(i * chunkSize, chunkSize));
        //}

        private static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
        {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

        private static int GetNearestMultiple(int value, int factor) // use get nearest to
        {
            return (int)Math.Round(
                              (value / (double)factor),
                              MidpointRounding.AwayFromZero
                          ) * factor;
        }

        private static class MyConsole
        {
            private static List<string> everyThing = new List<string>();
            private static int[] position = new int[2];

            public static void WriteLine(string str)
            {
                UpdateCursor();
                if (everyThing[position[1]].Length < str.Length + position[0])
                {
                    everyThing[position[1]] = everyThing[position[1]].PadRight(position[0] + str.Length);
                }
                foreach (char c in str)
                {
                    everyThing[position[1]] = ReplaceAt(everyThing[position[1]], position[0], c);
                    position[0]++;
                }
                position[1]++;
                position[0] = 0;
                UpdateCursor();
            }

            public static void WriteLine()
            {
                UpdateCursor();
                position[1]++;
                position[0] = 0;
                UpdateCursor();
            }

            private static void UpdateCursor()
            {
                if (everyThing.Count < 1)
                {
                    everyThing.Add(new string(""));
                }

                if (position[1] > everyThing.Count - 1)
                {
                    int temp = everyThing.Count - 1;
                    for (int i = temp; i < position[1]; i++)
                    {
                        everyThing.Add(new string(""));
                    }
                }
                if (position[0] > 0 && everyThing[position[1]].Length - 1 < position[0])
                {
                    everyThing[position[1]] = everyThing[position[1]].PadRight(position[0]);
                }
            }

            public static void Write(string str)
            {
                UpdateCursor();
                if (everyThing.Count < 1)
                {
                    everyThing.Add(new string(""));
                }
                if (everyThing[position[1]].Length < str.Length + position[0])
                {
                    everyThing[position[1]] = everyThing[position[1]].PadRight(position[0] + str.Length);
                }
                foreach (char c in str)
                {
                    everyThing[position[1]] = ReplaceAt(everyThing[position[1]], position[0], c);
                    position[0]++;
                }
                UpdateCursor();
            }

            public static void Write(char c)
            {
                UpdateCursor();
                if (everyThing.Count < 1)
                {
                    everyThing.Add(new string(""));
                }
                if (everyThing[position[1]].Length < 1 + position[0])
                {
                    everyThing[position[1]] = everyThing[position[1]].PadRight(position[0] + 1);
                }
                everyThing[position[1]] = ReplaceAt(everyThing[position[1]], position[0], c);
                position[0]++;
                UpdateCursor();
            }

            public static void SetCursorPosition(int x, int y)
            {
                position[0] = x;
                position[1] = y;
                UpdateCursor();
            }

            private static string ReplaceAt(string input, int index, char newChar)
            {
                if (input == null)
                {
                    throw new ArgumentNullException("input");
                }
                char[] chars = input.ToCharArray();
                chars[index] = newChar;
                return new string(chars);
            }

            public static int CursorTop
            {
                get
                {
                    return position[1];
                }
            }

            public static int CursorLeft
            {
                get
                {
                    return position[0];
                }
            }

            public static string GetString()
            {
                string SendString = string.Empty;
                for (int i = 0; i < everyThing.Count; i++)
                {
                    SendString += everyThing[i] + "\n";
                }
                return SendString;
            }
        }
    }
}