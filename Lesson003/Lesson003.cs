int i = 23432;                  //Задача 19.Напишите программу, 
                                //которая принимает на вход пятизначное число и
                                //проверяет, является ли оно палиндромом.
int count = 4;
int number = 0;
int result = 0;
while(count >= 0)
{
    int m = (int)Math.Floor(Math.Log10(i)) - count;
    int u = (int)Math.Pow(10,m);
    number = i / u % 10;
    result += (int)Math.Pow(10,count) * number;
    count = count - 1;
}
if(i == result)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}


int[] A = {0,0};                            //Задача 21.Напишите программу, 
                                            //которая принимает на вход координаты двух точек и
                                            //находит расстояние между ними в 2D пространстве.
int[] B = {1,1};
double distance = Math.Sqrt(Math.Pow((B[0] - A[0]),2) + Math.Pow((B[1] - A[1]),2));
Console.WriteLine(distance);



int max = 10;                               //Задача 23.Напишите программу, 
                                            //которая принимает на вход число (N) и 
                                            //выдаёт таблицу кубов чисел
int count2 = 1;
while(count2 <= max)
{
    double cub = Math.Pow(count2,3);
    Console.WriteLine(cub);
    count2++;
}