// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число!");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Вы ввели - " + numA);


Console.WriteLine("Введите второе число!");
int numB = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Вы ввели - " + numB);

if (numB == numA * numA)
{
    Console.WriteLine("Число " + numB + " является квадратом числа " + numA);
}
else if (numA == numB * numB)
{
    Console.WriteLine("Число " + numA + " является квадратом числа " + numB);
}
else
{
    Console.WriteLine("Ваши числа не являются квадратами");
}