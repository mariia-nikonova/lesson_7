using System.Globalization;

Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
Random rand = new Random();

int[,] CreateArray(int s, int k)      //заполнение массива случайными натуральными числами
{
    int[,] array = new int [s, k];
    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i,j] = rand.Next(10,99);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] myArray=CreateArray(m,n);

void average (int [,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for(int i = 0; i < n; i++)
    {
        float sum = 0;
        float avg = 0;
        for (int j=0; j < m ; j++)
        {
            sum=sum+array[j,i];
        }
        avg=sum/m;
        Console.Write($"Среднее арифметическое элементов массива в cтолбце {i}: ");
        Console.WriteLine("{0,6:F2}",avg);
    }
}
average (myArray);
