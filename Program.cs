int numberElements = GetNumberOfElements("Введите число элементов в массиве, которое вы хотите ввести: ");
string[] array = FillInArray(numberElements);
PrintOutput("Задан массив:", array);
string[] newArray = ExtractThreeSymbolElements(array);
PrintOutput("Новый массив, включающий в себя только те элементы начального массива, чья длина не превышает 3 символа:", newArray);

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

//Method calculates of number array elemts which are not longer than three symbols and builds new array consisting of them
string[] ExtractThreeSymbolElements(string[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            number = number + 1;
        }
    }
    string[] newArray = new string[number];
    number = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length < 4)
        {
            newArray[number] = array[j];
            number++;
        }
    }
    return newArray;
}