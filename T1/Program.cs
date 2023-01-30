using static System.Console;
Clear();



Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


double[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
printMatrixArray(array);



double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rand = new Random();
    double[,] resultArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue)) / 1.9;
        }
    }
    return resultArray;
}


void printMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],10:f1}");
        }
        WriteLine();
    }

}

