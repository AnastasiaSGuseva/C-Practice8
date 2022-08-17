// Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[] sum = new int[m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] = sum[i] + matrix[i, j];
    }
}

int count = 0;
int min = sum[count];
int minCount = 0;
while (count < sum.Length)
{
    if (sum[count] < min)
    {
        min = sum[count];
        minCount = count;
    }
    count++;
}
Console.WriteLine("Номер строки с наименьшей суммой элементов = " + (minCount + 1));