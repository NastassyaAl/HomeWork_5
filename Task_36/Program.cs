Console.Clear();
int[] array = GetArray(8, -30, 30);
Console.WriteLine(String.Join(",", array));
SummArray(array);


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void SummArray(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            summ+= array[i];
        }
    }
    Console.WriteLine("summ = "+summ);
}
