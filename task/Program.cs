/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/

int getNumberFromUser(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string getStringFromUser(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string[] getArrayStringFromUser()
{
    int m = getNumberFromUser("Сколько элементов Вы будете вводить?: ");
    string[] array = new string[m];
    for (int i = 1; i <= m; i++)
    {
        array[i - 1] = getStringFromUser($"Введите строку {i}: ");
    }
    return array;
}
string[] resultArray(string[] array)
{
    string []resultArray=new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
           resultArray = resultArray.Concat(new string[] { array[i] }).ToArray();
        }
    }
    Console.WriteLine();
return resultArray;
}

void printColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}
void printStringArray(string[] array, string message)
{
    printColor(message, ConsoleColor.Green);
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        printColor(i + 1 + "\t", ConsoleColor.Red);
        Console.WriteLine(array[i]);
    }
}

string[] array = getArrayStringFromUser();
printStringArray(array, "Исходный массив");
string[] resArray = resultArray(array);
printStringArray(resArray, "Результирующий массив");