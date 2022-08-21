// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.WriteLine("Количество элементов по оси x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество элементов по оси y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество элементов по оси z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,,] matrix = new int[x, y, z];

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int k = 0; k < z; k++)
        {
            matrix[i, j, k] = new Random().Next(10, 100);
            Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "\t");
        }
    }
    Console.WriteLine();
}