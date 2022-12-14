//Написать калькулятор с операциями +, -, /, * и возведение в степень 
// ----------------------------------------------------------
// Мой примитивный вариант калькулятора(вроде работает...)
// ----------------------------------------------------------

double num1 = ReadData("Enter number A: ");
string operation = ReadOperation("PLease choose and enter one operation: \n+\n-\n/\n*\n^\nYour chose: ");
double num2 = ReadData("Enter number B: ");
double resultOperation = MathOperation(num1, num2);
PrintData("Result operation: ", resultOperation);
// Считываем входящие числа от пользователя.
double ReadData(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}
// Считываем выбранную математическую операцию.
string ReadOperation(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}
// Выводим результат
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
// Метод, содержащий мате.операции, использовала глобальную переменную operation, т.к не получилось включить локальную. =(
double MathOperation(double A, double B)
{
    resultOperation = 0;
    if (operation == "+") resultOperation = resultOperation + A + B;
    if (operation == "-") resultOperation = resultOperation + A - B;
    if (operation == "/")
        if (B != 0)
        {
            resultOperation = resultOperation + A / B;
        }
        else
        {
            Console.WriteLine("Error!");
        }
    if (operation == "*") resultOperation = resultOperation + A * B;
    if (operation == "^") resultOperation = resultOperation + Math.Pow(A, B);
    return resultOperation;

}
