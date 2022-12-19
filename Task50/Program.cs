//  Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты элемента через пробел: ");
string str = Console.ReadLine();
string[] strArr = str.Split();
int x = int.Parse(strArr[0]);
int y = int.Parse(strArr[1]);

int[,] arr = GetArray(rows, columns);
PrintArray(arr);


if (ExistElement(arr, x, y)){
    Console.WriteLine($"Значение элемента под номером {x}, {y} = {arr.GetValue(x, y)}");
}
else Console.WriteLine($"Элемента под номером {x}, {y} в массиве нет");

bool ExistElement (int[,] array, int x, int y){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
         if (i == x && j == y) return true;
        }
    }
    return false;
}


int[,] GetArray (int m, int n){
    int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(1, 100);
            }
        }
    return result;
}

void PrintArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}