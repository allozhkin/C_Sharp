// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите числo: ");
int number = int.Parse(Console.ReadLine() ?? "0");
string str = number.ToString();
int n = str.Length;
if (n < 3)
{
    Console.Write("Числа нет");
}
else 
{
Console.WriteLine(str[2]);
}