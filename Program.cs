Console.Clear();
string[] FirstArray = {"1234", "1567", "-2", "computer science"};
string[] Find(string[] FirstArray)
{
    string[] SecondArray = new string[0];
    int j = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 2)
        {
            int lenght = SecondArray.Length;
            Array.Resize(ref SecondArray, lenght + 1);
            SecondArray[j] = FirstArray[i];
            j++;

        }

    }
    return (SecondArray); 
}
void PrintArray(string[] FirstArray, string[] SecondArray)

{
    Console.Write("[");
    for (int i = 0; i < FirstArray.Length; i++)
    {
        Console.Write(FirstArray[i]);
        if (i != FirstArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < SecondArray.Length; i++)
    {
        Console.Write(SecondArray[i]);
        if (i != SecondArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

PrintArray(FirstArray, Find(FirstArray));
