// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array.Length);
}

int size = 8;
int min = 0;
int max = 9;
int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);
Console.Write(" -> [");
PrintArray(myArray);
Console.Write("]");