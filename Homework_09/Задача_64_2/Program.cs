void f(int M, int N)
{
    if (M != (N -1 ))
   {
    f(M -1, N );
    Console.Write(M + " ");
   }   
}
Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа выводит все натуральные числа в промежутке от M до N.");
Console.WriteLine("Допустим M = 5, а N = 1 ");
int M = 5;
int N = 1;
f(M,N);
