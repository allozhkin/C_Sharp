//  Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillMatrix(int[,] matrix, int str, int column)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
    
}
Console.WriteLine("Введите количество строк: ");
int str = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбов: ");
int column = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [str, column];

FillMatrix(matrix, str, column);
PrintMatrix(matrix);
Console.WriteLine();
