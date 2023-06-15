
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());

int b = (a / 10) % 10;

Console.WriteLine($"Вторая цифра это числа - {b}");
