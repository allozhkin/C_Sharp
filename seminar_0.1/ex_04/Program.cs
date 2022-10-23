// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());


if (number % 7 == 0 && number % 23 == 0)

    Console.WriteLine("Число кратно 7 и 23!");

else 

    Console.WriteLine("Число не кратно 7 и 23!");
