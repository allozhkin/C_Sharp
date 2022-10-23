// Показать двумерный массив размером m×n заполненный вещественными числами
void FillMatrix(double[,] matrix, int str, int column)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.NextDouble();
        }
    }
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int str = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("ВВедите количество столбов: ");
int column = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double [str, column];
Console.WriteLine();
Console.WriteLine($"Двумерный массив размером {str} x {column} заполненный вещественными числами: ");
FillMatrix(matrix, str, column);
PrintMatrix(matrix);