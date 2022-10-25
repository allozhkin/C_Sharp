// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillMatrix(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 9);
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[] SumRow(int[,] array)
{
    double[] result = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        result[i] = summ;
    }
    return result;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Строка {i + 1}, сумма = {array[i]} ");
    }
}
int MinRow(double[] array)
{
    int row = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] < min)
        {
            min = array[i];
            row = i;
        }
        
    }
    return row;
}
Console.WriteLine("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[rows, columns];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
double[] result = SumRow(matrix);
PrintArray(result);
double min = MinRow(result) + 1;
Console.Write($"Строка с наименьшей суммой элементов: {min}");
