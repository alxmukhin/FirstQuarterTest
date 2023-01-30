

// Method collects number of elements
int GetNumberOfElements(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Method fills in array
string[] FillInArray(int number)
{
    string[] array = new string[number];
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Введите " + (i + 1) + "-й элемент массива:");
        array[i] = Console.ReadLine() ?? "0";
    }
    return array;
}

// Method prints array with description before it
void PrintOutput(string message, string[] array)
{
    Console.WriteLine();
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}