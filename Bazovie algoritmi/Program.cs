using System.Numerics;

namespace Bazovie_algoritmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки");
            int xa = Convert.ToInt32(Console.ReadLine());
            int ya = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки");
            int xb = Convert.ToInt32(Console.ReadLine());
            int yb = Convert.ToInt32(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
            Console.WriteLine("Расстояние между точками равно " + d);


        }
    }
}