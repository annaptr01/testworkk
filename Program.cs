/*Задача: Написать программу, которая из имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []                          */

﻿string[] MainArray = FillArray();
string[] resultArray = GenerateNewArray(MainArray);
string firstArray = PrintArray(MainArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);

string[] FillArray()
{
    Console.WriteLine("Enter elements separated by spaces: ");
    string enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] MainArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return MainArray;
}

string PrintArray(string[] MainArray)
{
    string stringArray = "[";
    for (int i = 0; i < MainArray.Length; i++)
    {
        if (i == MainArray.Length - 1)
        {
            stringArray += $"\"{MainArray[i]}\"";
            break;
        }
        stringArray += ($"\"{MainArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] MainArray)
{
    int counter = 0;
    foreach (string item in MainArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] MainArray)
{
    int resultArrayLength = CountStringSymbols(MainArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in MainArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}