double a, b, c; 
Console.WriteLine("Приветствую! ");
Console.WriteLine("Это программа возведения числа в степень");
Console.WriteLine("Введите число, которое вы хотите возвести в степень: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести число "+a+":");
b = Convert.ToDouble(Console.ReadLine());
c = Math.Pow(a, b);
Console.WriteLine("Готово! " +a+ " в степени "+b+" равно: " +c+ "!");
