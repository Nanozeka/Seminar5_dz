// Задача 38:
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3; 7; 22; 2,2; 78,2] -> 76


double[] ArrayRndDoubleNum(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 10, 1);
    }
    return arr;
}

double[] GetMinMaxElem(double[] array)
{
    double maxElem = array[0];
    double minElem = array[0];
    double res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxElem < array[i])
        {
            maxElem = array[i];
        }

        if (minElem > array[i])
        {
            minElem = array[i];
        }
        res = maxElem - minElem;
    }
    return new double[] { res };
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = ArrayRndDoubleNum(5, 10, 100);
PrintArray(array);
double[] getMinMaxElem = GetMinMaxElem(array);
Console.WriteLine();
Console.WriteLine
($"Разница между максимальным и минимальным элементом массива = {getMinMaxElem[0]}");

