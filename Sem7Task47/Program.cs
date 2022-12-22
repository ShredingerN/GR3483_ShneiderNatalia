//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
int row = ReadData("Enter the number of rows: ");
int column = ReadData("Enter the number of columns: ");
double[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);

// Считывание входных данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Универсальный метод генерации и заполнение двумерного массива
double [,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = Math.Round((rand.Next(topBorder, downBorder + 1) + rand.NextDouble()),5);
        }
    }
    return array2D;
}
// Вывод массива на печать
void Print2DArrayColor(double[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(matrix[i, j]+"               ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}
