//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 40); // [1, 10]
Console.WriteLine($"[{string.Join(", ", array)}]");