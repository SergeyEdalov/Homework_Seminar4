// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];

void FillArray(int[] array)
{
    Console.Write("[");
    
    int lenght = array.Length;
    int index = 0;

    while (index < lenght)
    {
        array[index] = new Random().Next(0, 100);
        Console.Write(" " + array[index] + " ");
        index++;
    }
    Console.Write("]");
}

FillArray(array);