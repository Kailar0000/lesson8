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

void InputSumMatrix(int[,] matrix, int[] sum)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i]=sum[i]+matrix[i,j];
        }
    }
}
void ReleaseMatrix(int[] sum)
{
    int min=sum[0];
    int x=0;
    for (int i = 1; i < sum.GetLength(0); i++)
    {
        if(min>sum[i])
        {
            min=sum[i];
            x=i;
        }
    }
    Console.Write($"Строки с наименьшей суммой элементов:{x}");
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] sum= new int[size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
InputSumMatrix(matrix,sum);
ReleaseMatrix(sum);
