//Считываем данные с консоли
string? number1L = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (number1L != null)
{
    //Преобразуем строковые данные в десятичные
    int num1 = int.Parse(number1L);
    //Находим остаток от деления
    int rest = num1 % 2;
    //Проверяем значение остатка и выводим результат
    if (rest == 0)
    {
        Console.WriteLine("четное");
    }
    else
    {
        Console.WriteLine("нечетное");
    }
}