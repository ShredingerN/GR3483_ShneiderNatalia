// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


//Метода читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int coorX = ReadData("Введите координату Х");
int coorY = ReadData("Введите координату Y");

//Метод определяет четверть по координатам точки
void PrintQuaterTest()
{
    if (coorX > 0 && coorY > 0) Console.WriteLine("Четверть 1");
    if (coorX > 0 && coorY < 0) Console.WriteLine("Четверть 2");
    if (coorX < 0 && coorY < 0) Console.WriteLine("Четверть 3");
    if (coorX < 0 && coorY > 0) Console.WriteLine("Четверть 4");
}

PrintQuaterTest();