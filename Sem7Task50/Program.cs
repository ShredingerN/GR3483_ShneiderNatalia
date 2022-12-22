// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.  
int row = ReadData("Enter the number of rows: ");
int column = ReadData("Enter the number of columns: ");
int indexRow = ReadData("Enter the position in row: ");
int indexColumn = ReadData("Enter the position in column: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
if (indexRow < arr2D.GetLength(0) && indexColumn < arr2D.GetLength(1))
{
    PrintData("Result of search: " + SearchElement(arr2D, indexRow, indexColumn));
}
else
{
    PrintData("Result of search: no such element");
}

// Считывание входных данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Универсальный метод генерации и заполнение двумерного массива
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
// Поиск элемента
int SearchElement(int[,] arr, int x, int y)
{   
    int elem = 0;
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    elem = arr[x, y];
    return elem;
}
// Печать массива
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
// Печать результата
void PrintData(string msg)
{
    Console.WriteLine(msg);
}