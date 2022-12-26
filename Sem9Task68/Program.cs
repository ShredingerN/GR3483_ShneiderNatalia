// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
long M = ReadData("Enter positive number M:");
long N = ReadData("Enter positive number N:");
long akkermanFunction = Akkerman(M, N);
PrintResult($"A(M,N) = {akkermanFunction} ");

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
// Функция Аккермана
long Akkerman(long m, long n)
{
	if(m == 0) return n + 1;
	if(m > 0 && n == 0) return Akkerman(m - 1, 1);
	return Akkerman(m - 1, Akkerman(m, n - 1));
}