public class Library1
{
// Метод 1. Создания массива
public static int[] CreateArray(int count)
{
   return new int[count];
}

//Метод 2. Заполнения массива
public static void Fill(int[]array, int min, int max)
{
   for (int i = 0; i < array.Length; i++)
   { 
    array[i] = new Random().Next(min,max);
   }
}

//Метод 3. Печати массива
public static string Print(int[] array)
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


//Метод 4. Решение задачи 29
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


//Метод 5. Решение задачи 25
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
}