// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 10, 3); 
    }
    return array;
}
void PrintArray(double[] arr)
{
    System.Console.Write("[ " + string.Join(", ", arr) + " ] => ");
}

void Diffirent(double[] arr)
{
    double minValue = arr[0];
    double maxValue = arr[1];
    double result = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minValue)
        {
           minValue = arr[i]; 
        }
        else if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
    }
    result = maxValue - minValue;

    System.Console.Write(maxValue + " - " + minValue + " = " + result);
}

double[] array = FillArray(5);

PrintArray(array);

Diffirent(array);
