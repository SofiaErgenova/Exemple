// Напишите программу, которая на вход принимает число 
// и выдает его квадрат

//Console.Clear();
//Console.Write("ВВедите число: ");

//int num = Convert.ToInt32(Console.ReadLine());

//int result = num * num;
//Console.WriteLine("Результат: " + result);

//if (num == result)
//{
//  Console.WriteLine("Да");  
//}
//else
//{
 //   Console.WriteLine("Нет");  
//}


// Является ли первое число квадратом второго?

/* Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if(firstNum == secondNum * secondNum)
{
   Console.WriteLine("Да");   
}
else
{
 Console.WriteLine("Нет");      
} 
 */


//Название дня недели по номеру

/* Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num == 1)
{
  Console.WriteLine("Понедельник");  
}
if(num == 2)
{
   Console.WriteLine("Вторник");  
}
if(num == 3)
{
   Console.WriteLine("Среда");  
}
if(num == 4)
{
   Console.WriteLine("Четверг");  
}
if(num == 5)
{
   Console.WriteLine("Пятница");  
}
if(num == 6)
{
   Console.WriteLine("Суббота");  
}
if(num == 7)
{
   Console.WriteLine("Воскресенье");  
}
if(num > 7)
{
   Console.WriteLine("Ошибка");  
} */

//На вход принимает одно число (N), а на выход все целые числа от -N до N

Console.WriteLine("ВВедите число"); 
int N = Convert.ToInt32(Console.ReadLine());
int i = - N;
while(i < N+1)
{
  Console.WriteLine(i);   
  i = i + 1;
} 


//ВВести трехзначное число, на выходе получить последнюю цифру

Console.WriteLine("ВВедите трехзначное число"); 
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат:" + N%10); 





