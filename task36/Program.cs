// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 100);
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

Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

int[] array = GetArray(num);
PrintArray(array);
Console.WriteLine();

int oddindexsum = 0;

for (int i = 1; i < array.Length; i = i + 2)
{
    oddindexsum = oddindexsum + array[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {oddindexsum}");