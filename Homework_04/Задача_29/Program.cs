Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа задаёт массив из 8 элементов");
Console.WriteLine("И выводит их на экран.");
Console.WriteLine("Например от 1 до 100");
Console.WriteLine("Чтобы числа получились не слишком огромные.");
Console.WriteLine("Наш массив: ");
var array = new int[8];
var random = new Random();
for(int index = 0; index < array.Length; index++)
{
	array[index] = random.Next(1,100);
}
foreach(var item in array)
{
	Console.Write(item);
    Console.Write(", ");
}

