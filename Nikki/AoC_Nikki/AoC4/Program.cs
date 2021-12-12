using System;
using System.Linq;

namespace AoC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nikki\Documents\School\2021-2022\AoC_2021\Nikki\AoC_Nikki\AoC4\input.txt";
            string[] input = System.IO.File.ReadAllLines(path);
            string[] filteredInput = System.IO.File.ReadAllLines(path);
            string[] ballen = input[0].Split(',');
            string[,,] kaarten = new string[3, 5, 5];
            string[] tempArr = new string[5];
            int[] voortgang = new int[15];
            int aantalNummers = 0;
            int lijnNummer = 0;
            int temp = 0;
            printArray(ballen, 1);

            #region array aanmaken
            filteredInput = input.Where(val => val != "").ToArray();
            filteredInput = filteredInput.Where(val => val != input[0]).ToArray();
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    tempArr = filteredInput[lijnNummer].Split(' ');
                    tempArr = tempArr.Where(val => val != "").ToArray();
                    printArray(tempArr, 2);
                    for (int b = 0; b < 5; b++)
                    {
                        kaarten[i, a, b] = tempArr[b];
                    }
                    
                    lijnNummer++;
                }
                Console.WriteLine("---------------");
            }
            Console.WriteLine(lijnNummer);
            #endregion

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    
                    for (int b = 0; b < 5; b++)
                    {
                        if (kaarten[i, a, b].Contains(ballen[i]))
                        {
                            if (aantalNummers == 5)
                            {
                                voortgang[lijnNummer] = i;
                            }
                            else
                            {
                                aantalNummers++;
                            }
                        }
                    }

                    lijnNummer++;
                    aantalNummers = 0;
                }
                Console.WriteLine("---------------");
            }

            //foreach (var item in kaarten)
            //{
            //    aantalNummers = 0;
            //    for (int i = 0; i < ballen.Length; i++)
            //    {
            //        if (item.Contains(ballen[i]))
            //        {
            //            if(aantalNummers == 5)
            //            {
            //                voortgang[temp] = i;
            //            } else
            //            {
            //                aantalNummers++;
            //            }
            //        }
            //    }
            //    temp++;
            //}
            Console.WriteLine("voortgang: " + string.Join(", ", voortgang));

            static void printArray(string[] input, int amount)
            {
               Console.WriteLine("input"+amount+": " + string.Join(", ", input));
            }

        }
    }
}
