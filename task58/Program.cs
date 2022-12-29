void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] A, int[,] B, int[,] C)
{
      for(int i = 0; i <A.GetLength(0) ; i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
            C[i, j] = A[i,j]*B[i,j];
    }
  
}

Console.Clear();
Console.Write("Введите размер матриц: "); // размеры матриц должны быть одинаковые
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] A = new int[size[0], size[1]];
int[,] B = new int[size[0], size[1]];
int[,] C= new int[size[0], size[1]];
InputMatrix(A);
InputMatrix(B);
Console.WriteLine("Начальный массив:");
PrintMatrix(A);
PrintMatrix(B);
ReleaseMatrix(A, B, C);
PrintMatrix(C);