Random rnd = new Random();
void CreateArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-10,10);
}
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],4}");
    }
}

int[] array = new int[10];

void PrintEven(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0 && array[i]!=0) Console.Write($"{array[i],4}");
        
    }
}

CreateArray(array);
PrintArray(array);
System.Console.WriteLine();
PrintEven(array);