using System;

namespace AoC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\nikki\Documents\School\2021-2022\AoC_2021\Nikki\AoC_Nikki\AoC2\input.txt");
            int uitkomst1 = 0;
            int uitkomst2 = 0;
            int aim = 0;
            string temp = "";
            int verm = 0;


            foreach (var item in input)
            {
                
                if (item.Contains("forward"))
                {
                    temp = item.Substring(item.Length -1);
                    uitkomst1=uitkomst1+Convert.ToInt32(temp);
                    uitkomst2 = uitkomst2 + (Convert.ToInt32(item.Substring(item.Length - 1)) * aim);
                }
                else if (item.Contains("up"))
                {
                    temp = item.Substring(item.Length - 1);
                    //uitkomst2 = uitkomst2 - Convert.ToInt32(temp);
                    aim = aim - Convert.ToInt32(item.Substring(item.Length - 1));
                }
                else if (item.Contains("down"))
                {
                    //uitkomst2 = uitkomst2 + Convert.ToInt32(item.Substring(item.Length - 1));
                    aim = aim + Convert.ToInt32(item.Substring(item.Length - 1));

                }                        
            }
            verm = uitkomst1 * uitkomst2;
            Console.WriteLine("uitkomst 1 = {0}", uitkomst1);
            Console.WriteLine("uitkomst 2 = {0}", uitkomst2);
            Console.WriteLine("Vermenigvuldigt = {0}", verm);
        }
    }
}
