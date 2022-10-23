// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillnumZ(int[] coll)
{
    int n = coll.Length;
    int index = 0;
    Random ruk = new Random();
    while (index < n)
    {
        coll[index] = ruk.Next(0, 2);
        index++;
    }
}
void PrintNumz(int[] collit)
{
    int count = collit.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {collit[position]}");
        position++;
    }
}
int[] numz = new int[8];
FillnumZ(numz);
PrintNumz(numz);
Console.WriteLine();