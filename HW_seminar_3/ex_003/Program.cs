// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число!");
int num = int.Parse(Console.ReadLine() ?? "0");

int index = 1;
int res = 0;

while(index <= num)
{
    res = index * index;
    Console.WriteLine(index + "*" + index + "=" + res);
    index++;
}