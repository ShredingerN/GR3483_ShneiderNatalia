// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Ввод числа и проврка на null.
// int inputNumber = int.Parse(Console.ReadLine() ?? "0");

// //Вариант 1
// //Проверяем цифру в заданном интервале.
// if (inputNumber > 0 && inputNumber < 8)
// {
//     //Проверяем, какойму дню соотвествует заданная цифра.
//     if (inputNumber > 5)
//     {
//         Console.WriteLine("Это выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Это рабочий день");
//     }
// }
// else
// {
//     Console.WriteLine("Это не день недели");
// }

// //Вариант 2
// //Проверяем цифру в заданном интервале.
// if (inputNumber > 0 && inputNumber < 8)
// {
//     //Задаем массив с днями недели
//     string[] dayWeek = new string[7];
//     dayWeek[0] = "рабочий";
//     dayWeek[1] = "рабочий";
//     dayWeek[2] = "рабочий";
//     dayWeek[3] = "рабочий";
//     dayWeek[4] = "рабочий";
//     dayWeek[5] = "выходной";
//     dayWeek[6] = "выходной";
//     //Выводим результат
//     Console.WriteLine(dayWeek[inputNumber - 1]);
// }
// else
// {
//     Console.WriteLine("Это не день недели");
// }

// //Вариант 3
// //Проверяем цифру в заданном интервале.
// int inputNumber = int.Parse(Console.ReadLine() ?? "0");
// //Создаем словарь
// Dictionary<int, string> dayWeek = new Dictionary<int, string>()
// //Заполняем значениями
// {
//     [1] = "это рабочий день",
//     [2] = "это рабочий день",
//     [3] = "это рабочий день",
//     [4] = "это рабочий день",
//     [5] = "это рабочий день",
//     [6] = "это выходной день",
//     [7] = "это выходной день",

// };
// //Проверяем цифру на соответствие значениям словаря
// if (inputNumber > 0 && inputNumber < 8)
// {
//     //Задаем переменную для вывода информации по дню недели    
//     string day = dayWeek[inputNumber];
//     Console.WriteLine(day);
// }
// else
// {
//     Console.WriteLine("Это не день недели");
// }


//Вариант 4
//Проверяем цифру в заданном интервале.
int inputNumber = int.Parse(Console.ReadLine() ?? "0");
//Создаем словарь
Dictionary<int, string> dayWeek = new Dictionary<int, string>()
//Заполняем значениями
{
    [1] = "это рабочий день",
    [2] = "это рабочий день",
    [3] = "это рабочий день",
    [4] = "это рабочий день",
    [5] = "это рабочий день",
    [6] = "это выходной день",
    [7] = "это выходной день",

};
//Использовала метод для проверки соотвествия введеной цифры значениям словаря
void Week(int day)
{
    bool res = (day > 0 && day < 8);
    if (res == true) Console.WriteLine(dayWeek[inputNumber]);
    else Console.WriteLine("Это не день недели");
}

Week(inputNumber);





