// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 

int min = int.MaxValue;
int max = int.MinValue;

int[] array = GenArray(10, -100, 50);
PrintD1Array(array);
Console.WriteLine();

DateTime d1 = DateTime.Now; 
int [] arraySort1 = InsertionSort(array);
Console.WriteLine(DateTime.Now - d1);
PrintD1Array(arraySort1);
Console.WriteLine();

DateTime d2 = DateTime.Now;
int [] arraySort2 = CountingSort(array, array[array.Length-1]);
// int [] arraySort2 = CountingSort(array);
Console.WriteLine(DateTime.Now - d2);
PrintD1Array(arraySort2);
Console.WriteLine();

DateTime d3 = DateTime.Now;
Sort(array);
Console.WriteLine(DateTime.Now - d3);
PrintD1Array(array);
Console.WriteLine();

MinMax(array);
PrintData("Differency Max-Min = " + (max - min));

int[] GenArray(int len, int minRange, int maxRange)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minRange, maxRange + 1);
    }
    return arr;
}

void PrintD1Array(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

void MinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine("Min number = " + min + "\nMax number = " + max);
}
// Метод сортировки вставками.
int[] InsertionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // Переменная для текущего числа
        int currentNumber = array[i];
        // Индекс для текущего числа
        int j = i;
        // сравниваем текущее с пердидущим элементом
        while ((j > 0) && (currentNumber < array[j - 1]))
        {
            array[j]=array[j - 1];
            j--;
        }
        array[j] = currentNumber;
    }
    return array;
}
// Метод сортировки подсчетом
int[] CountingSort(int[] array, int max)
{
    int [] count = new int[max+1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i]]++;
    }
    int index = 0;
    for (int i = 0; i < count.Length; i++)
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i;
            index++;
        }
    }
    return array;
}
// Метод сортировки массива пузырьком.
void Sort(int[] array)
{
    int[] sortArr = new int[array.Length];
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}



// int[] CountingSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//          if (array[i] < min) min = array[i];
//          if (array[i] > max) max = array[i];
//     }
//     int[] count = new int[max - min + 1];
//     int newIndex = 0;
//     for (int j = 0; j < count.Length; j++)
//     {
//         count[j] = 0;
//     }
//     for (int i = 0; i < array.Length; i++)
//     {
//         count[array[i] - min]++;
//     }
//     for (int k = min; k <= max; k++)
//     {
//         while (count[k - min]-- > 0)
//         {
//             array[newIndex] = k;
//             ++newIndex;
//         }
//     }
//     return array;
// } 