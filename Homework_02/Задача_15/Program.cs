Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа принимает на вход цифру ");
Console.WriteLine("Обозначающую день недели ");
Console.WriteLine("И проверяет, является ли этот день выходным ");
Console.WriteLine("Введите цифру : ");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n >=1 && n <= 7)
{
if  (n == 6 || n == 7 )
{
  Console.WriteLine("Сегодня выходной день! ");
}
else
{
   Console.WriteLine("Сегодня рабочий день! ");
}
}
else
{
      Console.WriteLine("Не является днем недели ");
}
 

