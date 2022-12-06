// Задача 29: Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.

int num = 8;

void FillArray(int[] array)
{
    int i=0;
    int count = array.Length;
    while (i < array.Length)
    {
        array[i] = new Random().Next(1, num);
        i++;
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    int count = array.Length;
    while (i < array.Length)
    {
        Console.Write(array[i]);
        i++;
    }
}
int[] array = new int [num];
FillArray(array);
PrintArray(array);