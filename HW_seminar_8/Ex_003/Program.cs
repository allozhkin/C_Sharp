// 3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillMatrix(int[,,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = random.Next(10, 99);
            }
        }
    }
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}
void ChangeValue(int[,,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == matrix[i, j, k])
                {
                    matrix[i, j, k] = new Random().Next(10, 99);
                }
            }
        }
    }
}

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число: ");
int num3 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,,] array = new int[num1, num2, num3];
FillMatrix(array);
PrintMatrix(array);
ChangeValue(array);
Console.WriteLine();
PrintMatrix(array);