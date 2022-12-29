void InputMatrix(int[,] matrix)
{   
    int i=0;
    int j=0;
    int c=1;
    int x=matrix.GetLength(1);
    while(c<matrix.GetLength(0)*matrix.GetLength(1))
    {
    matrix[i, j] = c;
    if (i <= j + 1 && i + j < x - 1)
        j++;
    else if (i < j && i + j >= x - 1)
        i++;
    else if (i >= j && i + j > x - 1)
        j--;
    else
        i--;
    c++;
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
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size, size];
InputMatrix(matrix);
PrintMatrix(matrix);