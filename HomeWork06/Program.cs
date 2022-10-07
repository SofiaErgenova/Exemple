// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше нуля ввел пользователь.

/* Console.WriteLine("Введите числа:  ");
string numbers = Convert.ToString(Console.ReadLine());

int countZero = 0;

if(numbers[0]  == '0')
    {
         countZero = countZero + 1;
    }

if (numbers[numbers.Length -1] == '0' & numbers[numbers.Length -2] == ' ')
    {
       countZero = countZero + 1; 
    }

for(int i = 1; i < numbers.Length-1; i++)
{
    if(numbers[i]  == '0' & numbers[i-1] == ' ' & numbers[i+1]  == ' ')
    {
        countZero = countZero + 1;
    }
}

Console.WriteLine($"Количество нулей: {countZero}");

int countMinus = 0;

for(int i = 0; i < numbers.Length-1; i++)
{
    if(numbers[i]  == '-')
    {
        countMinus = countMinus + 1;
    }
}
Console.WriteLine($"Количество отрицательных чисел: {countMinus}");

int countProbel = 0;
for(int i = 0; i < numbers.Length-1; i++)
{
    if(numbers[i]  == ' ')
    {
        countProbel = countProbel + 1;
    }
}
Console.WriteLine($"Количество всех чисел: {countProbel + 1}");
Console.WriteLine($"Количество положительных чисел: 
                {(countProbel + 1) - countMinus - countZero}");

 */
// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1*x + b1, y = k2*x + b2:; 
//значения b1, k1, b2, k2 задаются пользователем.
Console.WriteLine("Введите значение b1:  ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2:  ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1:  ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2:  ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2)
 {
    if (b1 == b2)
         {Console.WriteLine("Прямые совпадают");}
    else {Console.WriteLine("Прямые паралеллельны");}
 }
else
{double x = (b2 - b1)/(k1 - k2);
double y = k1*x + b1;

Console.WriteLine($"Точка пересечения:({x};{y})");}
