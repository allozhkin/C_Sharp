// Написать программу, которая обменивает элементы первой строки и последней строки

void FillMasiv(int[,] massiv)
{
    Random E1 = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = E1.Next(-9, 10);
        }
    }
}
void PrintMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ChangeMasiv(int[,] massiv)
{
    int index = massiv.GetLength(0) - 1;
    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        int temp = massiv[0, i];
        massiv[0, i] = massiv[index, i];
        massiv[index, i] = temp;

    }

}

Console.Write("Введите число строк: ");
int stroki = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число столбцов: ");
int stolb = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[stroki, stolb];

FillMasiv(array);
PrintMassiv(array);
Console.WriteLine();
ChangeMasiv(array);
PrintMassiv(array);