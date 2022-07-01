Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа определяет на какой день");
Console.WriteLine("улитка доползет до вершины шеста.");
Console.WriteLine("Улитка ползёт по вертикальному шесту высотой h метров");
Console.WriteLine("поднимаясь за день на a метров,");
Console.WriteLine("а за ночь спускаясь на b метров.");
int h, a, b;
Console.WriteLine("Введите длину шеста - h : ");
h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во метров, которое улитка ползет вверх днем - a : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во метров, которое улитка сползает ввниз ночью - b : ");
b = Convert.ToInt32(Console.ReadLine());
int day = 1; 
h = h - a;
while (h > 0)
{
 h = h - a + b;
 day = day + 1;
}
Console.Write("Улитка доползет до вершины шеста на ");
Console.Write(day);
Console.Write("-й день");
