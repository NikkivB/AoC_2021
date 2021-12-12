string input = "3,4,3,1,2";
string[] arr1 = input.Split(',');
int temp = 0;
int arrSize = 0;
int hoeveelVisjes = 0;

Console.WriteLine("Hoe de fuck veel dagen wil je dit doen?");
int hoeveelDagen = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < hoeveelDagen; i++)
{
    temp = Convert.ToInt32(arr1[i]);
    if (temp == 0)
    {
        arr1[i] = "6";
        Array.Resize(ref arr1, arr1.Length + 1);
        arrSize = arr1.Length;
        arr1[arrSize] = "8";
    } else
    {
        temp--;
        arr1[i] = temp.ToString();
    }

}
hoeveelVisjes = arr1.Length;
Console.WriteLine("er zijn " + hoeveelVisjes + " visjes na " + hoeveelDagen);
