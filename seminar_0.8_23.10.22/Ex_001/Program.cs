

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 9);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


Console.WriteLine("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];
Console.WriteLine();
FillArray(array);
PrintArray(array);

System.Console.WriteLine();


int zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 0)
        zero++;
        
    else if (array[i] == 1)
        one++;
    else if (array[i] == 2)
        two++;
    else if (array[i] == 3)
        three++;
    else if (array[i] == 4)
        four++;
    else if (array[i] == 5)
        five++;
    else if (array[i] == 6)
        six++;
    else if (array[i] == 7)
        seven++;
    else if (array[i] == 8)
        eight++;
    else if (array[i] == 9)
        nine++;
}
Console.WriteLine($"0 встречается {zero} раз");
Console.WriteLine($"1 встречается {one} раз");
Console.WriteLine($"2 встречается {two} раз");
Console.WriteLine($"3 встречается {three} раз");
Console.WriteLine($"4 встречается {four} раз");
Console.WriteLine($"5 встречается {five} раз");
Console.WriteLine($"6 встречается {six} раз");
Console.WriteLine($"7 встречается {seven} раз");
Console.WriteLine($"8 встречается {eight} раз");
Console.WriteLine($"9 встречается {nine} раз");