// Показать числа Фибоначчи меньшие чем заданное число N

Console.WriteLine("Введите число: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int fibo1 = 0;
int fibo2 = 1;
int fibo3 = 1;

while (fibo3 <= chislo)
{
    Console.Write($"{fibo3} ");
    fibo3 = fibo1 + fibo2;
    fibo1 = fibo2;
    fibo2 = fibo3; 
}
