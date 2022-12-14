// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// Считываем входящие данные
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Выводи результат
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// // Нахождение стемени через функцию Math
// int Pow(int A, int B)
// {
//     int res = (int)Math.Pow(A, B);
//     return res;
// }

// Последовательное возведение в степень
int Pow(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= B; i++)
    {
        res = A * res;
    }
    return res;
}

int num1 = ReadData("Enter number A: ");
int num2 = ReadData("Enter number B: ");
int resPow = Pow(num1, num2);
PrintData("A to the power of B equals: ", resPow);

