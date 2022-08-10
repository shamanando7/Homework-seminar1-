// Выяснить является ли число четным. 

Start:
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
if ((x % 2) == 0)
{
     Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
goto Start;