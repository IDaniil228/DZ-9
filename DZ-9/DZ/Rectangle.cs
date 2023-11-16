using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    internal class Rectangle : Point
    {
        double sideA, sideB;
        double square;

        public Rectangle(double x, double y, Colors color, bool vis, double sideA, double sideB) : base(x, y, color, vis)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        /// <summary>
        /// Выводит информацию о прямоугольнике
        /// </summary>
        public override void WriteData()
        {
            Console.WriteLine($"Сторона а = {sideA}");
            Console.WriteLine($"Сторона b = {sideB}");
            Console.WriteLine($"Видимый - {visible}");
            Console.WriteLine($"Коорединаты по Х - {x}");
            Console.WriteLine($"Координаты по Y - {y}");
            Console.WriteLine($"Площадь фигуры - {square}");

        }
        /// <summary>
        /// Считает площать прямоугольника
        /// </summary>
        public void СalculateSqure()
        {
            square = sideA * sideB;
        }
    }
}
