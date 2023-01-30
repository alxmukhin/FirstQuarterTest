

// Method collects number of elements
int GetNumberOfElements(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}