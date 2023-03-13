// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] GetArray( int size)
{
    int [] array = new int[size];
    for (int i=0; i< size; i++)
    {
       array[i] = new Random().Next(-10,11);
    }
    return array;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int i =0; i<array.Length;i++)
    Console.Write(array[i]+",");
    
    Console.Write("]");
    Console.WriteLine();
}
void SumPosition(int[] array)
{
    int sum = 0;
    for( int i=1; i<array.Length;i+=2)
    {
        sum+=array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях массива равна  {sum}");
}

int[] array1 = GetArray(5);
ArrayPrint(array1);
//Console.WriteLine(string.Join(" ", array1));
SumPosition(array1);

