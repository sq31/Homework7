/*
Задача 47: Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] getRandomArray(int rowNumber, int colNumber)
{
    double[,] result = new double[rowNumber, colNumber];
    for (var i = 0; i < rowNumber; i++)
    {
        for (var j = 0; j < colNumber; j++)
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
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colNumber = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = getRandomArray(rowNumber, colNumber);
printArray(randomArray);
