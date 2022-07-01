Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа принимает на вход трехзначное число ");
Console.WriteLine("И на выходе показывает вторую цифру этого числа ");
Console.WriteLine("Введите трехзначное число : ");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n < 100 || n > 999)
    Console.WriteLine("Число не трехзначное! ");
else
{
   Console.WriteLine("Вторая цифра числа : ");
   Console.WriteLine(Convert.ToString(n)[1]);
}
