// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = number % 10;
Console.WriteLine("Последнее цифра числа " + number + " это: " + sum);