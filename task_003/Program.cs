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
    System.Console.Write("[ " + string.Join(", ", arr) + " ]");
}

PrintArray(FillArray(6));