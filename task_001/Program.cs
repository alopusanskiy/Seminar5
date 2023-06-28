// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[ " + string.Join(", ", arr ) + " ]");
}

void EvenNum(int[] array)
{
    int even = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        index = array[i];
        if (index % 2 == 0)
        {
           even++;
        }
    }
        System.Console.WriteLine("-> "+ even + "четные");
}


int[] array = FillArray(10);

PrintArray(array);

EvenNum(array);


