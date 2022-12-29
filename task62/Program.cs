void InputMatrix(int[,] matrix)
{   
    int i=0;
    int j=0;
    int t=0;
    int c=1;
    int x=matrix.GetLength(1);
    int y=matrix.GetLength(0);
    while(c<matrix.GetLength(0)*matrix.GetLength(1))
    {
        for (j = 0+t; j < x-t; j++)
        {
            matrix[i, j] =c;
            c++;
        }
        for (i = 1+t; i < y-t; i++)
        {
            matrix[i, j] =c;
            c++;
        }
        j = x-t-1;
        for (j > t; j-1)
        {
            matrix[i, j] =c;
            c++;
        }
        i = y-t;
        for (i > t+1; i-1)
        {
            matrix[i, j] =c;
            c++;
        }
        t++;
    }
    
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);