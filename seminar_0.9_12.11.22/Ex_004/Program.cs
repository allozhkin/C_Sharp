// Написать программу возведения числа А в целую стень B

int Stepen(int num1, int num2)
{
    if (num2 > 1)
    num1 *= Stepen(num1, num2 - 1);
    return num1;
}

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("ВВедите степень числа: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write($"{number1} ^ {number2} = {Stepen(number1, number2)}");