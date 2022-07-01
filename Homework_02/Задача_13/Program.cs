Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа, которая выводит третью цифру заданного числа ");
Console.WriteLine("Или сообщает, что третьей цифры нет ");
Console.WriteLine("Введите число : ");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 100 == n)
   Console.WriteLine("Третьей цифры нет ");
else
{
   Console.WriteLine("Третья цифра числа : ");
   Console.WriteLine(Convert.ToString(n)[2]); 
}
