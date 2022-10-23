//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99: ");
int digit = int.Parse(Console.ReadLine() ?? "0");

int digitA = digit / 10;
int digitB = digit % 10;

if (digitA > digitB) 
{
    Console.WriteLine("Наибольшее число из " + digit + " это - " + digitA);
    Console.WriteLine("Наименьшее число из " + digit + " это - " + digitB);
}
else
{
    Console.WriteLine("Наибольшее число из " + digit + " это - " + digitB);
    Console.WriteLine("Наименьшее число из " + digit + " это - " + digitA);
}