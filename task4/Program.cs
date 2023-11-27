// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.


int n = new Random().Next(0, 100001);
string arrL = Convert.ToString(n);
Console.WriteLine(n);

int[] arr = new int[arrL.Length];
string res = String.Empty;
for (int i = 0; i < arr.Length; i++)
{
        arr[i] = n % 10;
        n/=10;
        res = arr[i] + res;
}
Console.WriteLine(res);