//Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num/10000 == num%10 & (num/1000)%10 == (num/10)%10)
    {
       Console.WriteLine("Это палиндром");
    }
else
    {
        Console.WriteLine("Это не палиндром");
    } */

//Второй способ решения с применением массива

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
    {
        int length = collection.Length;
        int i = 0;
        while(i < length)
            {
                collection[i] = num%10;
                num = num/10;
                i++;
            }
    }

int [] array = new int [5];
FillArray(array);

 if(array[0] == array[4] & array[1] == array[3])
    {
       Console.WriteLine("Это палиндром");
    }
else
    {
        Console.WriteLine("Это не палиндром");
    }
   

    //Программа, которая принимет на вход координаты двух точек и находит
    //расстояние между ними в 3Д пространстве
    //

/* Console.WriteLine("Введите координаты точки А: ");
double [] pointA =  new double [3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};

Console.WriteLine("Введите координаты точки B: ");
double [] pointB =  new double [3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};

Console.WriteLine(Math.Sqrt((Math.Pow((pointB[0] - pointA[0]),2) + Math.Pow((pointB[1] - pointA[1]),2)+ Math.Pow((pointB[2] - pointA[2]),2))));
 */
//Задача 22: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

/* Console.WriteLine("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine(); 

while(i <= num)
  {
      Console.WriteLine(Math.Pow(i,3));
      i++;
  }  */