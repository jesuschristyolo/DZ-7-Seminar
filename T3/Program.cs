// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();


Write("Введите: размер матрицы и диапазон значений чере пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);




WriteLine();
printMatrixArray(array);
WriteLine();
SredArifClmn(array);
WriteLine();


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}


void printMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5}");
        }
        WriteLine();
    }

}

double SredArifClmn (int[,] inArray)
{
     double Sredarif = 0;
    for (int j = 0; j <  inArray.GetLength(1); j++)
    {
        
        Sredarif = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            Sredarif += inArray[i, j];
        }
        Write($"{ Sredarif / inArray.GetLength(0)} ");
       
    }
     return Sredarif;
    
}