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
    //Заупскаем цикл-счетчик
    while (startNum <= inputNum)
    {
        result = result + startNum + ", ";
        startNum = startNum + 2;
    }
    Console.WriteLine(result);
}
