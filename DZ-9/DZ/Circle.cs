using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    internal class Circle : Point
    {
        double square;
        double r;

        public Circle(double x, double y, Colors color, bool vis, double r): base(x, y, color, vis)
        {
            this.r = r;
        }
        /// <summary>
        /// Выводит информацию об окружности
        /// </summary>
        public override void WriteData()
        {
            Console.WriteLine($"Радиус окр - {r}");
            Console.WriteLine($"Видимый - {visible}");
            Console.WriteLine($"Коорединаты по Х - {x}");
            Console.WriteLine($"Координаты по Y - {y}");
            Console.WriteLine($"Площадь фигуры - {square}");

        }
        /// <summary>
        /// Считает площадь окр
        /// </summary>
        public void СalculateSquare()
        {
            square = Math.PI * r * r;
        }
    }
}
