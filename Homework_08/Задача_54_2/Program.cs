int[,] CreateArray(int m, int n)
{
    int[,] matrix1 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write(matrix1[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}
CreateArray(4, 4);