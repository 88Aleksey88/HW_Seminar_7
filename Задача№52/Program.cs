void InputArray (int [,] array)
{
    for (int i = 0 ; i < array.GetLength(0) ; i ++)
        {
            for (int j = 0 ; j < array.GetLength(1) ; j ++)
            {
                array[i,j] = new Random().Next(1,10);
                Console.Write($"{array[i,j]} \t");
            }
            Console.WriteLine();
        }
}
void AverageColumn (int [,] array)
{
    double sum = 0;
    for (int j = 0 ; j < array.GetLength(1) ; j++)
        { 
        for (int i = 0 ; i < array.GetLength(0) ; i ++) sum = sum + array[i,j];
        Console.Write($"{Math.Round((sum / array.GetLength(0)), 2)}; ");
        }
}
Console.Clear();
Console.Write("Введите размер матрицы через пробел: ");
int [] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int [,] array = new int [size[0], size[1]];
InputArray(array);
AverageColumn (array);