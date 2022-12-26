// Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии

int numberA = ReadData("Enter number A:");
int numberB = ReadData("Enter number B:");
long res1Pow = RecPow(numberA, numberB);
long res2Pow = Pow(numberA, numberB);
long res3Pow = Pow1(numberA, numberB);
PrintResult(res1Pow);
PrintResult(res2Pow);
PrintResult(res3Pow);
// Можно использовать конвертацию ToString(), если метод выдает стринговый итог.
// PrintResult(res3Pow.ToString());

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}

long RecPow(int a, int b)
{
    if (b<= 1) return a;
    return a*RecPow(a,b-1);
}

long Pow(int a, int b)
{
    if (b==2) return a*a;
    return Pow(a,b/2)*Pow(a,b/2);
}

long Pow1(int a, int b)
{
    if (b==2) return a*a;
    if(b==1)return a;

    if (b%2==0)
    {
        return Pow(a,b/2)*Pow(a,b/2);
    }
    else
    {
        return Pow(a,b/2)*Pow(a,b/2+1);
    }
}
