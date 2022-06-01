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


int[,] getRandomArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 20);
        }
    }
    return result;
}

void printArray(int[,] arrayToPrint)
{
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write((arrayToPrint[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = getRandomArray(m, n);
printArray(randomArray);


Console.Write("Введите порядковый номер элемента массива: ");
int poz = Convert.ToInt32(Console.ReadLine());

int count = 0;
{
    for (var i = 0; i < randomArray.GetLength(0); i++)
    {
        for (var j = 0; j < randomArray.GetLength(1); j++)
        {
            count++;
            if (poz == count)
            {
                Console.WriteLine($"Под номером элемента {poz} находится значение {randomArray[i, j]}.");
                break;
            }
        }
    }

    if (poz > count || poz <= 0)
    {
        Console.WriteLine($"Номер элемента {poz} отсутствует в массиве.");
    }
}
