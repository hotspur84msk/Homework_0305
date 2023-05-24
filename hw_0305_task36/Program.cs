// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива ");
int a = Convert.ToInt32(Console.ReadLine());

void RandomArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 99);
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

int SumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) // в условии требуются НЕчетные позиции (я думаю, это значит 1-я цифра, 3-я, 5-я и т.д. // не по индексу!!!)
        { // иначе (i = % 2 > 0)
            sum = sum + arr[i];
        }
    }
    return sum;
}


int[] array = new int[a];
RandomArr(array);
PrintArray(array);
Console.WriteLine(SumOddElements(array));
