//  В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillMatrix(int[,] massiv)
{
    Random random = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = random.Next(-10, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] GetNumsMinRawColumn(int[,] array) 
{
    int[] numbers = new int[2];
    int minNumber = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                numbers[0] = i;
                numbers[1] = j;
            }
        }
    }
    return numbers;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+1);
    }
}
int[,] RemoteRawColumn(int[,] matrix, int[] array)
{
    int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)]; // удаляем строку из исходного массива
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i < array[0]) matrix2[i, j] = matrix[i, j];
            else matrix2[i, j] = matrix[i + 1, j];
        }
    }
    int[,] resultMatrix = new int[matrix2.GetLength(0), matrix2.GetLength(1) - 1]; // удаляем столбец из массива с удаленной строкой
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                if (j < array[1]) resultMatrix[i, j] = matrix2[i, j];
                else resultMatrix[i, j] = matrix2[i, j + 1];
            }
        }
    }
    return resultMatrix;
}


Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбов: ");
int col = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = new int[row, col];
FillMatrix(array);
PrintMatrix(array);
int[] minPosition = GetNumsMinRawColumn(array);
Console.WriteLine();
Console.Write("Позиция минимального числа: ");
PrintArray(minPosition);
Console.WriteLine();
int[,] newMatrix = RemoteRawColumn(array, minPosition);
Console.WriteLine("Матрица без строки и столбца, на пересечении которых расположен наименьший элемент: ");
PrintMatrix(newMatrix);
