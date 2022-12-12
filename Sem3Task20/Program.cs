//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//Метода читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int x1 = ReadData("Введите координату x1");
int x2 = ReadData("Введите координату x2");
int y1 = ReadData("Введите координату y1");
int y2 = ReadData("Введите координату y2");

//Метод находит расстояние между точками на плоскости
double Hypotenuse(double X1, double Y1, double X2, double Y2)
{
    double result = Math.Sqrt(Math.Pow((X1-X2),2)+Math.Pow((Y1-Y2),2));
    return result;
} 


//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

PrintData("Расстояние между точками: ", Hypotenuse (x1, y1, x2, y2)); //вторая часть эквивалентна double result= hypotenuse (x1, y1, x2, y2);

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int xh = ReadData("Введите xh: ");
// int xv = ReadData("Введите xv: ");
// int yh = ReadData("Введите yh: ");
// int yv = ReadData("Введите yv: ");

// double CalculateLength(int x1, int x2, int y1, int y2)
// {
//     double res = 0;
//     res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
//     return res;
// }


// void PrintData(string msg, double result)
// {
//     Console.WriteLine(msg + result);
// }

// PrintData("Расстояние между точками ", CalculateLength(xh, xv, yh, yv));
