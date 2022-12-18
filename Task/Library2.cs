using static Library1;

//Метод 1. Задача 29. 
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

//Метод 2. Задача 25. 
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
//Метод 3. Задача 27. 
public class Task27
{
    public static void Task270()
    {
        int x = new Random().Next(1,9000);
        Console.WriteLine($"Сумма = {Task27(x)}");
    }
}

//Метод 4. Задача 34.
public class Task34
{
   public static void Task340()
     {
         int[] ar = CreateArray(3);
         Fill(ar,100,999);
         Console.WriteLine(PrintTask34(ar));
     }
}

//Метод 5. Задача 36.
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

//Метод 6. Задача 38;
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