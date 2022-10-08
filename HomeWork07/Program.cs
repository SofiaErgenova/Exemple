/* Задайте двумерный массив размером mxn, заполненный
случайными вещественными числами */

/* void FillArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] =  new Random().Next(1,9);
        }
    }
}
void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} "); 
        }
    Console.WriteLine();
    }
}

double [,] matrix = new double [3,4];
FillArray(matrix);
PrintArray(matrix);
 */

/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет. */

 void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] =  new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matr)   
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");  
        }
    Console.WriteLine();
    }
}

int [,] matrix = new int [5,6];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Введите номер строки (нумерация с нуля): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца (нумерация c нуля): ");
int n = Convert.ToInt32(Console.ReadLine());

if( m < matrix.GetLength(0)& n < matrix.GetLength(1))
{Console.WriteLine("Искомый элемент: " + matrix[m,n]);}
else{Console.WriteLine("Элемента нет");} 


/* Задайте двумерный массив из целых чисел. Найдите
среднее арифметическое элементов в каждом столбце.  */

/*  void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] =  new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matr)   
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");  
        }
    Console.WriteLine();
    }
}

int [,] matrix = new int [3,4];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Среднее арифметическое в столбцах: ");
double sum = 0;
for(int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];  
        }
    Console.Write(sum/matrix.GetLength(0));  
    Console.WriteLine();
    sum = 0; 
    } */
