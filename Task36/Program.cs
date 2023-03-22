//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); 
}
int Sum(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (i % 2 == 1)
        Sum += array[i];

    }
    return Sum;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(Sum(array));