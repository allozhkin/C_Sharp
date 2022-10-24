// 2. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

void FillMatrix(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0, 9);
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}
int[,] ChangeMatrix (int[,] array)
{
    int[,] newArray = new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i,j] = array[j,i];
        }
    }
    return newArray;
}
Console.WriteLine("Введити колличество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] array = new int [row, column];
int[,] changedArray = new int [row, column];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
if (row == column)
{
    changedArray = ChangeMatrix(array);
    Console.WriteLine($"Замена строк на столбцы:");
    PrintMatrix(changedArray);
}
else Console.WriteLine("Матрица не квадратная");