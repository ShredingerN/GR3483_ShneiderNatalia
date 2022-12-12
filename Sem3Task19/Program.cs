//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Вариант 1

//---------------------------------------------------------------------------------------------------------------------
// Этот вариант мне не очень нравиться, если вводится не 5-значное число, дополнительно к коментарию выскакивает false:
// Это не пятизначное число
// Ответ: False
//---------------------------------------------------------------------------------------------------------------------
int number = ReadData("Введите число : ");

PrintData("Ответ: ", PalinTest(number));

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

bool PalinTest(int num)
{
    bool result = false;
    if (number > 9999 && number < 100000)
    {
        if ((num / 10000 == num % 10) && ((num / 1000) % 10 == ((num / 10) % 10))) result = true;

    }
    else Console.WriteLine("Это не пятизначное число");
    return result;
}

void PrintData(string msg, bool res)
{
    Console.WriteLine(msg + res);
}

//Вариант 2

//----------------------------------------------------------------
// Здесь возможно код не очень красивый, но нет лишнего в выводе
//----------------------------------------------------------------

// int number = ReadData("Введите число : ");

// if (number > 9999 && number < 100000)
// {
//     PrintData("Ответ: ", PalinTest(number));
// }
// else
// {
//     Console.WriteLine("Это не пятизначное число");
// }

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// bool PalinTest(int num)
// {   
//     bool result = ((num / 10000 == num % 10) && ((num / 1000) % 10 == ((num / 10) % 10)));
//     return result;
// }

// void PrintData(string msg, bool res)
// {
//     Console.WriteLine(msg + res);
// }