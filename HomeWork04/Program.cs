

 //Напишите программу, которая принимает на вход два числа (А и В) и 
 //возводит число А в натуральную степень В

/* Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int mult = 1;
while(b > 0)
    {
    mult = mult*a;
    b = b-1;
    }
Console.WriteLine(mult);   
 */


 //Напишите программу, которая принмает на вход число, а выдает
 // сумму цифр в числе

Console.WriteLine("Введите число: ");
string numbers = Convert.ToString(Console.ReadLine());
int sum = 0;
for(int i=0; i< numbers.Length; i++)
{
    sum = sum + Convert.ToInt32(Convert.ToString(numbers[i]));
}
Console.WriteLine(sum); 
 


 //Нпишите программму, которая задает массив из 8 элементов и выводит их на экран

 /* int [] array = new int [8];
void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    Console.Write("[");
     while(i < count-1)
    {
        array[i] = new Random().Next(1,1000000000);
        Console.Write($"{array[i]}, ");
        i++;
    }
    Console.WriteLine($"{array[count-i]}]");
}
PrintArray(array);

 */