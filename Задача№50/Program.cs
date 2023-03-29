void InputArray (double [,] array)
{
    for (int i = 0 ; i < array.GetLength(0) ; i ++)
        {
            for (int j = 0 ; j < array.GetLength(1) ; j ++)
            {
                array[i,j] = Math.Round(new Random().NextDouble()*-100+50, 1);;
                Console.Write($"{array[i,j]} \t");
            }
            Console.WriteLine();
        }
}
void FindNumberArray (double [,] array)
{
    Console.Write("Введите строку: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < array.GetLength(0) && j < array.GetLength(1))
    Console.WriteLine($"Число: {array[i,j]}");
    else 
    Console.WriteLine ("Такого элемента нет");
}
Console.Clear();
Console.Write("Введите размер матрицы через пробел: ");
int [] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
double [,] array = new double [size[0], size[1]];
InputArray(array);
FindNumberArray(array);