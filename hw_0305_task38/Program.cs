// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива ");
int a = Convert.ToInt32(Console.ReadLine());

void RandomArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int DiffMaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        for (int x = 0; x < arr.Length; x++)
        {
            if (min > arr[x])
            {
                min = arr[x];
            }
            if (max < arr[x])
            {
                max = arr[x];
            }
        }
    }
    return max - min;
}

int[] array = new int[a];
RandomArr(array);
PrintArray(array);
Console.WriteLine(DiffMaxMin(array));