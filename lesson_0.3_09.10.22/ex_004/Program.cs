﻿int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for ( int j = i + 1; j < array.Length-1; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temprorary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprorary;

    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);