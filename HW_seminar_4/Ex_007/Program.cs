// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void Printmassive(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
double [] massive = {1.576, 4.677, 2.23, 9.3, 1.10, 3.5, 10.01};
Printmassive(massive);
double MiN = massive[0];
double MaX = massive[0];

for (int index = 0; index < massive.Length; index++)
{
    if (massive[index] > MaX) MaX = massive[index];
    else if (massive[index] <= MiN) MiN = massive[index];
}
Console.WriteLine();
Console.WriteLine($"Разниуа между {MaX} и {MiN} равна {MaX - MiN}");