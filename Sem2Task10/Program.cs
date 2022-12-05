﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Ввод числа и проврка на null
int inputNumber = int.Parse(Console.ReadLine() ?? "0");

//Проверяем число на трехзначность
if (inputNumber > 99 && inputNumber < 1000)
{
    //получаем промежуточное двузначное число
    int number1 = inputNumber / 10;
    //находим остаток от деления двузначного числа, что и явялется искомым числом
    int result = number1 % 10;
    //выводим результат
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("введите другое число");
}