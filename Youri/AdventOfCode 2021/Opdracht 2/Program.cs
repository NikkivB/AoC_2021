using System;
using System.IO;
using System.Linq;
using System.Reflection;
using AdventOfCode_2021;

namespace AdventOfCode_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrVal = 0;
            int hCount = 0;
            int sumCount = 0;
            int sum1 = 0;
            int sum2 = 0;
            var textLines = File.ReadAllLines("C:\\Users\\Youri School\\Desktop\\AdventOfCode\\AoC_2021\\Youri\\AdventOfCode 2021\\AdventOfCode 2021\\opdracht1\\input1.txt");
            int arrTracker = textLines.Count();

            while (arrTracker >= 6)
            {
                sum1 = Convert.ToInt32(textLines[arrVal]) + Convert.ToInt32(textLines[arrVal + 1]) + Convert.ToInt32(textLines[arrVal + 2]);
                sum2 = Convert.ToInt32(textLines[arrVal + 3]) + Convert.ToInt32(textLines[arrVal + 4]) + Convert.ToInt32(textLines[arrVal + 5]);
                if (sum1 > sum2)
                {
                    hCount++;
                    Console.WriteLine(hCount);
                }
                sum1 = sum2;
                sum2 = 0;
                arrTracker = arrTracker - 3;
                arrVal = arrVal + 3;
            }



        }
    }
}

