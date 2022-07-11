Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа принимает на вход число");
Console.WriteLine("И выдаёт сумму цифр в числе. ");
Console.WriteLine("Введите число: ");
int n, sum;
n = Convert.ToInt32(Console.ReadLine());
sum = 0;
while (n != 0) 
{
    sum += n % 10;
    n /= 10;

}
Console.Write("Сумма цифр в числе: ");
Console.Write(sum);