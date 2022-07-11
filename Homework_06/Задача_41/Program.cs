Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа считает сколько чисел больше 0 ввёл пользователь. ");
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. ");
Console.WriteLine("Задайте число М : ");
int M;
M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for(int i = 0; i < array.Length; i++)
{
	Console.Write("Введите число: ");
    array[i] = int.Parse(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < M; i++)
{
if (array[i] > 0)
++count;
}

Console.WriteLine("Количество чисел больше 0: " + count.ToString());