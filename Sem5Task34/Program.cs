// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GenArray(120, 100, 999);
Print1DArray(array);
Sort(array);
Console.WriteLine();
Print1DArray(array);
int result = CountEven(array);
Console.WriteLine();
PrintData("Amount of even numbers: " + result);

// Метод генерации массива.
int[] GenArray(int len, int minVAlue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minVAlue, maxValue + 1);
    }
    return arr;
}
// Метод печати сгенерированных массивов.
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
// Метод печати результата.
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Метод подсчета количества четных элементов массива.
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        // if (arr[i] % 2 == 0)
        if (EvenTest(arr[i]))
        {
            res++;
        }
    }
    return res;
}
//Отдельный метод на проверку чётности элемента.
bool EvenTest(int num)
{
    return (num % 2 == 0);
}
// Метод сортировки массива пузырьком.
void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        // Переменная для индекса минимального элемента.
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        // Cоздаем временную переменную для перекидки элементов массива.
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
