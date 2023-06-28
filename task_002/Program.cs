// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(0, 16); // диапазон маленький, что бы было удобно проверять правильность работы программы.
    }
    System.Console.Write("[ " + string.Join(", ", array) + " ]");
    return array;
}

// void PrintArray(int[] arr)
// {
//     System.Console.Write("[ " + string.Join(", ", arr) + " ]");
// }


void OddNum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    System.Console.WriteLine(sum);
}

OddNum(FillArray(5));




