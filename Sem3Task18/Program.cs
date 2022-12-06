// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int quoter = ReadData("Введите четверть");
PrintAnswer(quoter);

//Метода читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод определяет по координатам точки

void PrintAnswer(int num)
{
if (num > 0 && num < 5)
    {
    if (num == 1) Console.WriteLine("x>0,y>0");
    if (num == 2) Console.WriteLine("x>0,y<0");
    if (num == 3) Console.WriteLine("x<0,y<0");
    if (num == 4) Console.WriteLine("x>0,y<0");
    }
else Console.WriteLine("Вы ввели не номер четверти!");
}


