/*
Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[,] getRandomArray(int rowNumber, int colNumber)
{
    double[,] result = new double[rowNumber, colNumber];
    {
        for (var i = 0; i < rowNumber - 1; i++)
        {
            for (var j = 0; j < colNumber; j++)
            {
                result[i, j] = new Random().Next(1, 20);
            }
        }
        for (var k = 0; k < colNumber; k++) //Заполнение последней строки, расчет среднего.
        {
            for (var n = 0; n < rowNumber - 1; n++)
            {
                result[rowNumber - 1, k] = result[rowNumber - 1, k] + result[n, k];
            }
            result[rowNumber - 1, k] = Math.Round(result[rowNumber - 1, k] / (rowNumber - 1), 2);
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
            if (i == arrayToPrint.GetLength(0)-1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ResetColor();
            }
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int raws = Convert.ToInt32(Console.ReadLine()) + 1;
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = getRandomArray(raws, columns);
printArray(randomArray);

Console.Write("Средние значения по столбцам выведены в последней строке.");