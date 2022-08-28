Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int min = a;
 if (b < min) min = b;
 if (c < min) min = c;
 Console.WriteLine("min = " + min);
 int sum = (a + b + c) / 3;
 Console.WriteLine("sum = " + sum);
 int m = min / 100;
 int n = sum % 10;
 if (n > m)
 {
    Console.Write("Да");
 }
 if (n == m)
 {
    Console.Write("Цифры равны");
 }
 if (n < m)
 {
    Console.Write("Нет");
 }