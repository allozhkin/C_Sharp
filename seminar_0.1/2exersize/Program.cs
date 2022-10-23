Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
    Console.WriteLine("Max=" + max);
    Console.WriteLine("Min=" + min);
}
if (numberA < numberB)
{
    max = numberB;
    min = numberA;
    Console.WriteLine("Max=" + max);
    Console.WriteLine("Min=" + min);
}
if (numberA == numberB)
{
    Console.Write("Числа равны!");
}