//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
System.Random numberSintezator = new System.Random();

//Поулчаем новое случайное число
int number = numberSintezator.Next(10,100);

Console.WriteLine(number);

// //Получаем первое и второе число по отдельности
// int firstNumber = number/10;
// int secondNumber = number%10;

// //Сравниваем числа
// if(firstNumber>secondNumber)
// {
//     //выводим данные в консоль
//     Console.WriteLine(firstNumber);
// }
// else
// {
//     Console.WriteLine(secondNumber);
// }

//Вариант 2

char[] digits = numberSintezator.Next(10,100).ToString().ToArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber = firstNumber:resultNumber=secondNumber

Console.WriteLine(resultNumber);