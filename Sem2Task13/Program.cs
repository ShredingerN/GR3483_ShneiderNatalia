// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Ввод числа и проврка на null
int inputNumber = int.Parse(Console.ReadLine() ?? "0");
if (inputNumber > 99)
{
    int lengthNum = (int)Math.Log10(inputNumber) + 1;
    int count = lengthNum;

    while (count > 2)

    {
        int number = inputNumber / 10;
        int result = number %10;
    
        Console.WriteLine(result);
    }
     count ++;
   
}
else
{
    Console.WriteLine("в заданном числе нет 3-ей цифры");
}

//Вариант 1
//Ввод числа и проврка на null
//int inputNumber = int.Parse(Console.ReadLine() ?? "0");
// //Проверяем число на трехзначность
// if (inputNumber > 99)
// {
//     //Преобразуем введенное число в массив
//     char[] digits = inputNumber.ToString().ToCharArray();
 
//     //выводим результат
//     Console.WriteLine(digits[2]);
// }
// else
// {
//     Console.WriteLine("в заданном числе нет 3-ей цифры");
// }

//Варинат 2

//Console.WriteLine(result);
// int lenNumber(int value)
// {
//     //int result = (int)Math.Log10(Math.Abs(value)) + 1;
//     int result = (int)Math.Log10(value) + 1;
//     if (value==0) result = 1;
//     //return result;
//     //return (value == 0) ? 1 : (int)Math.Log10(Math.Abs(value)) + 1;
    
