// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = number % 100;
int sum1 = sum / 10;
Console.WriteLine(sum1);