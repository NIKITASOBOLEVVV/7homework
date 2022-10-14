//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//что не так то? задали массив, бежим по нему заполняем числами и выводим
/*Console.WriteLine("enter to numers");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,]matrix = new int[m,n];
for (int i=0; i< m; i++)
{
    for (int j=0; j<n; j++)
    {
        matrix(i,j)=new Random(). Next (1,100);
        Console.Write($"{matrix[i,j]}");
    }
    Console.WriteLine();
}*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет. 
//как поставить пробелы между числами в матрице?
/*void FillArray(int[,] matr)
{
for (int i=0; i <matr.GetLength(0); i++)
{
    for (int j=0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(0,10);
    }
   }
}
int[,]matrix = new int[3,3];
FillArray(matrix);
for (int i=0; i <matrix.GetLength(0); i++)
{
    for (int j=0; j <matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
     Console.WriteLine();
}
Console.Write("введите номер строки ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер стобца ");
int n = Convert.ToInt32(Console.ReadLine());
if (m <= matrix.GetLength(0) & n <= matrix.GetLength(1) )
{
Console.Write($" строка {m} столбец {n} находится число {matrix[m,n]}");
}
else 
{
    Console.Write("нет такой позиции");
}*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] matr)
{
for (int i=0; i <matr.GetLength(0); i++)
{
    for (int j=0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(0,10);
    }
   }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,]matrix = new int[m,n];
FillArray(matrix);
for (int i=0; i <matrix.GetLength(0); i++)
{
    for (int j=0; j <matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
     Console.WriteLine();
}
Console.WriteLine("enter number");

double []sum  = new double [n];
for(int j=0, k=0; j<n; j++)
{
    double Summ =0;
    for (int i=0; i<m; i++)
    {
        Summ+=matrix[i,j];
    }
sum[k] = Math.Abs(Summ/m);
Console.Write($"{sum[k]} ");
k++;
}

