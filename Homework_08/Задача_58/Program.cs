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


void CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine();
    Console.WriteLine("Произведение двух матриц: ");
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write(result[i, j] + " \t");
        }
        Console.WriteLine();
        
    }
}

Console.WriteLine("Приветствую!");
Console.WriteLine("Эта программа находит произведение двух матриц");
Console.WriteLine("Зададим две матрицы: ");
CheckMatrix(CreateArray(4, 4), CreateArray(4, 4));
