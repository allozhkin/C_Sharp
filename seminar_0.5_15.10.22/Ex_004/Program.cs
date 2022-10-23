// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите Число: ");
int number = int.Parse(Console.ReadLine() ??"0");
string result = string.Empty;
string output = string.Empty;

while (number != 0)
{
    result = result + number % 2;
    number = number /2;
}

for (int i = result.Length - 1; i >= 0; i--)
{
    output += result[i];
}
Console.WriteLine(output);