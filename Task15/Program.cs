//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n <= 5);
        Console.WriteLine ("No");
else if ( n > 5 && n <= 7);
    Console.WriteLine ("Yees");
else 
    Console.WriteLine("Такого дня нет"); 
