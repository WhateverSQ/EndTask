// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

string[] FirstArray = new string[5] {"Hello", "2", "world", "1234", ":-)"};
string[] SecondArray = new string[FirstArray.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillSecondArray(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
    if(FirstArray[i].Length <= 3)
        {
        SecondArray[count] = FirstArray[i];
        count++;
        }
    }
}

System.Console.WriteLine("Start array: ");
PrintArray(FirstArray);
FillSecondArray(FirstArray, SecondArray);
System.Console.WriteLine("Final array: ");
PrintArray(SecondArray);