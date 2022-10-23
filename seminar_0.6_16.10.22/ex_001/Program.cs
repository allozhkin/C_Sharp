// Показать двумерный массив размером m×n заполненный целыми числами



void PrintArray(int[,] matr)

{
    for (int rows = 0; rows < 3; rows++)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{matr[rows, i]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr, int m, int n)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(1, 10);
    }
}
}

Console.WriteLine("Введите число: ");
int mM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число: ");
int nM = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [mM, nM];
FillArray(matrix, mM, nM);
Console.WriteLine();
PrintArray(matrix);