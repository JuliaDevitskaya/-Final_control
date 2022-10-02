// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите массив из строк через пробел");
string[] Mass=ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int count = 3;
string[] newMass=NewArray(Mass,count);
PrintArray(newMass);



string[] NewArray(string[]array, int size)
{
    string[] result=new string[size];
    int i=0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length<4)
        {
            result[i]=array[j];
            i++;
        }
    }
    return result;
}

void PrintArray(string[]array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
         if (i != (array.Length - 1)) Write($"{array[i]} ");
         else Write($"{array[i]}");
    }
    Write("]");
    WriteLine();
}






