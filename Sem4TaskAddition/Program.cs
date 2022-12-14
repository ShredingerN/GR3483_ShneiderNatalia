// Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал 

//Метод для считывания введеных данных пользователем.
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return (Console.ReadLine() ?? "0");
}
// Метод получения строкового массива.
string[] SplitNames (string names)
{   
    string [] arrNames = names.Split(',');
    return arrNames;
}
// Метод для выбора случайного имени.
string GetRandom(string [] arrNames)
{
    Random rnd = new Random();
    int i = rnd.Next(1, (arrNames.Length) + 1);
    string result = arrNames[i];
    return result;
}
// Метод для печати полученного результата.
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// 1. Вводим имена.
string inputNames = ReadData("Enter names separated by commas: ");
// 2. Получаем массив из имен.
string[] arrayNames = SplitNames(inputNames);
// 3.Выбираем случайное имя.
string resNames = GetRandom (arrayNames);
// 4.Выводим результат.
PrintData("Who does for beer? =) :"+ resNames);


