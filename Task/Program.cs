void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter " + i + " array element: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
            Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.WriteLine("Enter the initial size of the array elements");
int massif = Convert.ToInt32(Console.ReadLine());
string[] array = new string[massif];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Entered initial array: [{string.Join(", ", array)}]");
Console.Write("Received array: ");
PrintArray(array);