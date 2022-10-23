// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

void PrintArray(int[,] matr)

{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            Console.Write($"{matr[rows, i]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr, int n, int m)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(0, 10);
    }
}
}
string FindDigit(int[,] matr, int find)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == find) return ($"Строка № {i + 1}, столбец № {j + 1}");
        }
    }
return ("Число не найдено");
}

Console.WriteLine("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();
int[,] matrix = new int [stroka, stolb];
FillArray(matrix, stroka, stolb);
PrintArray(matrix);


Console.WriteLine("ВВедите искомое число от 0 до 10: ");
int digit = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(FindDigit(matrix, digit));