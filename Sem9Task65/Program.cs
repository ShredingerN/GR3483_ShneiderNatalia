// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

int numberN = ReadData("Enter number N:");
int numberM = ReadData("Enter number M:");
// Если пользователь перепутал большее с меньшим, программа поменяет их местами
string resultLine = numberN < numberM ? RecMN(numberN, numberM) : RecMN(numberM, numberN);
PrintResult(resultLine);

// Считывание входных данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string prefix)
{
    Console.Write(prefix);
}

string RecMN(int M, int N)
{
    string outRes = string.Empty;
    if (M >= N) return outRes + N;
    outRes = M + " " + RecMN(M + 1, N);
    return outRes;
}
