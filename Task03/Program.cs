// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] CreateRandomArray(int size)  // Задайте произвольный массив
{
    int[] Array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        Array[i] = rnd.Next(0, 100);
    }
    return Array;
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] arr, int i)  // Выведете его элементы, начиная с конца
    {
        if (i <= 0)
        {
            return;
        }
        else
        {
            Console.Write(arr[i - 1] + " ");
            ReverseArray(arr, i - 1);
        }
    }


Console.WriteLine("Введите размер массива: ");
int n = Int32.Parse(Console.ReadLine()!);

int[] Array = CreateRandomArray(n);
Console.WriteLine("Массив до разворота:");
PrintArray(Array);

Console.WriteLine("Массив после разворота:");
ReverseArray(Array, n);