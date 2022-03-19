using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double a, b, c, delta, x1, x2;
        
        Console.WriteLine ("Digite o valor de a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite o valor de b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite o valor de c: ");
        c = double.Parse(Console.ReadLine());
        
        delta = Math.Pow(b, 2) - (4 * a * c);
              
        if (delta <= 0)
        {
            Console.WriteLine("N tem raiz!");
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Raizes: ", x1, x2);
        }
        
    }
}