/*
Задача 47: Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] getRandomArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 100;
        }
    }
    return result;
}

void printArray(double[,] arrayToPrint)
{
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round((arrayToPrint[i, j]), 2) + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = getRandomArray(m, n);
printArray(randomArray);
