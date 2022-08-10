// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

namespace ConsoleApp9
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("{0} ", (a > b) ? a : b);
Console.WriteLine("{0}", (a < b) ? a : b);
Console.WriteLine();
}
}
}