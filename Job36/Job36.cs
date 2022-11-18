/*ЗЗадайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Например:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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

void PrintSummOddPositions(int[] array)
{
int result = 0; 
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result = result + array[i];
    }
    Console.WriteLine($"В произвольном массиве сумма элементов на нечетных позициях составляет {result}");
}

PrintArray(array);
PrintSummOddPositions(array);