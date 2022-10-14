
/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8" */


/* Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

string NumericalSequence(int A, int B)
{
    if(A > 0 & A <= B) 
    return NumericalSequence(A,B-1) + $"{B}";
    else return String.Empty;

}

Console.WriteLine(NumericalSequence(M,N)); */


/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/* Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int A, int B)
{
    if(A > 0 & A < B) 
    return A + SumNumbers(A+1,B);
    else return A;
}

Console.WriteLine(SumNumbers(M,N)); */


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29 */


 int Ackerman(int m,int n)
 {
    if(m == 0) 
        {
            return n+1;
        }
    if(m > 0 & n == 0) 
        {
            return Ackerman(m-1, 1);
        }
    if (m > 0 & n > 0)
        {
            return Ackerman(m-1,Ackerman(m,n-1));
        }
    else return Ackerman(m,n);
}

Console.WriteLine(Ackerman(2,3)); 
