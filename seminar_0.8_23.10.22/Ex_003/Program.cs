
char[] Dictionary(string str)
{
    str = str.ToLower();
    int count = 1;
    for (int i = 1; i < str.Length; i++)
    {
        for (int j = 0; j < i+1; j++)
        {
            if (str[i] == str[j])
            {
                break;
            }
            else if (j == i-1)
            {
                count += 1;
            }
        }
    }

    char[] dictionary = new char[count];
    int k = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < dictionary.Length; j++)
        {
            if (str[i] == dictionary[j])
            {
                break;
            }
            else if (j == dictionary.Length-1)
            {
                dictionary[k] = str[i];
                k += 1;
            }
        }
    }
    return dictionary;
}

int[] CountNumbers(string str, char[] dictionary)
{
    str = str.ToLower();
    int[] allcount = new int[dictionary.Length];
    int count = 0;
    for (int i = 0; i < dictionary.Length; i++)
    {
        for (int j = 0; j < str.Length; j++)
        {
            if (dictionary[i] == str[j])
            {
                count += 1;
            }
        }
        allcount[i] = count;
        count = 0;
    }
    return allcount;
}

double[] Percentage(int[] count)
{
    double[] percent = new double[count.Length];
    double totalcount = 0;
    for (int i = 0; i < count.Length; i++)
    {
        totalcount += count[i];
    }
    for (int i = 0; i < percent.Length; i++)
    {
        percent[i] = count[i] / totalcount * 100;
    }
    return percent;
}
Console.WriteLine("Введите текст: ");

string? text = Console.ReadLine() ?? "0";

Console.WriteLine(text);

char[] symbols = Dictionary(text);
int[] count = CountNumbers(text, symbols);
double[] percent = Percentage(count);

for (int i = 0; i < symbols.Length; i++)
{
    if (symbols[i] == ' ')
    {
        Console.WriteLine($"Пробел встречается {count[i]} раз. {Math.Round(percent[i], 3)}%");
    }
    else
    {
        Console.WriteLine($"Символ {symbols[i]} встречается {count[i]} раз. {Math.Round(percent[i], 3)}%");
    }
}


