﻿using static System.Console;
Clear();




Write("Введите: размер матрицы, диапазон значений и позицию элемента по строке и по колонке через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);


int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
int rwposition = (intParams[4]);
int clmnposition = (intParams[5]);



printMatrixArray(array);
SearchForPosition(array, rwposition, clmnposition);
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


void SearchForPosition(int[,] inArray, int RawPosition, int columnposition)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((j == columnposition - 1) && (i == RawPosition - 1))
            {
                WriteLine($"Запрошенное значение равняется -> {inArray[i, j]}");
            }



        }

    }

}