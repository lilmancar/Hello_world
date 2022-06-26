Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа определяет наибольшее из трех введеных чисел  ");
Console.WriteLine("Для этого вам необходимо ввести три числа ");
Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
int с = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (с > max ) max = с;


Console.Write("наибольшее число = ");
Console.WriteLine(max);
