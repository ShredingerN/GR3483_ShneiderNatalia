// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int row1 = ReadData("Enter number of rows for first matrix: ");
int column1 = ReadData("Enter number of columns for first matrix: ");
int row2 = ReadData("Enter number of rows for second matrix: ");
int column2 = ReadData("Enter number of columns for second matrix: ");
Console.WriteLine();
if (row1 != column2)
{
  Console.WriteLine("Multiplication is impossible! The number of columns of the first matrix is not equal to the number of rows of the second matrix.");
  return;
}
long[,] arr2D1 = Fill2DArray(row1, column1, 100, 999);
Console.WriteLine("First matrix:");
Print2DArray(arr2D1);
long[,] arr2D2 = Fill2DArray(row2, column2, 100, 999);
Console.WriteLine("Second matrix:");
Print2DArray(arr2D2);
long[,] multiplyArr = GetMultiplyMatrix(arr2D1, arr2D2);
Console.WriteLine("Result of multiplication 1 and 2 matrix: ");
Print2DArray(multiplyArr);

// Считывание входных данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Генерируем массив
long [,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    long[,] array2D = new long[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}
// Печатаем массив.
void Print2DArray(long [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Перемножаем два массива
long [,] GetMultiplyMatrix(long[,] arr1, long[,] arr2)
{
    long[,] arr3 = new long[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1)-1; k++)
            {
                arr3[i,j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
}



