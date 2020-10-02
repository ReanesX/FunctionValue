using System;

namespace FunctionValue
{
    class Program
    {
        static float IsFunc(float x)
        {
            float y = x * x;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите шаг построения: ");
            float step = float.Parse(Console.ReadLine());

            Console.Write("Введите начальное значение дипозона X: ");
            float startValue = float.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение дипозона X: ");
            float endValue = float.Parse(Console.ReadLine());
            
            Console.WriteLine("|---------------|---------------|");
            Console.WriteLine("|\tx\t|\ty\t|");
            Console.WriteLine("|---------------|---------------|");
           
            for (float x = startValue; x <= endValue; x += step)
            {
                float y = IsFunc(x);
                Console.WriteLine($"|\t{x}\t|\t{y}\t|");
            }
        }
    }
}
