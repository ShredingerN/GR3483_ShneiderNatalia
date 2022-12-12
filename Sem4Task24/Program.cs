//Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.

//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

// Метод вывода результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}

//Суммируем от 1 до А, заказываем int (обязательно return того жн типа)
int VariantSumSimple(int numA)
{
    int sumOfNumbers =0;
    for(int i=1;i<=numA;i++)
    {
        //Присваивает левому операнду сумму левого и правого операндов: 
        //выражение A += B равнозначно выражению A = A + B.
        sumOfNumbers+=i;
    }
    return sumOfNumbers;
}

// Аналитический метод (формул Гаусса)
int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число А:");

DateTime d1 = DateTime.Now; //подсчет времени выполнения программы
//в результат кладем метод и переменную исходную.
int res1 = VariantSumSimple(numberA);
//Вывод результата времени выполнения
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A равна(простой метод):" + res1 );
PrintResult("Сумма чисел от 1 до A равна(простой Гауса):" + res2 );