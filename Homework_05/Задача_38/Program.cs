Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа считает разницу между максимальным и минимальным элементов массива. ");
Console.WriteLine("Задайте массив вещественных чисел. ");
Console.WriteLine("Задайте длину массива : ");
int n;
n = Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];
var random = new Random();
for(int i = 0; i < array.Length; i++)
{
	array[i] = random.Next(100) + random.NextDouble();
}
Console.WriteLine("Наш массив: ");
Console.WriteLine("[" + string.Join(",", array) + "]");
double max = array[0];
double min = array[0];
for(int i = 1; i < array.Length; i++)
{
    if(max < array[i]) max = array[i];
    if(min > array[i]) min = array[i];
}
Console.WriteLine("max: ");
Console.WriteLine(max);
Console.WriteLine("min: ");
Console.WriteLine(min);
Console.WriteLine($"max - min = {max - min}");