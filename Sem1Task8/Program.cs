//Считываем данные с консоли
string? inputNumber = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputNumber != null)
{
    //Преобразуем строковые данные в десятичные
    int inputNum = int.Parse(inputNumber);
    //Задаем переменную для старта поиска четных чисел
    int startNum = 2;
    //Задаем строковую переменную для сбора результатов
    string result = string.Empty;
    //Заупскаем цикл-счетчик. Если остаивть startNum < inputNum то в случае с нечетным исходным выскакивает запятая в конце.
    while (startNum < inputNum - 1)
    {
        result = result + startNum + ", ";
        startNum = startNum + 2;
    }

    //Добавление четного исходного числа и изавление от запятой в конце с нечетным исходным числом. А корректно вместо запятой использовать просто пробел между найденными числами?
    int rest = inputNum % 2;
    if (rest == 0)
    {
        Console.WriteLine(result + inputNumber);
    }
    else
    {
        Console.WriteLine(result + (inputNum - 1));
    }
}
