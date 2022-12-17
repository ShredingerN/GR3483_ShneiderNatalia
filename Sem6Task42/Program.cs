// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int inputNumber = ReadData("Enter number: ");
PrintData("Result: " + DecToBin(inputNumber));
PrintData(DecToBin2(inputNumber));

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

string DecToBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}
// Достаточно просто заменить основание - 2,8,16 - чтобы перевести в другие системы исчисления.
string DecToBin2(int num)
{
    return Convert.ToString(num, 2);
}
