// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = ReadLineNumber("Введите целое число m:");
int n = ReadLineNumber("Введите целое число n:");

PrintArray(FillArrayRandom(m, n), m, n);




int ReadLineNumber(string str)
{
    Console.WriteLine(str);
    return int.Parse(Console.ReadLine());
}

void PrintArray(double[,] array, int m, int n) {
    for (int i = 0; i < m; i++)
    {
        Console.Write("[");
        for (int j = 0; j < n - 1; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(array[i, n - 1] + "]");
    }
}

double[,] FillArrayRandom(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 1);
        }
    }
    return array;
}