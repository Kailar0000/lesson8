void InputMatrix(int[,,] matrix)
{   
    int c=10;
    for(int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int z = 0; z < matrix.GetLength(1); z++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
            matrix[x, z, y] = c;
            c++;
            }
        }
    }
}


void PrintMatrix(int[,,] matrix)
{
    for(int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int z = 0; z < matrix.GetLength(1); z++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            Console.WriteLine($"{matrix[x, z, y]} {(x, z, y)}");
        }
    }
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while(size[0]*size[1]*size[2]>99)
{
    Console.Write("Значения введены некорректные!\nВведите размер трехмерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[size[0], size[1], size[2]];
int[] sum= new int[size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);

