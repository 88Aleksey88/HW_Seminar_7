void InputArray (double [,] array)
{
    for (int i = 0 ; i < array.GetLength(0) ; i ++)
        {
            for (int j = 0 ; j < array.GetLength(1) ; j ++)
            {
                array[i,j] = Math.Round(new Random().NextDouble()*(50+50)-50, 2);;
                Console.Write($"{array[i,j]} \t");
            }
            Console.WriteLine();
        }
}
Console.Clear();
Console.Write("Введите размер матрицы через пробел: ");
int [] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
double [,] array = new double [size[0], size[1]];
InputArray(array);