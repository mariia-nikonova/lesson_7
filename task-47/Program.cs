Console.Write("Введите количесво строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количесво столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);
Random rand = new Random();

double[,] CreateArray(int s, int k)      //заполнение массива случайными вещественными числами
{
    double[,] array = new double [s, k];
    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i,j] = rand.NextDouble();
            Console.Write("{0,6:F2}",array[i,j]);
        }
        Console.WriteLine();
    }
    return array;
}

double[,] myArr = CreateArray(m,n);


