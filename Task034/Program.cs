// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray()
{
    var random = new Random();
    var result = new int[4];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }
    return result;
}

int CountOfEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}

void PrintArray (int[] array)
{
    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}



var array = CreateArray();
PrintArray(array);
Console.WriteLine(CountOfEvenNumbers(array));