// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.  
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру 
int row = ReadData("Enter the number of rows: ");
int column = ReadData("Enter the number of columns: ");
int indexRow = ReadData("Enter the position in row: ");
int indexColumn = ReadData("nter the position in column: ");
int[,] arr2D = Fill2DArray(row, column);
Print2DArray(arr2D);
if (indexRow < arr2D.GetLength(0) && indexColumn < arr2D.GetLength(1))
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    
    Console.Write("Result of search: ");
    // Закрашиваю найденное число
    Console.ForegroundColor = col[new System.Random().Next(0, 16)];
    PrintData("" + (SearchElement(arr2D, indexRow,indexColumn)));
    Console.ResetColor();
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
// Генерация массива с числами Фибоначчи.
// Как заполнить построчно подряд числами, я не додумалась. =( Воспользовалась такой шпаргалкой.
int[,] Fill2DArray(int countRow, int countColumn)
{
    int[,] array2D = new int[countRow, countColumn];
    array2D[0,0] = 0;
    array2D[0,1] = 1;
    for (int k = 2; k < countColumn; k++)
    {
        array2D[0, k] = array2D[0, k-1] + array2D[0, k-2];
        for (int i = 1; i < countRow; i++)
        {
            for (int j = 0; j < countColumn-1; ++j)
            array2D[i, j] = array2D[i-1, j+1];
            array2D[i, countColumn-1] = array2D[i, countColumn-2] + array2D[i, countColumn-3];
        }
    }
    return array2D;
}
// Поиск элемента.
int SearchElement(int[,] arr, int x, int y)
{  
    int elem = 0;
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    elem = arr[x, y];
    return elem;
}
// Вывод массива на печать.
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}
// Печать найденного результата.
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
