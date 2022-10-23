Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number1 = (number) * (-1);

while (number1 <= number)
{
    int x = number1++;
    Console.Write(x);
}
