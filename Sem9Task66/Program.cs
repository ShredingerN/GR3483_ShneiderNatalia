//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numberM = ReadData("Enter number M:");
int numberN = ReadData("Enter number N:");
int resSum = numberM < numberN ? SumRecMN(numberM, numberN) : SumRecMN(numberN, numberM);
// int resSum = SumRecMN(numberM, numberN);
PrintResult("The sum of numbers between M & N: " + resSum);

// Считывание входных данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Печать результата
void PrintResult(string prefix)
{
    Console.Write(prefix);
}
// Поиск суммы чисел в заданном промежутке
int SumRecMN(int M, int N)
{
    if (M >= N) return N;
    return M + SumRecMN (M + 1, N);
}


