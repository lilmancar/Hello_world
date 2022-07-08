Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа считает сумму элементов, стоящих на нечётных позициях. ");
Console.WriteLine("Нумерация начинается с нуля.");
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. ");
Console.WriteLine("Задайте длину массива : ");
int n, sum1 = 0, sum2 = 0;
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
var random = new Random();
for(int i = 0; i < array.Length; i++)
{
	array[i] = random.Next(1,100);
}
Console.WriteLine("Наш массив: ");
Console.WriteLine("[" + string.Join(",", array) + "]");
for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                  sum1 = sum1 + array[i];
                else
                  sum2 = sum2 + array[i];
            }
 Console.WriteLine("Сумма элементов с нечетными номерами: {0} ", sum2);