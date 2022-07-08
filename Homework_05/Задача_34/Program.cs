Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа покажет количество чётных чисел в массиве. ");
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. ");
Console.WriteLine("Задайте длину массива : ");
int n;
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
var random = new Random();
for(int i = 0; i < array.Length; i++)
{
	array[i] = random.Next(100,999);
}
Console.WriteLine("Наш массив: ");
Console.WriteLine("[" + string.Join(",", array) + "]");
int count = 0;

for (int i = 0; i < n; i++)
{
if (array[i] % 2 == 0)
++count;
}

Console.WriteLine("Количество четных элементов массива: " + count.ToString());