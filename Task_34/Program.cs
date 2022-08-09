// Задача 34:
// 1. Задайте массив заполненный случайными положительными
//  трёхзначными числами.
// 2. Напишите программу,которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] ArrayRndPosNum(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] GetCountPosInt(int[] array)
{
    
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sumPos ++;
        }
        
    }
    return new int[] {sumPos};
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length -1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = ArrayRndPosNum(10, 100, 999);
PrintArray(array);
int[] getCountPosInt = GetCountPosInt (array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел = {getCountPosInt[0]}");
