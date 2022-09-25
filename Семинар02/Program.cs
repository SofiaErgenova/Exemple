//Задача 1. Напишите программу, которая выводит случайное число из 
//отрезка [10, 99] и показывает наибольшую цифру числа.

 /* int x = new Random().Next(10, 100);
Console.WriteLine(x);
 /* 
Console.WriteLine("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());

int firstNum = num/10;
int secondNum = num%10; 

if (firstNum > secondNum)
{
    Console.WriteLine(firstNum);
}
else 
{
    Console.WriteLine(secondNum);
}
 */

//Задача 2. Выводит случайное трехзначное число и удаляет вторую цифру этого числа. 
/* int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int firstNum = x/100;
int secondNum = x%10; 

Console.WriteLine($"{firstNum}{secondNum}"); */



// Задача 3. На вход два числа и выводит, является ли второе число кратно первому. 
// Если второе число не кратно первому, то выводить остаток.

 /* Console.WriteLine("Введите первое число");
 int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
 int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum%secondNum == 0)
{
    Console.WriteLine("Yes");
}
else
{
    int x = firstNum%secondNum; 
    Console.WriteLine("No," + x);
}
 */

// 4. На вход число и проверяет, является ли оно одновременно кратно 7 и 23.

/* int num = new Random().Next(10, 10000000);
Console.WriteLine(num);

if(num%7 == 0 & num%23 == 0)
{
   Console.WriteLine("Yes");
} 
else
{
  Console.WriteLine("No");  
} */

// 5.  На вход два числа и проверяет, является ли одно число квадратом другого.

/* Console.WriteLine("Введите первое число");
 int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
 int secondNum = Convert.ToInt32(Console.ReadLine());

 if(firstNum == secondNum*secondNum || secondNum == firstNum*firstNum)
 {
    Console.WriteLine("Одно число является квадратом другого");
 }
 else
 {
    Console.WriteLine("Одно число не является квадратом другого числа");
 } */


 //7. Напишите программу, которая принимает на вход координаты точки (X и Y), 
 //причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
 //четверти плоскости, в которой находится эта точка.

/* Console.WriteLine("Введите координату х:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y:");
int y = Convert.ToInt32(Console.ReadLine());

if(x>0 & y>0)
{
   Console.WriteLine("1 четверть"); 
}

else if(x>0 & y<0)
    {
        Console.WriteLine("2 четверть"); 
    }

else if(x<0 & y<0)
    {
        Console.WriteLine("3 четверть"); 
    }

else if(x<0 & y>0)
    {
        Console.WriteLine("4 четверть"); 
    } */


 //Задача 18: Напишите программу, которая по заданному номеру четверти, 
 //показывает диапазон возможных координат точек в этой четверти (x и y).

/* Console.WriteLine("Введите число от 1 до 4"); 
int numOfQuarter = Convert.ToInt32(Console.ReadLine());

if(numOfQuarter == 1)
  { 
    Console.WriteLine("x > 0, y > 0"); 
  }
else if(numOfQuarter == 2)
    { 
        Console.WriteLine("x > 0, y < 0"); 
    }

else if(numOfQuarter == 3)
      { 
        Console.WriteLine("x < 0, y < 0"); 
      }

else if(numOfQuarter == 4)
      { 
        Console.WriteLine("x < 0, y > 0"); 
      }

else if(numOfQuarter > 4 | numOfQuarter < 0)
      { 
        Console.WriteLine("Введён несуществующий номер четверти"); 
      } */

 //Задача 21: Напишите программу, которая принимает на вход 
 //координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

// Sqrt ((x2 - x1)^2 + (y2 -y1)^2)
/* Console.WriteLine("Введите координаты точки А: ");
double [] pointA =  new double [2] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};

Console.WriteLine("Введите координаты точки B: ");
double [] pointB =  new double [2] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};

Console.WriteLine(Math.Sqrt((Math.Pow((pointB[0] - pointA[0]),2) + Math.Pow((pointB[1] - pointA[1]),2)))); */



//Задача 22: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число"); 
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i <= num)
  {
      Console.WriteLine(Math.Pow(i,2));
      i++;
  } 