// Выяснить являются ли три числа сторонами треугольника

Console.WriteLine("Введите первое число: ");
int chislo1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int chislo2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите третье число: ");
int chislo3 = int.Parse(Console.ReadLine() ?? "0");

if (chislo1 + chislo2 > chislo3 && chislo1 + chislo3 > chislo2 && chislo2 + chislo3 > chislo1) Console.WriteLine("triangle");
else Console.WriteLine("not triangle");