int[, ] CreateArray(int[, ] array)
{
     for (int i =0; i < array.GetLength(0); i++)
     {
        for(int j=0; j< array.GetLength(1); j++)
        {  Console.WriteLine("Введите элемент массива: ");
           int x = Convert.ToInt32(Console.ReadLine());
           array[i,j] = x;
        
        }
        Console.WriteLine();
     }
    for (int i =0; i < array.GetLength(0); i++)
     {
        for(int j=0; j< array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + "\t"); // \t (табуляция)
        }
        Console.WriteLine();
     }
     return array;
}


void CheckArray(int i, int j, int[, ] array)
{
    if (i < array.GetLength(0) && j < array.GetLength(1) && i >= 0 && j >= 0)
        Console.WriteLine(array[i,j]);
    else
        Console.WriteLine("Данного элемента нет в массиве!");
}
Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа на вход принимает позиции элемента в двумерном массиве");
Console.WriteLine("и возвращает значение этого элемента или же указание,");
Console.WriteLine("что такого элемента нет. ");
Console.WriteLine("Давайте зададим массив ");
Console.WriteLine("например размер массива 4 на 4 ");
int[, ] array = new int[4, 4];
array = CreateArray(array);
Console.WriteLine("Введите номер позиции элемента по горизонтали ");
Console.WriteLine("нумерация начинается с 0 ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер позиции элемента по вертикали ");
Console.WriteLine("нумерация начинается с 0 ");
int j = Convert.ToInt32(Console.ReadLine());
CheckArray(i,j, array );