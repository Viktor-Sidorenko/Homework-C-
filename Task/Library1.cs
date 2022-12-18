public class Library1
{
// Метод 1. Создания массива.
public static int[] CreateArray(int count)
{
   return new int[count];
}

//Метод 2. Заполнения массива.
public static void Fill(int[]array, int min, int max)
{
   for (int i = 0; i < array.Length; i++)
   { 
    array[i] = new Random().Next(min,max);
   }
}

//Метод 3. Печать массива для задачи 29.
public static string PrintTask29(int[] array)
{
   string output = String.Empty;
   for(int i = 0; i < array.Length;i++)
   {
   if (array[i] > 9 & array[i] < 15)
   {
      if (array[i] == 10)  output += $"A";
      if (array[i] == 11)  output += $"B";
      if (array[i] == 12)  output += $"C";
      if (array[i] == 13)  output += $"D";
      if (array[i] == 14)  output += $"E";
   }
   else
   {
      output += ($"{array[i]}");
   }
   }
   return output;
}


//Метод 4. Решение задачи 29.
public static int Task29(int[] array)
{
   int u = 0;
   int result = 0; 
   int size = array.Length;
   for(int i = size - 1; i >= 0;i--)
   {
      int t = array[i];
      result += (int)Math.Pow(15,u) * t;
      u++;
   }
   return result;
}


//Метод 5. Решение задачи 25.
public static int Task25(int a, int b)
{
   int result = 1;
   int count = 1;                                      
   while (count <= b)
   {
      result = result * a;
      count = count + 1; 
   }
   return result;
}


//Метод 6. Решение задачи 27
public static int Task27(int i)
{
Console.WriteLine("Задача 27");     
Console.WriteLine($"Число: {i}");                       
int result2 = 0;
int count2 = 0;
while (count2 < countnumber(i))                             
{
    int m = (int)Math.Floor(Math.Log10(i)) - count2;   
    int u = (int)Math.Pow(10,m);
    int number = i / u % 10;     
    result2 = number + result2;
    count2 = count2 + 1; 
}
return (result2);
}


//Метод 7. Кол-во цифр в числе.
public static int countnumber(int p)  
{
int t = 0; 
int y = 10;
while (p > 0)  
{
   p = p / y;   
   t = t + 1;   
}
return t;   
}

//Метод 8. Решение задачи 34 
public static string PrintTask34(int[] array)
{
   Console.WriteLine("Задача 34");
   string output = String.Empty;
   for(int i = 0; i < array.Length;i++)
   {
      output += ($"{array[i],7}");
   }
   output +=(" => ");
   for(int i = 0; i < array.Length;i++)   
    {                                         
      if(array[i] % 2 == 0)
      output += ($"{array[i],4}");
   }
   return output;
}


   
//Метод 9. Решение задачи 36.   
public static int Task36(int[] array)
{
int result = 0;
for(int i = 1; i < array.Length;i = i + 2)    
{
   result += array[i];
}
return result;
}

//Метод 10. Печать массива.
public static string Print(int[] array)
{
   string output = String.Empty;
   for(int i = 0; i < array.Length;i++)
   {
     {
         output += ($"{array[i],6}");
     }
   }
   return output;
}

//Метод 11.Нахождение максимального значения. 
public static double Numbermax(double[] array)
{
   double max = 0;
   for(int i = 0;i < array.Length;i++)
   {
           if (max < array[i])
       {
          max = array[i];
       }
  
   }
return max;
}

//Метод 12.Нахождение минимального значения. 
 public static double Numbermin(double[] array)
{
   double min = array[0];
   for(int i = 0;i < array.Length;i++)
   {
       if (min > array[i])
       {
          min = array[i];
       }
   }
return min;
}
}
