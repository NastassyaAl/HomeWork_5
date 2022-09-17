Console.Clear();
double[] array = GetArray(10, 0, 100);
Console.WriteLine(String.Join(",", array));
MaxMinArray(array);


double[] GetArray(int size, int minvalue, int maxvalue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minvalue, maxvalue);
    }
    return array;
}

void MaxMinArray(double[] array)
{
    
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Разница между максимальным и минимальным значениями: {max-min}");
}
