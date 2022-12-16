//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 

int min = int.MaxValue;
int max = int.MinValue;

int[] array = GenArray(120, -100, 1000);
PrintD1Array(array);
Console.WriteLine();

DateTime d1 = DateTime.Now; 
int [] arraySort1 = InsertionSort(array);
Console.WriteLine(DateTime.Now - d1);
PrintD1Array(arraySort1);
Console.WriteLine();

DateTime d2 = DateTime.Now;
int [] arraySort2 = CountingSort(array);
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

void PrintD1Array(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
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
// Метод сортировки подсчетом.
// -------------------------------------------------------------------------------------------------------------------------------------------------
// У меня просто код, ниже закоменченный, не сработал, происходит переполнение типа данных((.
// Почему, я так и не нашла.
// int[] CountingSort(int[] array, int max)
//     {
//         int [] count = new int[max + 1];
//         for (int i = 0; i < array.Length; i++)
//         {
//             count[array[i]]++;
//         }
//         int index = 0;
//         for (int i = 0; i < count.Length; i++)
//         {
//             for (int j = 0; j < count[i]; j++)
//             {
//                 array[index] = i;
//                 index++;
//             }
//         }
//         return array;
//     }
// Воткнула сложный метод.
// Оно работает, но как - я для себя так и не смогла объяснить. х-D
// Я занулась уже на этапе, почему размер массива счетчика int[] count = new int[max - min + 1] определяем как разницу max/min.
// Мне здесь требуется допольнительное объяснение =D. 
// ------------------------------------------------------------------------------------------------------------------------------------
int[] CountingSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] < min) min = array[i];
         if (array[i] > max) max = array[i];
    }
    int[] count = new int[max - min + 1];
    int newIndex = 0;
    for (int j = 0; j < count.Length; j++)
    {
        count[j] = 0;
    }
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] - min]++;
    }
    for (int k = min; k <= max; k++)
    {
        while (count[k - min]-- > 0)
        {
            array[newIndex] = k;
            ++newIndex;
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

// ИТОГ: самый быстрый - пузырьковая сортировка, потом метод подсчета, метод вставки значительно медленнее. 