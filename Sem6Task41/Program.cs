// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int inputNumber = ReadData("Enter the amount of numbers : ");
PrintData("The amount of positive numbers: " + CountPosNum(inputNumber));
// Метод сичтывания введенных данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Вывод результата.
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Поиск кол-ва положительных чисел.
int CountPosNum(int num)
{
    int res = 0;
    while (num > 0)
    {
        if (ReadData("Enter number: ") > 0)
            res++;
        num = num - 1;
    }
    return res;
}