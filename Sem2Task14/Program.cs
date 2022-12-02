//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int number = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine(number1);


int result1 = number % 7;
int result2 = number % 23;

//логическое и - &&, или - ||
if ((result1 == 0) && (result2 == 0))
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");

}
