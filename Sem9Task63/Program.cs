// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

int number = ReadData("Enter number:" );
string resulLine = LineGenRec(number);
PrintResult(resulLine);

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

string LineGenRec(int num)
{
    // обязательное услвоие рекурсии - выход из нее
    if (num <= 0)
    {
        return String.Empty;
    }
    else
    {
        // обязательное услвоие рекурсии - изменение
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
    }
}