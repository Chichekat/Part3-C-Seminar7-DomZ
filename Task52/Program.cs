// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, columns);
PrintArray(arr);
double[] resultAverage = AverageInColumns(arr);
Console.WriteLine($"{String.Join("; ",resultAverage)}");


double[] AverageInColumns (int[,] array){
    double[] average = new double[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            double sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
              sum = sum + array[j, i];  
            }
            average[i] = Math.Round(sum/array.GetLength(1), 1);
        }
    return average;
}

int[,] GetArray (int m, int n){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}