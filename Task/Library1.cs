public class Library1
{
// Метод 1. Созданиe массива.
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

//Метод 13. Ввод
public static int Input1()
 {
  return Convert.ToInt32(Console.ReadLine());
 }

//Метод 14. Создание массива пользователем.
public static void Array1(int[] array1)
{
for(int i = 0;i < array1.Length;i++)
{
 array1[i] = Input1();
}
}

//Метод 15. Задача 41.
public static int Task41(int[] array1)
{
   int g = 0;
   for(int i = 0;i < array1.Length;i++)
   {
      if(array1[i] > 0) g++;
   } 
return g;
}

//Метод 16. Вывод задачи 41.
public static void PrintTask41(int[] array1)
{
for(int i = 0; i < array1.Length;i++)
{
Console.Write($"{array1[i],4}");
}
Console.WriteLine($"  = > {Task41(array1),3}");
}

//Метод 17. Решение задачи 43.
public static double Task43(double b1, double b2, double k1, double k2)
{ 
double x = (-b2 + b1)/(-k1 + k2);
return x;
}
public static double Task431(double b2, double k2, double k1, double b1)
{ 
double y = k2 * Task43(b1,b2,k1,k2) + b2;
return y;
}

//Метод 18. Ввод вещественного двумерного массива

public static double[,] Printtwodimensionalarray(int number1, int number2)
{
   return new double[number1,number2];
}

//Метод 19. Создание вещественного двумерного массива
public static void Createarraytwo(double[,]arraytwo)
{
for(int o = 0;o < arraytwo.GetLength(0);o++)
{
    for(int g = 0;g < arraytwo.GetLength(1);g++)
    {
      arraytwo[o,g] = Math.Round(new Random().NextDouble(),1) + new Random().Next(1,20);
    }
}
}

//Метод 20. Вывод вещественного двумерного массива
public static void Printarraytwo(double[,]arraytwo)
{
for (int x = 0;x < arraytwo.GetLength(0);x++)
{
   for(int m = 0;m < arraytwo.GetLength(1);m++)
   {
     Console.Write($"{arraytwo[x,m],5} ");  
   }
   Console.WriteLine();
}
}

//Метод 21. Ввод целочисленного двумерного массива

public static int[,] Printtwodimensionalarrayinteger(int number1, int number2)
{
   return new int[number1,number2];
}

//Метод 22. Создание целочисленного двумерного массива
public static void Createarraytwointeger(int[,]arraytwo)
{
for(int o = 0;o < arraytwo.GetLength(0);o++)
{
    for(int g = 0;g < arraytwo.GetLength(1);g++)
    {
      arraytwo[o,g] = new Random().Next(1,100);
    }
}
}

//Метод 23. Вывод целочисленного двумерного массива
public static void Printarraytwointeger(int[,]arraytwo)
{
for (int x = 0;x < arraytwo.GetLength(0);x++)
{
   for(int m = 0;m < arraytwo.GetLength(1);m++)
   {
     Console.Write($"{arraytwo[x,m],5} ");  
   }
   Console.WriteLine();
}
}

//Метод 24. Решение задачи 50.
public static void decisiontask50(int[,]arraytwo,int number)
{
bool test = false;
for (int i = 0;i < arraytwo.GetLength(0);i++)
{
   for(int j = 0;j < arraytwo.GetLength(1);j++)
   {
       if (arraytwo[i,j] == number)
            test = true;
   }  
}
if (test)
    Console.WriteLine($"Повторяется число -> {number}");
else
    Console.WriteLine($"{number} -> Нет такого числа");
}

public static void decisiontask52(int[,]arraytwo)
{
for(int j = 0;j < arraytwo.GetLength(1);j++)
{
double y = 0;
double c = 0;
for (int i = 0;i < arraytwo.GetLength(0);i++)
{
   c += arraytwo[i,j]; 
   y = c / arraytwo.GetLength(0);
   
}
Console.WriteLine($"Среднее арифметическое -> {y}");
}
}


//Метод 25. Создание двумерного целочисленного массива
public static int[,] CreateArray2(int str, int rows)
{
    return new int[str,rows];
}

//Метод 26.Заполнение случайного двумерного массива
public static void FillArray2(int[,] array, int min, int max)
{
    int size = array.GetLength(0);
    int sizetwo = array.GetLength(1);
    for(int i = 0; i < size;i++)
    {
        for(int j = 0;j < sizetwo;j++)
        {
    array[i,j] = new Random().Next(min,max);
        }
    }    
}

//Метод 27.Вывод массива построчно
public static void PrintArray(int[,]array)
{
    int size = array.GetLength(0);
    int sizetwo = array.GetLength(1);
   
        
        for(int j = 0;j < sizetwo;j++)
        {
            for(int i = 0;i < size;i++)
            {
            Console.Write($"{array[i,j],5}");
            }
            Console.WriteLine();
        }        
}

//Метод 28.Сортировка
public static void Task54(int[,]array)
{
   for(int i = 0;i < array.GetLength(1);i++)
   { 
for (int j = 0; j < array.GetLength(0) - 1;j++) 
{ 
    for (int k = j + 1; k < array.GetLength(0); k++) 
    { 
        if (array[j,i] < array[k,i]) 
        { 
            int variable = array[k,i]; 
            array[k,i] = array[j,i]; 
            array[j,i] = variable; 
        } 
    }
}
   }
}

//Метод 29.Вывод отсортированного массива
public static void PrintArrayTask54(int[,]array)
{
    int size = array.GetLength(0);
    int sizetwo = array.GetLength(1);
for(int j = 0;j < sizetwo;j++)
{
    for(int i = 0; i < size;i++)
        {    
            Console.Write($"{array[i,j],5}");
        } 
    Console.WriteLine();
}   
}

//Метод 30.Сложение строк двумерного массива и нахождения минимальной строки
public static void Task56(int[,]array,int[]array2)
{
   
   for(int j = 0;j < array.GetLength(1);j++)
   {
    int result = 0;
   for(int i = 0;i < array.GetLength(0);i++)
    { 
        result += array[i,j];
    }
    array2[j] = result;
    Console.Write($"Строка {j + 1} = {result}");
    Console.WriteLine();
   }
   int stroka = 0;
   int min = array2[0];
for(int g = 0; g < array2.Length;g++)
{
    if (min > array2[g]) 
    {
    min = array2[g];
    stroka = g;
    }
}
Console.Write($"Строка наименьшая:{stroka + 1}");
Console.WriteLine(); 
}

//Метод 31. Создание трехмерного массива
public static int[,,] Createarray2(int i,int j,int z)
{
 return new int [i,j,z];
}

//Метод 32. Создание одномерного массива
public static int[] Createarray3(int i)   
{
   return new int[i];
}

//Метод 33. Заполнение трехмерного массива с проверкой на неповторяемость
public static void Task60(int[,,]array,int[]array20)
{
int i2 = 0;
for(int i = 0;i < array.GetLength(0);i++)
   {
       for(int j = 0;j < array.GetLength(1);j++)
       {
           for(int z = 0 ;z < array.GetLength(2);z++)
           {
               int number = 0;
               bool proverka = false;
               while(proverka == false)
               {
                   number = new Random().Next(10,99);
                   proverka = true;
                   for(int x = 0; x < array20.Length;x++)
                       {
                           if(number == array20[x])
                           {
                               proverka = false;
                           }                            
                       }            
               }
               array[i,j,z] = array20[i2] = number;
               i2++;
           }
       }
   }
}

//Метод 34. Вывод трехмерного массива
public static void Printarray3(int[,,]array  )
{
  for(int i = 0;i < array.GetLength(0);i++)
  {
      for(int j = 0;j < array.GetLength(1);j++)
      {
          for(int z = 0;z < array.GetLength(2);z++)
          {
             Console.Write($"{array[i,j,z],4}");             
          Console.Write($"({i}{j}{z})");
          }
      Console.WriteLine(); 
      }
    Console.WriteLine();  
  }
}

//Метод 35. Ввод числа.
public static int InputNum(string input)
{
      Console.Write(input);
      int output = Convert.ToInt32(Console.ReadLine());
      return output;
}

//Метод 36. Вывод числа в обратном порядке
public static void Sequence(int n)
{
   if (n >= 1)
   {
       Console.Write($"{n,4}");
       Sequence(n - 1);
   }
  
}

//Метод 37. Сумма чисел с выводом
public static void Sum(int m, int n, int s)
 {
     s = s + n;
     if (n <= m)
    {
         Console.Write($" {s} ");
         return;
     }
     Sum(m, n - 1, s);
}

public static int Condition(int n,int m)
{
int step = m;

 if (m > n)
 {
     m = n;
     n = step;
 }
return n; 
}

//Метод 38. Функция Аккермана
public static int FunctionAkkerman(int m, int n)
{
   if (m == 0)
   {
      return n + 1;
   }
   else 
      if (n == 0 && m > 0)
         {
            return FunctionAkkerman(m - 1, 1);
         }
      else
         {
         return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
         }
}

}