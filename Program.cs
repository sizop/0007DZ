// #1
/*
Console.Write($"Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= B; i++)
{
    result *= A;
}
Console.WriteLine(result);
*/

// #2
/*
Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i>0; i/=10)
{
	result = result + i % 10;
}
Console.WriteLine($"Сумма цифр числа {number} составляет: {result}");
*/

Console.WriteLine("Введите размер вводимого массива:");
int Size_array = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Size_array];

for (int i = 0; i < Size_array; i++)
{ array[i] = new Random().Next(10); }
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
