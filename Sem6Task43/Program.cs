// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double coefficientK1 = ReadData("Input number K1: ");
double coefficientB1 = ReadData("Input number B1: ");
double coefficientK2 = ReadData("Input number K2: ");
double coefficientB2 = ReadData("Input number B2: ");

if (coefficientK1!=coefficientK2)
{
    PrintData(CrossPoint(coefficientK1, coefficientB1,coefficientK2, coefficientB2));
}
else
{
    Console.WriteLine("The lines is not crossed");
}
// Метод сичтывания введенных данных
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0"); 
}
// Вывод результата.
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
// Метод поиска координат точки пересечения линий.
string CrossPoint (double k1, double b1, double k2, double b2)
{       
    string res = string.Empty;
    double coorX = (b2-b1)/(k1-k2);
    double coorY = (k1*b2-k2*b1)/(k1-k2);
    return res = $"Cross point of 2 lines (x,y): ({coorX}; {coorY})";
}

