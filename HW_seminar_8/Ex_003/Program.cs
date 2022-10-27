// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int[,,] array)
{
    Random random = new Random();
    int number = 10;
    int num = -100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(10, 99);
                if (number >= 99 && num < -9)
                {
                    array[i, j, k] = num++;
                }
                if (number >= 10 && number < 100)
                {
                    array[i, j, k] = number++;
                }

            }


}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");

            }
            Console.WriteLine();
        }

    }
}
System.Console.WriteLine("Введите число: ");
int digit1 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите число: ");
int digit2 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("ВВедите число: ");
int digit3 = int.Parse(Console.ReadLine() ?? "0");
int[,,] Array = new int[digit1, digit2, digit3];
FillArray(Array);
PrintArray(Array);