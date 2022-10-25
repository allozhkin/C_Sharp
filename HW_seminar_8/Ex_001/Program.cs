// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Fillmassiv(int[,] massiv)
{
    Random random = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = random.Next(0, 9);
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
void ReorderMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(1); k++)
            {
                if (massiv[i, j] >= massiv[i,k])
                {
                    int temporary = massiv[i, j];
                    massiv[i, j] = massiv[i, k];
                    massiv[i, k] = temporary;
                }
            }
        }

    }
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] massiv = new int[row, column];
Fillmassiv(massiv);
PrintMassiv(massiv);
Console.WriteLine();

ReorderMassiv(massiv);
Console.WriteLine("Упорядоченные по убыванию элементы каждой строки двумерного массива: ");
PrintMassiv(massiv);
