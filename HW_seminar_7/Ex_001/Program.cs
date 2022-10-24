// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void FillMatrix(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] >= array[i, k])
                {
                    int temporary = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
    }

}
Console.WriteLine("Введите колличество строк: ");
int stroki = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите колличество столбов: ");
int stolb = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[stroki, stolb];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
SelectionSort(array);
PrintMatrix(array);
