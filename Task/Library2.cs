using static Library1;

//Метод 1. Задача 29 изменение значении 
public class Task29
{
    public static void Task290()
       { 
          int[] ar = CreateArray(3);
          Fill(ar,0,14);
          Console.WriteLine("Задача 29");
          Console.Write(Library1.Print(ar));
          Console.WriteLine($" => {Task29(ar)}");
       }
}

//Метод 2. Задача 27 изменение значении
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
