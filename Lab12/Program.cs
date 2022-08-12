using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            double perimeter = Circle.GetCircumference(r);  
            double area = Circle.GetArea(r);
            Console.WriteLine($"{perimeter} \n{area}");
            Console.WriteLine("Введите координаты x,y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double c = Circle.GetHypotenuse(x, y);
            if (c > r)
                Console.WriteLine("точка находится за пределами круга"); 
            else
                Console.WriteLine("точка принадлежит кругу");
            Console.ReadKey();
        }
    }
}
