Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа сравнивает два введенных числа ");
Console.WriteLine("И определяет наибольшее и наименьшее ");
Console.WriteLine("Для этого вам необходимо ввести два числа ");
Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (a < max ) min = a;
if (b < max ) min = b;

Console.Write("наибольшее число = ");
Console.WriteLine(max);
Console.Write("наименьшее число = ");
Console.WriteLine(min);