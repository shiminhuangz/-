using System;

class Program
{
    static void Main()
    {
        double pi = Math.PI;

        Console.Write("請輸入圓的半徑：");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = pi * Math.Pow(radius, 2);   
        double roundedArea = Math.Round(area, 5);

        Console.WriteLine($"圓的面積是：{roundedArea}");

      
        Console.ReadKey();
    }
}
