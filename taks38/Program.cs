// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double[8];

void FillArray(double[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); // 10 - 50
    }
    
}

void DifferenceNumbers(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];

    for(int i = 0; i < numbers.Length; i++)
    {
        if(max < numbers[i])
            max = numbers[i];
        if (min > numbers[i])
            min = numbers[i];
    }
    Console.WriteLine($"Разница: {max - min}");
}

void PrintArray(double[] col)
{
    double count = col.Length;
    for(int j = 0; j < count; j++)
    {
        Console.Write($"{col[j]} ");
    }

}


Console.Clear();
FillArray(array);
PrintArray(array);
Console.WriteLine();
DifferenceNumbers(array);

