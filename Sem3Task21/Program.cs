// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int coorx1 = ReadData("Введите координату x1");
int coorx2 = ReadData("Введите координату x2");
int coory1 = ReadData("Введите координату y1");
int coory2 = ReadData("Введите координату y2");
int coorz1 = ReadData("Введите координату z1");
int coorz2 = ReadData("Введите координату z2");

PrintData("Расстояние между точками: ", CountLenпth(coorx1, coory1, coorx2, coory2, coorz1, coorz2));

//Метода читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод находит расстояние между точками на плоскости
double CountLenпth(double X1, double Y1, double X2, double Y2, double Z1, double Z2)
{
    double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
    return result;
}

//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

