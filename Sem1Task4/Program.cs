//Считываем данные с консоли
string? number1L = Console.ReadLine();
string? number2L = Console.ReadLine();
string? number3L = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (number1L != null && number2L != null && number3L != null)
{
    //Преобразуем строковые данные в десятичные
    int num1 = int.Parse(number1L);
    int num2 = int.Parse(number2L);
    int num3 = int.Parse(number3L);
    // //Сравниваем поочередно 3 числа
    // if (num1 > num2)
    // {   
    //     if (num1>num3)
    //     {
    //         Console.WriteLine("max="+num1);
    //     }
    //     else
    //     {
    //         Console.WriteLine("max="+num3);
    //     }
    // }
    // else
    // {
    //     if (num2>num3)
    //     {
    //         Console.WriteLine("max="+num2);
    //     }    
    //      else
    //     {
    //         Console.WriteLine("max="+num3);
    //     }
    // }
    //использовала функцию Math.Max
    int max = Math.Max(Math.Max(num1, num2), num3);
    Console.WriteLine(max);
}
