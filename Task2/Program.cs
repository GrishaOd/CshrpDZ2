// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 0)
{
    a = a * -1;
}
if (a < 100 && a > 0)
{
    Console.WriteLine("Здесь нет третьей цифры");
}
else
{
    while (a / 100 > 10)
    {
        a = a / 10;
    }
    Console.WriteLine($"Третья цифра: {a % 10}");
}