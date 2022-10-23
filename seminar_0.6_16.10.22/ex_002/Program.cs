// В двумерном массиве n×k заменить четные элементы на противоположные\

void PrintArray(int[,] matr)

{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            Console.Write($"{matr[rows, i]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr, int n, int m)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(-10, 10);
    }
}
}

void ChangArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] % 2 == 0) matr[i,j] = -matr[i,j];
        }
    }
}
Console.WriteLine("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [stroka, stolb];
FillArray(matrix, stroka, stolb);

PrintArray(matrix);
Console.WriteLine();
ChangArray(matrix);
PrintArray(matrix);