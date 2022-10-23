// Написать программу замену элементов массива на противоположные
int[] array = {1, 2, 4, 58, 21, 25};
int length = array.Length;



for (int i = 0; i < length; i++)
{
    array[i] = array[i] * (-1);
    Console.WriteLine(array[i]);
}

