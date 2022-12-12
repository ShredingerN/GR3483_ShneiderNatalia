// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//1. Метод для встречи данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//2. Методы вывода массива, с вложенным методом. 
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
//3. Просим ввести длину массива
int arrLen = ReadData("Введите длину массива.");
//4.Задаем переменную для массива, кладем метод для генерации массива
int[] arr = GenArr(arrLen);
//5. Печатем готовый массив
PrintData("Сгененрированный массив:",arr);

