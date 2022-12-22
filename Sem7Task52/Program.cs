// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 

int row = ReadData("Enter the number of rows: ");
int column = ReadData("Enter the number of columns: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
double [] avgArray = AvgColumn(arr2D);
PrintData("Array of average per columns: ");
PrintD1Array (avgArray);

// Считывание входных данных.
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Универсальный метод генерации и заполнение двумерного массива.
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}
// Поиск среднего арифметического по колонкам.
double[] AvgColumn(int [,] arr)
{
    double[] avg = new double[arr.GetLength(1)];
    for(int j=0; j<arr.GetLength(1); j++)
    {
        for(int i=0; i<arr.GetLength(0); i++)
        {
            avg[j]+=arr[i,j];
        }
        avg[j] = avg[j]/arr.GetLength(0);
    }
    return avg;
}
// Вывод массива на печать
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Вывод средних арифметических в виде одномерного массива.
void PrintD1Array(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
// Печать для выходной строки
void PrintData(string msg)
{
    Console.WriteLine(msg);
}