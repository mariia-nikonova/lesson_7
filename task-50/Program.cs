using System.Globalization;

Console.Write("Введите номер позиции в строке элемента в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер позиции в столбце элемента в массиве: ");
int n = int.Parse(Console.ReadLine()!);
Random rand = new Random();
int row = rand.Next(3,9);
int column = rand.Next(3,9);

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
int[,] myArray=CreateArray(row,column);

void search (int [,] array, int s, int k, int r, int c)
{
    if ((r<=s&r>0) & (c<=k&c>0))  
    Console.Write($"Значение элемента с номер строки {r} и номером столбца {c}: {array[r,c]}");
    else Console.Write($"Элемент с таким индексом отсутствует");
}
search (myArray,row,column,m,n);