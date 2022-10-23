

// void FillMatrix(int[,] array)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 9);
//         }
//     }
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите колличество строк: ");
// int stroki = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите колличество столбов: ");
// int stolbi = int.Parse(Console.ReadLine() ?? "0");

// int[,] array = new int[stroki, stolbi];
// FillMatrix(array);
// PrintMatrix(array);

string stroka2 = "В наши годы молодые. Было весело гулять, вот бы прежнее веселье на село вернуть опять!";
char[] separator2 = new char[9] { ' ', ',', '!', '.', '-', ';', ':', '—', '-' };//это разделитель с созданием их массива

string[] slova2; //а это соб-но массив слов
slova2 = stroka2.Split(separator2);

foreach (string slovo in slova2)
{
    Console.WriteLine("{0}", slovo);
}

//теперь бы как то подсчитать одинаковые слова. тут наверное надо вспомнить массивы?
int k2 = slova2.Length;
Console.WriteLine("Длина массива  " + k2);

//массив куда эта временная переменная будет помещаться

string[] kolvo2 = new string[k2];
int tempsl2 = 0;
for (int i = 0; i < slova2.Length; i++)
{
    for (int j = 0; j < slova2.Length; j++)
    {
        bool l = string.Equals(slova2[i], slova2[j]);
        if (l == true)
        {
            tempsl2 += 1;
            if (j > i)
                slova2[j] = null;    //обнуляет повторяющиеся слова
        }
    }
    if (slova2[i] != null) //это чтоб не пополнять массив лишними словами
    {
        kolvo2[i] = slova2[i] + ' ' + Convert.ToString(tempsl2);
    }
    tempsl2 = 0;
    slova2[i] = null;
}
foreach (string kol in kolvo2)
    if (kol != null && kol != " ")
        Console.WriteLine(kol);
