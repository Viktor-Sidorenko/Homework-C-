using static Library1;

 
public class Task29
{
    public static void Task290()
       { 
          int[] ar = CreateArray(3);
          Fill(ar,0,14);
          Console.WriteLine("Задача 29");
          Console.Write(PrintTask29(ar));
          Console.WriteLine($" => {Task29(ar)}");
       }
}

 
public class Task25
{
    public static void Task250()
      {
         int a = new Random().Next(1,10);
         int b = new Random().Next(1,3);
         Console.WriteLine("Задача 25");
         Console.WriteLine($"{a} ^ {b} = {Task25(a,b)}");
      }
}
 

public class Task27
{
    public static void Task270()
    {
        int x = new Random().Next(1,9000);
        Console.WriteLine($"Сумма = {Task27(x)}");
    }
}


public class Task34
{
   public static void Task340()
     {
         int[] ar = CreateArray(3);
         Fill(ar,100,999);
         Console.WriteLine(PrintTask34(ar));
     }
}


public class Task36
{
    public static void Task360()
    {   

        int[] ar = CreateArray(7);
        Fill(ar,10,250); 
        Console.WriteLine("Задача 36");
        Console.WriteLine($"{Print(ar)} => {Task36(ar)}");
    }
}


public class Task38 
{
public static void Task380()
{
   Console.WriteLine("Задача 38");
   double[] array = {1.2,3.2,3,6.8};
   double difference = Numbermax(array) - Numbermin(array);
   for(int i = 0; i < array.Length;i++)
   {
   Console.Write($"{array[i],6}");
   }
   Console.WriteLine($" => {difference}");
}
}


public class Task41
{
public static void Task410()
   { 
    Console.WriteLine("Задача 41");
    Console.Write("Введите кол-во чисел:");
    int[] array1 = CreateArray(Convert.ToInt32(Console.ReadLine()));
    Array1(array1);
    PrintTask41(array1);
   }
}


public class Task43
{
public static void Task430()
{    
     Console.WriteLine("Задача 43");
     Console.Write("Введите значение b1:");
     double b1 = Double.Parse(Console.ReadLine());
     Console.Write("Введите значение k1:");
     double k1 = Double.Parse(Console.ReadLine());
     Console.Write("Введите значение b2:");
     double b2 = Double.Parse(Console.ReadLine());
     Console.Write("Введите значение k2:");
     double k2 = Double.Parse(Console.ReadLine());
     Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
     Console.WriteLine($" = > ({Task43(b1,b2,k1,k2)},{Task431(b2,k2,k1,b1)})");
}     
}


public class Task47
{
public static void Task470()
{
Console.WriteLine("Задача 47");
double[,] br = Printtwodimensionalarray(3,4);
Createarraytwo(br);
Printarraytwo(br);
}
}

public class Task50
{
    public static void Task500()
    {
      Console.WriteLine("Задача 50");
      Console.Write("Введите число:");
      int number = int.Parse(Console.ReadLine());
      int[,] br = Printtwodimensionalarrayinteger(3,3);
      Createarraytwointeger(br);
      Printarraytwointeger(br);
      decisiontask50(br,number);
    }
}

public class Task52
{
    public static void Task520()
    {
      Console.WriteLine("Задача 52");
      int[,] br = Printtwodimensionalarrayinteger(4,3);
      Createarraytwointeger(br);
      Printarraytwointeger(br);
      decisiontask52(br);
    }
}

public class Task54
{
   public static void Task540()
  {
    Console.WriteLine("Задача 54");
    int[,] number = CreateArray2(3,3);
    FillArray2(number,1,999);
    PrintArray(number);
    Console.WriteLine();
    Task54(number);
    PrintArrayTask54(number);
  } 
}

public class Task56
{
        public static void Task560()
            {
                Console.WriteLine("Задача 56");
                int[,] number = CreateArray2(3,6);
                FillArray2(number,1,999);
                PrintArray(number);
                Console.WriteLine();
                int[] array2 = new int[6]; 
                Task56(number,array2);
            }
}

public class Task60
{
        public static void Task600()
            {
               Console.WriteLine("Задача 60"); 
               int[,,] array = Createarray2(2,2,2);
               int[] array20 = Createarray3(9);
               Task60(array,array20);
               Printarray3(array);
            }
}

public class Task64
{
        public static void Task640()
        {
            Console.WriteLine("Задача 64");
            int n = InputNum("Введите n = ");
            Console.Write($" n = {n} ->");
            Sequence(n);
            Console.WriteLine();
        }
}

public class Task66
{
    public static void Task660()
    {
        Console.WriteLine("Задача 66");
        int m = InputNum("Введите m = ");
        int n = InputNum("Введите n = ");
        Condition(n,m);
        Console.Write($"{m}, {n} ->");
        Sum(m, n, n = 0);
        Console.WriteLine();
    }
}

public class Task68
{
    public static void Task680()
    {
        Console.WriteLine("Задача 68");
        int m = InputNum("Введите m = ");
        int n = InputNum("Введите n = ");
        int result = FunctionAkkerman(m,n); 
        Console.Write($"m = {m}, n = {n} -> A(m,n) = {result} ");
    }

}