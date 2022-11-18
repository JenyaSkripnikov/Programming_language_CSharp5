/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
Например:
[345, 897, 568, 234] -> 2*/

Random lengthArray = new Random();
int lengthArr = lengthArray.Next(1,13);
int[] array = new int[lengthArr];

void PrintArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99,1000);
        {
        Console.Write($"[{array[i]}] ");
        }
    }
    Console.WriteLine();
}

void PrintDifferenceMaxMin(int[] array)
{
int result = 0;
int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i] % 10;
        if (temp == 0 || temp == 2 || temp == 4 || temp == 6 || temp == 8)
                {
                    result = result + 1;
                }
    }
    {
        Console.WriteLine($"В произвольном массиве количество чётных чисел составляет {result}");
    }
}

PrintArray(array);
PrintDifferenceMaxMin(array);