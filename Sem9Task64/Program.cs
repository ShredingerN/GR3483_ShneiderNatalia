// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int number = ReadData("Enter number:" );
string resultLine = LineGenRec(number);
PrintResult(resultLine);

// Считывание входных данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}
// вывод результата
void PrintResult(string prefix)
{
    Console.Write(prefix);
}
// генерация строки с числами
string LineGenRec(int num)
{
    if (num <= 0)
    return String.Empty;
    string outLine = num + " " + LineGenRec(num - 1);
    return outLine;
}
