Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x >= 100)
{
    while (x >= 1000)
    x = x / 10;
    
    x = x % 10;
    Console.WriteLine(x);
}
else
{
    {
        Console.WriteLine("Третьей цифры нет");
    }
}