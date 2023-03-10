Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ее число: ");
int c = int.Parse(Console.ReadLine()!);
if (a>b && a>c)
  Console.WriteLine(a);
else if (b>a && b>c)
  Console.WriteLine(b);
else if (c>a && c>b)
   Console.WriteLine(c);
