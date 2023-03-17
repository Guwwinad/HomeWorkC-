//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите число: ");
string n = Console.ReadLine();
int len = n.Length;
if (len == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
    Console.WriteLine ("Да");
    }
    else 
    Console.WriteLine("Нет");
}
  
