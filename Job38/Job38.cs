/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
Например:
[3 7 22 2 78] -> 76*/

Random lengthArray = new Random();
int lengthArr = lengthArray.Next(1,13);
int[] array = new int[lengthArr];

void PrintArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100,100);
        {
        Console.Write($"[{array[i]}] ");
        }
    }
    Console.WriteLine();
}

void PrintDifferenceMaxMin(int[] array)
{
int maxNumber = array[0];
int minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
    }
    {
        Console.WriteLine($"В произвольном массиве разница между максимальным числом {maxNumber}");
        Console.WriteLine($"и минимальным числом {minNumber} составляет {maxNumber - minNumber}");
    }
}

PrintArray(array);
PrintDifferenceMaxMin(array);