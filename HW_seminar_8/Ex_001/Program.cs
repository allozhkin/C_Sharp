// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void FillMatrix(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(0,9);
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            product[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return product;
}
Console.WriteLine("Введите количество строк: ");
int row =int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix1 = new int [row, col];
int[,] matrix2 = new int [row, col];
FillMatrix(matrix1);
FillMatrix(matrix2);

PrintMatrix(matrix1);
System.Console.WriteLine("---");
PrintMatrix(matrix2);
System.Console.WriteLine("---");

int[,] multy = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(multy);