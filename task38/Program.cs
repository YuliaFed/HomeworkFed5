// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 100);
    }
    return res;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

double GetMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double GetMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

double[] array = GetArray(num);
PrintArray(array);
Console.WriteLine();

double max = GetMax(array);
double min = GetMin(array);
double x = max - min;

Console.WriteLine($"Максимум = {max}; минимум = {min}; Разница между максимальным и минимальным элементами = {x}");