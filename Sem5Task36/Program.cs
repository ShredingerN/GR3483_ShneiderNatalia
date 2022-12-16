// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(120, 100, 999);
PrintD1Array(array);
int result = SumOdd(array);
Console.WriteLine();
PrintData("Sum of odd numbers: " + result);
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
void PrintD1Array(int[] arr)
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
// Метод нахождения суммы элементов с нечетным индексом.
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 0;
    while (i < arr.Length)
    {
        res += array[i];
        i = i + 2;
    }
    return res;
}
