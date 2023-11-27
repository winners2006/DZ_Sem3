// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

int[] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
        arr[i] = new Random().Next(0, 101);
        Console.Write(arr[i] + " ");
}
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
        if (arr[i] % 2 == 0) res++;
}
Console.WriteLine();
Console.WriteLine(res);