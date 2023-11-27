// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.

double[] arr = new double[10];
for (int i = 0; i < arr.Length; i++)
{
        arr[i] = new Random().Next(0, 101) / 10.0;
        Console.Write(arr[i] + " ");
}
double min = arr[0];
double max = arr[0];
foreach (var el in arr)
{
        if (el < min) min = el;
        if (el > max) max = el;

}
double res = max - min;
Console.WriteLine();
Console.WriteLine(res);