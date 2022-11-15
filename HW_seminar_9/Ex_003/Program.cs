// Написать программу вычисления функции Аккермана
int Ackermann(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Ackermann(M - 1, 1);
    if (M > 0 && N > 0) return Ackermann(M - 1, Ackermann(M, N - 1));
    return Ackermann(M, N);
}
Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");
int result = Ackermann(first, second);
Console.WriteLine($"Функция Аккермана для чисел {first},{second} = {result}");