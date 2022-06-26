Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа показывает все четные числа  ");
Console.WriteLine("От 1 до введенного числа ");
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);