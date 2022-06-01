/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
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
