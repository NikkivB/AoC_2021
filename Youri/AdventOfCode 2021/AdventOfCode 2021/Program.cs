using System;
using System.IO;
using System.Reflection;
using AdventOfCode_2021;

namespace AdventOfCode_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldNumber = 0;
            int newNumber = 0;
            int counter = 0;
            int diffCount = -1;
            foreach (string line in System.IO.File.ReadLines("C:\\Users\\Youri School\\Desktop\\AdventOfCode\\AoC_2021\\Youri\\AdventOfCode 2021\\AdventOfCode 2021\\opdracht1\\input1.txt"))
            {
                int intLine = Convert.ToInt32(line);
                oldNumber = newNumber;
                newNumber = intLine;

                if (newNumber >= oldNumber)
                {
                    diffCount++;
                    System.Console.WriteLine(line + " higher");
                }
                else
                {
                    System.Console.WriteLine(line + " lower");
                }

                counter++;
            }
            Console.WriteLine(diffCount);
        }
    }
}
