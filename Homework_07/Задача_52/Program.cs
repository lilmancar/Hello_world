int[, ] CreateArray(int[, ] array)
{
     for (int i =0; i < array.GetLength(0); i++)
     {
        for(int j=0; j< array.GetLength(1); j++)
        {  
           int x = new Random().Next(1,100);
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

void AvgArray(int[, ] array)
{
    Console.WriteLine();
 for(int i =0; i < array.GetLength(0);i++)
 {
    double avg = 0;
    for(int j =0; j < array.GetLength(1);j++)
    {
        avg = avg + array[j,i];
    }
    Console.WriteLine(i + 1 + " столбик: " + avg/array.GetLength(0));
 }
}
Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа находит среднее арифметическое элементов в каждом столбце. ");
Console.WriteLine("Давайте зададим массив из целых рандомных чисел. ");
Console.WriteLine("например размер массива 4 на 4 ");
int[, ] array = new int[4, 4];
array = CreateArray(array);
AvgArray(array);