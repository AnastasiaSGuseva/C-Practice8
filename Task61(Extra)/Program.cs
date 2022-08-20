// Задача 61(ДОП). 
// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника.

Console.WriteLine("Введите необходимое количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int[][] array = new int[n][];
for (int j = 0; j < n; j++)
{
    array[j] = new int[j + 1];
    for (int i = 0; i < array[j].Length; i++)
    {
        if (i == 0 || i == j)
            array[j][i] = 1;
        else
            array[j][i] = array[j-1][i-1] + array[j-1][i];
    }
    Console.WriteLine(string.Join("\t", array[j]));
}



// myArr[0] = new int[4];
// myArr[1] = new int[6];
// myArr[2] = new int[3];
// myArr[3] = new int[4];

// // Инициализируем ступенчатый массив
// for (; i < 4; i++)
// {
//     myArr[0][i] = i;
//     Console.Write("{0}\t",myArr[0][i]);
// }

// Console.WriteLine();
// for (i = 0; i < 6; i++)
// {
//     myArr[1][i] = i;
//     Console.Write("{0}\t", myArr[1][i]);
// }

// Console.WriteLine();
// for (i = 0; i < 3; i++)
// {
//     myArr[2][i] = i;
//     Console.Write("{0}\t", myArr[2][i]);
// }

// Console.WriteLine();
// for (i = 0; i < 4; i++)
// {
//     myArr[3][i] = i;
//     Console.Write("{0}\t", myArr[3][i]);
// }

//     Console.ReadLine();
