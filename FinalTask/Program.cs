
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
