//  Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено. 

int inputNumber = ReadData("Enter the amount of pressing: ");
string KeyChars = InputKey(inputNumber);

// Метод сичтывания введенных данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Вывод результата.
void PrintData(string res)
{
    Console.WriteLine(res);
}

string InputKey(int num)
{
    string res = String.Empty;
    while (num > 0)
    {
        var key = Console.ReadKey();
        Console.WriteLine(key.Key);
        num = num - 1;
    }
    return res;
 }
// --------------------------------------------------------------------
// СДАЮСЬ!!!! Не понимаю, как работать с ConsoleKey =( , послушаю разбор. 
// --------------------------------------------------------------------

// Console.WriteLine("Нажмите любую клавишу:");
// var key2 = Console.ReadKey();
// Console.WriteLine(key2.Key);
// Console.WriteLine(key2.KeyChar);
