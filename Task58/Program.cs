// Задача 58
// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2         1 5 8 5
// 5 9 2 3    и    4 9 4 2
// 8 4 2 4         7 2 2 6
// 5 2 6 7         2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Количество строк в матрицах: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество столбцов в матрицах: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];

Console.WriteLine("Матрица 1: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix1[i, j] = new Random().Next(1, 10);
        Console.Write(matrix1[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Матрица 2: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix2[i, j] = new Random().Next(1, 10);
        Console.Write(matrix2[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] result = new int[m, n];
Console.WriteLine("Произведение матриц: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        result[i, j] = matrix1[i, j] * matrix2[i, j];
        Console.Write(result[i, j] + "\t");
    }
    Console.WriteLine();
}