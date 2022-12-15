// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int GetEvenNumbers(int[] arr)
{
    int evencount = 0;

    foreach (int el in arr)
    {
        if (el % 2 == 0) evencount += 1;
    }
    return evencount;
}
Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

int[] array = GetArray(num);
PrintArray(array);
Console.WriteLine();
int count = GetEvenNumbers(array);

Console.WriteLine($"Количество четных чисел = {count}");
