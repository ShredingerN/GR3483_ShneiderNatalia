//строковый оператор переменных
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//проверка на отсутсвие значений
if(num1Line!=null&&num2Line!=null)

{
    //превращаем строковую переменную в десятичную - integer
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    // int outNumber = (int)Math.Pow(inputNumber,2) - возведение в степень


    //действие
    int outResult = num1*num2;
    Console.WriteLine(outResult);
    //Console.WriteLine(Math.Pow(int.Parse(inputNumber),2)); - раскрутка операции начинается с преобразования строки в число
}

