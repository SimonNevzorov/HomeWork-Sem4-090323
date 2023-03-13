// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetArray(int size)
{ 
    int [] array = new int [size];
    for (int i =0; i < size; i++)
        {
           array[i] = new Random().Next(100,999);
        }
    return array;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int i =0; i <array.Length; i++)
    {
       Console.Write(array[i] + ", "); 
    }
    Console.Write(array[array.Length-1]+"]");
}

void CountNumber(int[] array)
{ int count =0;
    for (int i=0; i < array.Length;i++)
    {
      if (array[i] % 2 == 0)
      count++;  
    }
    Console.WriteLine($"Количество четных элементов массива равно {count}");
}

// ArrayPrint(GetArray(5));

int [] array1 = GetArray(5);
ArrayPrint(array1);
Console.WriteLine();
CountNumber(array1);

