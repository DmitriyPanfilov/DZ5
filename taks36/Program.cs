// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

void MayArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-20, 50); // 100 ... 999
    }
    
}

void SumEvenNumbers(int[] verifiable)
{
    int sum = 0;
    
    for(int i = 0; i < verifiable.Length; i++)
    {
        int posishon = i;
        if(posishon % 2 == 1)
        sum+= verifiable[i];
    }
    Console.Write($"сумма чисел на нечетных позициях: {sum}");
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
SumEvenNumbers(array);