// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[4];

void MayArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000); // 100 ... 999
    }
}

void EvenNumbers(int[] verifiable)
{
    int res = 0;
    int length = verifiable.Length;
    for(int i = 0; i < length; i++)
    {
        
        if(verifiable[i] % 2 == 0 )
        res+= 1;
        
    }
    Console.Write($"Четных чисел: {res}");
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int j = 0; j < count; j++)
    {
        Console.Write($"{col[j]}, ");
    }

}

MayArray(array);
PrintArray(array);
EvenNumbers(array);

