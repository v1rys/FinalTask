// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []



Console.WriteLine("Сколько элементов будет в ващем массиве?");
int n = Convert.ToInt32(Console.ReadLine());
string[] MassivString = new string[n];
int i = 0;
while (i < MassivString.Length)
{
    Console.WriteLine($"введите {i}-й элемент массива:");
    MassivString[i] = Console.ReadLine();
    i++;
}
Console.WriteLine(string.Join(" ", MassivString));
string[] MassivResult = new string[MassivString.Length];

void NewMassiveString(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewMassiveString(MassivString, MassivResult);
Console.WriteLine();
PrintArray(MassivResult);
