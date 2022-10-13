// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива
/*  void FillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matrix)   
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");  
        }
    Console.WriteLine();
    }
}

int [,] matrix = new int [5,4];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

int temp = 0;

for(int i = 0; i < matrix.GetLength(0); i++)
    {
    for(int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for(int k = 0; k < matrix.GetLength(1) -1 - j; k++)

            {
            if(matrix[i,k] < matrix[i,k+1])
            {
                temp = matrix[i,k];
                matrix[i,k] = matrix[i,k+1];
                matrix[i,k+1] = temp;
            }
            }
        }
    }


PrintArray(matrix);
 */

/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */
/* void FillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matrix)   
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");  
        }
    Console.WriteLine();
    }
}

int [,] matrix = new int [3,4];
FillArray(matrix);
PrintArray(matrix);

if(matrix.GetLength(0) != matrix.GetLength(1))
{Console.WriteLine("Это прямоугольный массив");}
else{Console.WriteLine("Это квадратный массив");}

int [] sumArray = new int [matrix.GetLength(0)];
int s = 0;
int sum = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
    {
    for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];  
        }
        sumArray[s]= sum;
        s++;
        sum = 0; 
    }

int min = sumArray[0];
int iMin = 0;
for(int i = 0; i < sumArray.Length; i++)
    {
        if(sumArray[i] < min)
        {
            min = sumArray[i];
            iMin = i; 
        }
    }
Console.WriteLine($"Cтрока с наименьшей суммой элементов - '{iMin}'. Сумма элементов: {min}");

 */


/* Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.*/

void FillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matrix)   
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");  
        }
    Console.WriteLine();
    }
}

int [,] firstMatrix = new int [3,4];
FillArray(firstMatrix);
PrintArray(firstMatrix);

Console.WriteLine();

int [,] secondMatrix = new int [4,3];
FillArray(secondMatrix);
PrintArray(secondMatrix);

Console.WriteLine();

int [,] multMatrix = new int [firstMatrix.GetLength(0),secondMatrix.GetLength(1)];
int sum = 0;
int mult = 0;

for(int a = 0; a < firstMatrix.GetLength(0); a++)
    {
        for(int b = 0; b < secondMatrix.GetLength(1); b++)
            {
                for( int i = 0; i < firstMatrix.GetLength(1); i++)
                    {
                        mult = firstMatrix[a,i]*secondMatrix[i,b];
                        sum = sum + mult;
                    }
            multMatrix[a,b] = sum;
            sum = 0;  
            mult = 0;    
            }
    }               

Console.WriteLine($"Произведение матриц: ");
PrintArray(multMatrix);



 /* Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя 
индексы каждого элемента.
 */

/* void FillArray(int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
           {
            for(int z = 0; z < matrix.GetLength(2); z++)
            {
            matrix[i, j,z] =  new Random().Next(10,100);
            }
           }
    }
}
void PrintArray(int[,,] matrix)   
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
             for(int z = 0; z < matrix.GetLength(2); z++)
             {
             Console.Write($"{matrix[i,j,z]}[{i},{j},{z}] "); 
             } 
        }
    Console.WriteLine();
    }
}
int [,,] matrix = new int [4,2,3];
FillArray(matrix);
PrintArray(matrix);
 */


/* Заполните спирально массив 4 на 4 */