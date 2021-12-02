using System;

namespace AoC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\nikki\Documents\School\2021-2022\AoC_2021\Nikki\AoC_Nikki\AoC1\input.txt"); 
            int uitkomst = 0;
            int uitkomst2=0;
            int a = 0;  
            int temp = 0;
            int temp2 = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int[] array2 = new int[5000];
            int janken = 0;

            for (int i = 0; i < input.Length; i++)
            {
                a = Convert.ToInt32(input[i]);
                if (a > temp)
                {
                    uitkomst++;
                }
                temp = a;

                if (i == 0)
                {
                    e = Convert.ToInt32(input[i]);
                    array2[janken] = e;
                    janken++;
                } else if (i == 1)
                {
                    b = Convert.ToInt32(input[i]);
                    c = Convert.ToInt32(input[i+1]);
                    e = b + c;
                    array2[janken] = e;
                    janken++;
                } else if (i<input.Length-2)
                {
                    b = Convert.ToInt32(input[i]);
                    c = Convert.ToInt32(input[i+1]);
                    d = Convert.ToInt32(input[i+2]);
                    e = b + c + d;
                    array2[janken] = e;
                    janken++;
                } else if (i < input.Length - 1)
                {
                    b = Convert.ToInt32(input[i]);
                    c = Convert.ToInt32(input[i + 1]);
                    e = b + c;
                    array2[janken] = e;
                    janken++;
                } else if(i<input.Length)
                {
                    e = Convert.ToInt32(input[i]);
                    array2[janken] = e;
                    janken++;
                }
            }
            uitkomst--;
            Console.WriteLine("deel 1 = {0}", uitkomst);

            for (int i = 0; i < array2.Length; i++)
            {
                a = Convert.ToInt32(array2[i]);
                if (a > temp2)
                {
                    uitkomst2++;
                }
                temp2 = a;
            }
            uitkomst2--;
            Console.WriteLine("deel 2 = {0}", uitkomst2);


        }
    }
}
