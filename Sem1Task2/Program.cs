//Считываем данные с консоли
string? number1L = Console.ReadLine();
string? number2L = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (number1L != null && number2L != null)
{
    //Преобразуем строковые данные в десятичные
    int num1 = int.Parse(number1L);
    int num2 = int.Parse(number2L);
    //Сравниваем два числа
    if (num1 > num2)
    {   
        Console.WriteLine("max="+num1);
    }
    else
    {
        Console.WriteLine("max="+num2);
    }

}
