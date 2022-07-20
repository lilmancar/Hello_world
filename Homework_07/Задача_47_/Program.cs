Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа задает  двумерный массив размером m x n,");
Console.WriteLine("заполненный случайными вещественными числами.");
Console.WriteLine("Задайте число n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Наш двумерный массив : ");
double[,] array = new double[n, m];
Random random = new Random();
for (int i = 0; i<n; i++)
{
    for (int j = 0; j<m; j++)
    {
        array[i,j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}\t", array[i,j]); //{0,6:F2} (два знака после запятой), \t (табуляция)
    }
    Console.WriteLine();
}