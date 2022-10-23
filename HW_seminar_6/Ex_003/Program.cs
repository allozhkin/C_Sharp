// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillMatrix(int[,] matrix, int str, int column)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(-10, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
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
void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0) matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
    }
}
Console.WriteLine("Введите количество строк: ");
int str = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("ВВедите количество столбов: ");
int column = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [str, column];
Console.WriteLine();
FillMatrix(matrix, str, column);
Console.WriteLine("Ваш массив: ");
PrintMatrix(matrix);
Console.WriteLine();
ChangeMatrix(matrix);
Console.WriteLine("Новый массив: ");
PrintMatrix(matrix);

