//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] myarray)
{
    int length = myarray.Length;
    int index = 0;
    while (index < length)
    {
        myarray[index] = new Random().Next(100);
        index++;
    }
}

void PrintArray(int[] myarray)
{
    int count = myarray.Length;
    int index = 0;
    while (index < count)
    {
        Console.WriteLine($"{myarray[index]},");
        index++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);

