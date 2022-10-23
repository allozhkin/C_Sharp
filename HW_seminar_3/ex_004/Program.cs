// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число!");
int num = int.Parse(Console.ReadLine() ?? "0");

int index = 1;

while ( index <= num)
{
    int count = index * index * index;
    if (count % 2 == 0)
    {
        Console.WriteLine("index: " + index + " equals " + count + " - even");
    }
    index++;
}