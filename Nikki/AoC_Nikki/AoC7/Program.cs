// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//16,1,2,0,4,2,7,1,2,14

string input =  "16,1,2,0,4,2,7,1,2,14";
Console.WriteLine(input);
string[] arr1 = input.Split(',');
int fuel = 0;
int a = 0;
int b = 0;
int horizontal = 0;
int[] totalFuel = new int[16];

for (int c = 0; c < 16; c++)
{
    fuel = 0;
    horizontal = c;
    for (int i = 0; i < arr1.Length - 1; i++)
    {
        a = Convert.ToInt32(arr1[i]);
        b = horizontal;
        if (a > b)
        {
            fuel = fuel + a - b;
        }
        else if (a < b)
        {
            fuel = fuel + b - a;
        }
    }
    totalFuel[c] = fuel;
    Console.WriteLine(fuel);
}
