// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] CreateArray()
{
    var random = new Random();
    var result = new double[5];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.NextDouble() * 100;
    }
    return result;
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

void PrintArray (double[] array)
{
    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write("{0,6:F2}", array[i]);

        if (i != array.Length - 1)
            Console.Write(" ");
    }

    Console.Write("]");
    Console.WriteLine();
}



var array = CreateArray();
PrintArray(array);
Console.WriteLine("{0,6:F2}", MaxNumber(array) - MinNumber(array));