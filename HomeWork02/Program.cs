// Программа, которая на вход принимает трехзначное число,
// а на выходе показывает вторую цифру числа

/* Console.WriteLine("Введите трехзначное число");
 int num = Convert.ToInt32(Console.ReadLine());
 int firstNum = num/10; 
 int secondNum = firstNum%10;
 Console.WriteLine("Вторая цифра: "+ secondNum); */


 //Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(Math.Abs(num) < 100)
  {
    Console.WriteLine("Третьей цифры нет");
  }

else 
    while(Math.Abs(num) >= 1000)
         {
            num = num/10;
         }
Console.WriteLine("Третья цифра: " + Math.Abs(num)%10);



// Программа, которая принимает на вход цифру, обозначающую день недели, и
// проверяет является ли этот день выходным. 

/* Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 6 | num == 7)
{
    Console.WriteLine("Это выходной день");
}
else if(num>0 & num<6)
     {
       Console.WriteLine("Это не выходной день");

     }
else
{
     Console.WriteLine("Это не день недели");
} */