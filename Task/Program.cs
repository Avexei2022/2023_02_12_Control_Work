// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
PrintTask();
string[] myArray = CreateArray();
FillArray(myArray);
Console.WriteLine();
PrintArray(myArray);
int newArraySize = SearchString(myArray);
if (newArraySize != 0)
{
    string[] newArray = GetResultArray(myArray, newArraySize);
    Console.Write(" -> ");
    PrintArray(newArray);        
}
else Console.Write(" -> []");
Console.WriteLine("\n");

void PrintTask()
{
    Console.WriteLine("Программа формирует первоначальный массив строк, введенных с клавиатуры.\n"+
    "Формирует новый массив из строк, длина которых меньше либо равна 3 символа.\n"+
    "Выводит на экран первоначальный и результирующий массивы.\n");
}

string[] CreateArray()
{
    Console.Write("Введите размер массива строк: ");
    int.TryParse(Console.ReadLine(), out int sizeArray);
    while (sizeArray < 1)
    {
        Console.Write("Размер массива должен быть не менее 1. Повторите ввод: ");
        int.TryParse(Console.ReadLine(), out sizeArray);
    }
    string[] createdArray = new string[sizeArray];
    return createdArray;
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку {i+1}: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length - 1]}\"]");

}

int SearchString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            count++;
        }
    }
    return count;
}

string[] GetResultArray(string[] array, int sizeNewArray)
{
    string[] newArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}