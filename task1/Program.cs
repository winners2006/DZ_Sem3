// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 

int[] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
        arr[i] = new Random().Next(0, 101);
        Console.Write(arr[i] + " ");
}
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
        if (arr[i] >= 20 && arr[i] <= 90) res++;
}
Console.WriteLine();
Console.WriteLine(res);