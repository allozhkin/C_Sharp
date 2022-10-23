// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число!");
int num = int.Parse(Console.ReadLine() ?? "0");

int index = 1;

while ( index <= num)
{
    int count = index * index * index;
    Console.WriteLine(index + " ^ 3= " + count);
    index++;
}