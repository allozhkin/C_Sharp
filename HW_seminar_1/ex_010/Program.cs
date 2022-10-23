//Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int first = number / 100;
int second = number % 10;
Console.Write(first);

Console.Write(second);