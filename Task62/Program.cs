// Задача 62. 
// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1   2   3   4
// 12  13  14  5
// 11  16  15  6
// 10  9   8   7

int m = 4;
int[,] matrix = new int[m, m];

int x = 1;

for (int i = 0; i < m; i++)
{
    if (i == 0)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] += x;
            x++;
        }
    }
}

for (int i = 1; i < m; i++)
{
    for (int j = 3; j < m; j++)
    {
        matrix[i, j] += x;
        x++;
    }

}

for (int i = 3; i < m; i++)
{
    for (int j = 2; j >= 0; j--)
    {
        matrix[i, j] += x;
        x++;
    }

}

for (int i = 2; i > 0; i--)
{
    for (int j = 0; j == 0; j++)
    {
        matrix[i, j] += x;
        x++;
    }
}


for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < 3; j++)
    {
        matrix[i, j] += x;
        x++;
    }
}

for (int i = 2; i < 3; i++)
{
        for (int j = 2; j > 0; j--)
        {
            matrix[i, j] += x;
            x++;
        }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + "\t");
    Console.WriteLine();
}