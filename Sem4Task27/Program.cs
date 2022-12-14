// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// Считываем входящие данные.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Выводим результат.
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}
// Находим сумму через целочисленное деление.
int SumDigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}
// Находим сумму, переводя число в символьный массив, затем преобразуем в целочисленный массив.
int SumDigitsString(int num)
{
    int sumOfNumbers = 0;
    char[] digits = num.ToString().ToArray();
    int[] arr = new int[digits.Length];
    for (int i = 0; i < digits.Length; i++)
    {
        // arr[i] = digits[i]-'0';
        arr[i] = int.Parse(digits[i].ToString());
        sumOfNumbers += arr[i];
    }
    return sumOfNumbers;
}

int inputNum = ReadData("Enter number: ");
// Оцениваем методы по скорости выполнения
DateTime d1 = DateTime.Now;
int resSum1 = SumDigits(inputNum);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int resSum2 = SumDigitsString(inputNum);
Console.WriteLine(DateTime.Now - d2);

PrintData("The sum of digits equals: ", resSum1);
PrintData("The sum of digits equals: ", resSum2);
//----------------------------------------------------------------------------------
// Скорость выполнения быстрее у метода вычесления суммы через целочисленное деление.
// ---------------------------------------------------------------------------------