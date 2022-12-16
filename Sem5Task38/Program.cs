//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 
double min = double.MaxValue;
double max = double.MinValue;

double[] array = GenArray(5, 10, 20);
PrintD1Array(array);
Console.WriteLine();
MinMax(array);
PrintData("Differency Max-Min = " + (max - min));
// Генерация массива вещественными числами.
double[] GenArray(int len, int minVAlue, int maxValue)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minVAlue, maxValue + 1) + rnd.NextDouble();
    }
    return arr;
}
// Вывод массива.
void PrintD1Array(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
// Вывод результата.
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Нахождение максимального и минимального элемента массива.
void MinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine("Min number = " + min + "\nMax number = " + max);
}
