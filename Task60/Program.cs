// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void InputMatrix(int[,,] Matrix)
{
    int number = 10;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix.GetLength(2); k++)
                Matrix[i, j, k] = number++; 
        }
    }
}


void PrintMatrix(int[,,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix.GetLength(2); k++)
                Console.WriteLine($"{Matrix[i, j, k]} ({i}, {j}, {k})");
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] Matrix = new int[size[0], size[1], size[2]];
InputMatrix(Matrix);
PrintMatrix(Matrix);