// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
//Ввести с клавиатуры длину массива и диапазон значений элементов.

//Пользователь вводит лину массива и диапазон значений элементов.
int arrLen = ReadData("Enter the length of array: ");
int range1 = ReadData("Enter the beginning of the range: ");
int range2 = ReadData("Enter the end of the range: ");

int[] arr = GenArr(arrLen);
PrintData("Generated array:",arr);

// Считываем входящие данные.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Выводим результат.
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}
// Генерируем массив из случайных чисел в указанном пользователем диапазоне.
int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(range1, range2+1);
    }
    return arr;
}
// Печатаем массив.
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}


