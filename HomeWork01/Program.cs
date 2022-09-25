/* double distance = 10000;
int count = 0;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double temp = 0;


while (distance > 10)
{
    if (friend == 1)
    {
        temp = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else 
    {
        temp = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
distance = distance - (firstFriendSpeed + secondFriendSpeed) * temp;
count = count + 1;
}
Console.WriteLine(count);

 */


// Задача 1. На вход принимает два числа, на выход выдает большее число
/* 
 Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if(firstNum > secondNum)
{
    Console.WriteLine("Наибольшее число:" + firstNum);
}
else
{
    Console.WriteLine("Наибольшее число:" + secondNum);
}
 */

 //Задача 2. Принимает три числа, выдает наибольшее.

/* Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

if(firstNum > secondNum)
{
    if(firstNum > thirdNum)
    {
     Console.WriteLine("Наибольшее число:" + firstNum);   
    }
    else
    {
        Console.WriteLine("Наибольшее число:" + thirdNum);
    }
}
else
{
    if(secondNum > thirdNum)
    {
       Console.WriteLine("Наибольшее число:" + secondNum); 
    }
    else
    {
       Console.WriteLine("Наибольшее число:" + thirdNum);
    }
}

 */


 //Задача 3. Принимает число и говорит, четное ли оно.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
   Console.WriteLine("Четное число");  
}
else
{
    Console.WriteLine("Нечетное число");  
}


 // Задача. Принимает число (N), на выходе выдает все четные числа от 1 до N
/* 
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i < num+1)
{
if(i % 2 == 0)
{
  Console.WriteLine(i); 
}
 i = i + 1;
}
  */
