// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

double [] GetArray( int size)
{
    double [] array = new double [size];
    for (int i=0; i<array.Length;i++)
    {
     array[i] = new Random().Next(-100,100);   
    }
    return array;
}

void PrintArray(double[] array)
{   
    Console.Write("[");
    for (int i = 0; i <array.Length;i++)
    {
        Console.Write(array[i] + ",");
    }
Console.Write("]");
Console.WriteLine();
}

 void DiffFinder (double [] array)
{ 
    double max = array[0];
    for (int i=1; i <array.Length;i++)
    if (array[i]>max)
    max = array[i];
    //return max;
Console.WriteLine($"Наибольший элемент массива равен {max}");
Console.WriteLine();

    double min = array[0];
    for (int i=1; i <array.Length;i++)
    if (array[i]<min)
    min = array[i];
Console.WriteLine($"Наименьший элемент массива равен {min}");
double diff = max-min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {diff}");
Console.WriteLine();

}


double [] array1 = GetArray(10);
PrintArray(array1);
DiffFinder(array1);
