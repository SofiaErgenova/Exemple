
// Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных числе в массиве.

/* int[] CreateRandomArray(int start, int end, int arrLength)
{
    int[] arr = new int [arrLength];
    for(int i = 0; i < arrLength; i++)
    {
        arr[i]= new Random().Next(start, end + 1);
    }
    return arr;
}
int [] threeArr = CreateRandomArray(100,999,10);

void PrintArray(int[] col)
{
    Console.Write("[");
    for(int i = 0; i < col.Length-1; i++)
    {
        Console.Write(col[i] + ",");
    }
    Console.Write(col[col.Length-1] + "]");
}
 PrintArray(threeArr);

int count = 0;
for(int i = 0; i < threeArr.Length; i++)
    {
        if(threeArr[i]%2 == 0)
        {
            count = count + 1;
        }
    }
Console.WriteLine(count);
 */

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечетных позициях.

/* int[] CreateRandomArray(int start, int end, int arrLength)
{
    int[] arr = new int [arrLength];
    for(int i = 0; i < arrLength; i++)
    {
        arr[i]= new Random().Next(start, end + 1);
    }
    return arr;
}
int [] arrayRandom = CreateRandomArray(1,999,10);

void PrintArray(int[] col)
{
    Console.Write("[");
    for(int i = 0; i < col.Length-1; i++)
    {
        Console.Write(col[i] + ",");
    }
    Console.Write(col[col.Length-1] + "]");
}
 PrintArray(arrayRandom);

 int i = 1; 
 int sum = 0;
 while (i < arrayRandom.Length)
    {
        sum = sum + arrayRandom[i];
        i = i + 2;
    }
 Console.WriteLine(sum); */


// Задайте массив из вещественных чисел. Найдите разницу между максимальным и минимальным
// элементами массива. 
double[] CreateRandomArray(int start, int end, int arrLength)
{
    double[] arr = new double [arrLength];
    for(int i = 0; i < arrLength; i++)
    {
        arr[i]= new Random().Next(start, end + 1);
    }
    return arr;
}

void PrintArray(double[] col)
{
    Console.Write("[");
    for(int i = 0; i < col.Length-1; i++)
    {
        Console.Write(col[i] + ",");
    }
    Console.Write(col[col.Length-1] + "]");
}
 
 double [] arrayRandom = CreateRandomArray(1,99,10);
 PrintArray(arrayRandom);


double max = arrayRandom[0];
double min = arrayRandom[0]; 
 
for(int i = 0; i < arrayRandom.Length; i++)
    {
     if(max < arrayRandom[i])
        {
            max = arrayRandom[i];
        }

    else if (min > arrayRandom[i])
            {
            min = arrayRandom[i];
            } 
    }
     Console.WriteLine($"max = {max}, min = {min}");

     Console.WriteLine($"разница = {max- min}");
