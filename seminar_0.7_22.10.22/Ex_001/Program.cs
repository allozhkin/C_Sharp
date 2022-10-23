// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
void FillMasiv(int[,] massiv)
{
    Random E1 = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = E1.Next(0, 10);
        }
    }
}
void PrintMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]}  ");
        }
    Console.WriteLine();
    }
}
int DiagSum(int[,] massiv)
{
    int sum = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sum += massiv[i, i];
    }
    return sum;
}

Console.Write("Введите число строк: ");
int stroki = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число столбцов: ");
int stolb = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[stroki, stolb];

FillMasiv(array);
PrintMassiv(array);
DiagSum(array);
Console.WriteLine($"Сумма главной диагонали ровна: {DiagSum(array)}");