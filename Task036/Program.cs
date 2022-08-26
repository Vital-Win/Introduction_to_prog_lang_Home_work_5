// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArray()
{
    var random = new Random();
    var result = new int[4];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-100, 101);
    }
    return result;
}

int SumElementsOnOddPosition(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
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
Console.WriteLine(SumElementsOnOddPosition(array));
