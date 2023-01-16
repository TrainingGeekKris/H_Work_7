// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//Console.WriteLine("Введите количество строк");
//int rows= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов");
//int columns= Convert.ToInt32(Console.ReadLine());

//double [,] matrix = new double[rows,columns];

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i,j]= Convert.ToDouble(new Random().Next(-10,10))/10;
//        Console.Write(matrix[i,j]+"   ");
//    }
//    Console.WriteLine();
//}

//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение этого элемента
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//Console.WriteLine("Введите номер строки");
//int rows= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите номер столбца");
//int columns= Convert.ToInt32(Console.ReadLine());

//int [,] matrix = new int[5,5];

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i,j]= new Random().Next(10);
//        Console.Write(matrix[i,j]+" ");
//    }
//     Console.WriteLine();
//}
//if (rows<=matrix.GetLength(0)&&columns<=matrix.GetLength(1))
//{
//    Console.Write(matrix[rows-1,columns-1]);
//}
//else
//{
//    Console.Write("Такого числа в массиве нет");
//}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int rows= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns= Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]= new Random().Next(10);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / rows;
    
    Console.Write(avarage + "; ");
}
