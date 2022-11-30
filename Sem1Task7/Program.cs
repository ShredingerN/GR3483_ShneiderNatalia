//Напишите программу, которая на вход трехзначное число и на выход показывает последнюю цифру этого числа
string? inputB = Console.ReadLine();

if (inputB != null)
{
    int inputC = int.Parse(inputB);

// % целочисленное деление, вычисление остатка от деления
    int lastDigit = inputC % 10; 
    Console.WriteLine(lastDigit);
}
