using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\nikki\Documents\School\2021-2022\AoC_2021\Nikki\AoC_Nikki\AoC3\input.txt");
            string[] input2 = System.IO.File.ReadAllLines(@"C:\Users\nikki\Documents\School\2021-2022\AoC_2021\Nikki\AoC_Nikki\AoC3\input.txt");
            int temp = 0;
            int temp2 = 0;
            string gamma = "";
            string epsylon = "";
            int positie = 0;
            int meestvoorkomend = 0;
            string bullshit = "";
            int haaaa = 0;
            int aaaaah = 0;


            #region gamma/epsylon
            for (int i = 0; i < 5; i++)
            {
                temp = WelkeKomtVakerVoor(input, i);
                if (temp == 1)
                {
                    temp2 = 1;
                    gamma = gamma + "1";
                    epsylon = epsylon + "0";
                }
                else
                {
                    temp2 = 0;
                    gamma = gamma + "0";
                    epsylon = epsylon + "1";
                }
            }

            Console.WriteLine("gamma is:" + gamma);
            Console.WriteLine("epsylon is:" + epsylon);
            #endregion



            for (int i = 0; i < 12; i++)
            {
                temp = 0;
                positie = i;
                meestvoorkomend = WelkeKomtVakerVoor(input, i);
                bullshit = Convert.ToString(meestvoorkomend);
                for (int a = 0; a < input.Length; a++)
                {
                    if (input.Count() > 1)
                    {
                        input = input.Where(c => c.Substring(i, 1).Contains(bullshit)).ToArray();
                    }
                }
                meestvoorkomend = WelkeKomtVakerVoor2(input2, i);
                bullshit = Convert.ToString(meestvoorkomend);
                for (int a = 0; a < input2.Length; a++)
                {
                    if (input2.Count() > 1)
                    {

                        input2 = input2.Where(c => c.Substring(i, 1).Contains(bullshit)).ToArray();

                    }

                    Console.WriteLine("input1: " + string.Join(", ", input));
                    Console.WriteLine("input2: " + string.Join(", ", input2));
                    Console.WriteLine("----------------------");

                }
            }

            printArray(input);
            Console.WriteLine("--------------------");
            printArray(input2);

            Console.WriteLine("--------------------");


            aaaaah = binaryToDecimal(input[0]);
            Console.WriteLine(" input 1 {0} ---------------------", aaaaah);
            haaaa = binaryToDecimal(input2[0]);
            Console.WriteLine(" input 2 {0} ---------------------", haaaa);

            Console.WriteLine("vermenigvuldigt: {0}", aaaaah * haaaa);

            static int binaryToDecimal(String n)
            {
                String num = n;
                int dec_value = 0;

                // Initializing base value to 1,
                // i.e 2^0
                int base1 = 1;

                int len = num.Length;
                for (int i = len - 1; i >= 0; i--)
                {
                    if (num[i] == '1')
                        dec_value += base1;
                    base1 = base1 * 2;
                }

                return dec_value;
            }

            static int WelkeKomtVakerVoor(string[] input, int lijnnummer)
            {
                int antwoord = 0;
                int temp = 0;
                int een = 0;
                int nul = 0;
                foreach (var item in input)
                {
                    if (item != null)
                    {
                        temp = Convert.ToInt32(item.Substring(lijnnummer, 1));
                        if (temp == 0) { nul++; }
                        else if (temp == 1) { een++; }
                    }
                }
                if (nul > een)
                {
                    antwoord = 1;
                }
                else if (nul < een)
                {
                    antwoord = 0;
                }
                else
                {
                    antwoord = 0;
                }
                return antwoord;
            }
            static int WelkeKomtVakerVoor2(string[] input, int lijnnummer)
            {
                int antwoord = 0;
                int temp = 0;
                int een = 0;
                int nul = 0;
                foreach (var item in input)
                {
                    if (item != null)
                    {
                        temp = Convert.ToInt32(item.Substring(lijnnummer, 1));
                        if (temp == 0) { nul++; }
                        else if (temp == 1) { een++; }
                    }
                }
                if (nul > een)
                {
                    antwoord = 0;
                }
                else if (nul < een)
                {
                    antwoord = 1;
                }
                else
                {
                    antwoord = 1;
                }
                return antwoord;
            }
            static void printArray(string[] input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != null)
                    {
                        Console.WriteLine(input[i]);
                    }
                }
            }
        }
    }
}


