int a = 237;                      //Задача 10: Напишите программу, 
                                  //которая принимает на вход трёхзначное число и 
                                  //на выходе показывает вторую цифру этого числа.
int number = a / 10 % 10;
Console.WriteLine(number);

int b = 6578;              //Задача 13: Напишите программу, 
                            //которая выводит третью цифру заданного числа или сообщает, 
                            //что третьей цифры нет.
if (b > 99)
{
   Console.WriteLine(b); 
   int c = (int)Math.Floor(Math.Log10(b)) - 2;
   int d = (int)Math.Pow(10,c);
   int number2 = b / d % 10;
   System.Console.WriteLine(number2);
}
else
{
   Console.WriteLine(b); 
   Console.WriteLine("Третьей цифры нет");    
}


int day = 4;                     //Задача 15: Напишите программу, 
                                 //которая принимает на вход цифру, 
                                 //обозначающую день недели, и проверяет, 
                                 //является ли этот день выходным.
Console.WriteLine(day);
if (day > 0 & day < 8)
{
   if(day == 6 | day == 7)
   {
      Console.WriteLine("Да");
   }
   else
   {
      Console.WriteLine("Нет");
   }   
}
else
{
   Console.WriteLine("Не существует");
}