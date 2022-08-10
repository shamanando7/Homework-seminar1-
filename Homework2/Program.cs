// Найти максимальное из трех чисел.

Console.WriteLine("Введите первое число");
string? NumberString1 = Console.ReadLine();
int number1 = int.Parse(NumberString1!);

Console.WriteLine("Введите второе число");
string? NumberString2 = Console.ReadLine();
int number2 = int.Parse(NumberString2!);

Console.WriteLine("Введите третье число");
string? NumberString3 = Console.ReadLine();
int number3 = int.Parse(NumberString3!);

int max = number1;

if (max > number2);
else
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}
else
{
    max = number2;
}

Console.WriteLine("Найдено максимальное число " + max);

