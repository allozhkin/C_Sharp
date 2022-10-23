// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number = 44;
int count = 1;
while (count < number)
{
    number = number % 10;
    count++;
}
Console.Write(count);