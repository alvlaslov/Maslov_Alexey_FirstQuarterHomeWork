string[] startArray = new string[6] { "house", "rat", "55", "hat", "mouse", "12" };
string[] finalArray = new string[startArray.Length];
FillArrayThreeOrFewerSymbols(startArray, finalArray);
Console.WriteLine();
PrintFirstArray(startArray);
Console.Write($" -> ");
PrintFinalArray(finalArray);
Console.WriteLine();


void FillArrayThreeOrFewerSymbols(string[] startArray, string[] finalArray)
{
    int j = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
            finalArray[j] = startArray[i];
            j++;
        }
    }
}

void PrintFirstArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"\b\b");
    Console.Write($"]");
}

void PrintFinalArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write($"\b\b");
    Console.Write($"]");
}