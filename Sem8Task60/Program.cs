// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int row3D = ReadData("Enter number of rows : ");
int column3D = ReadData("Enter number of columns : ");
int sheet3D = ReadData("Enter number of sheets : ");
// Генерация списка двузначных чисел.
List<int> num = new List<int>();
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}
int[,,] array3D = Fill3DArray(row3D, column3D, sheet3D);
Print3DArray(array3D);

// Считывание входных данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Генерация неповторяющегося двузначного числа из ранее созданного списка
int GenNum(List<int> num)
{
    int index = new Random().Next(0, num.Count);
    int outNum = num[index];
    num.RemoveAt(index);
    return outNum;
}
// Заполнение массива
int[,,] Fill3DArray(int row, int column, int sheet)
{
    // System.Random rand = new GenNum();
    int[,,] arr3D = new int[sheet, row, column];
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = GenNum(num);
            }
        }
    }
    return arr3D;
}
// Печать массива с указанием индексов
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

