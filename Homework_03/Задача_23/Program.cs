Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа принимает на вход число (N) ");
Console.WriteLine("И выдаёт таблицу кубов чисел от 1 до N. ");
int n, i = 1;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до N: ");
while (i <= n)
{
    Console.WriteLine(i * i * i);
    i++;
}
