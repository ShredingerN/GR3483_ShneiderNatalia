// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] array = GenArr(10, -9, 9);
Print1DArr(array);
int[] newrray = InverseArr(array);
Print1DArr(newrray);

int[] GenArr(int len, int minVAlue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minVAlue, maxValue + 1);
    }
    return arr;
}

int[] InverseArr(int[]arr)
{
    int[]outArr = new int[arr.Length];
    for(int i=0; i<arr.Length;i++)
    {
        outArr[i]=arr[i]*(-1);
    }
    return outArr;
}

   void Print1DArr(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }