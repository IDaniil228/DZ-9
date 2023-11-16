using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    internal class Point : Figure
    {
        public Point(double x ,double y, Colors color, bool vis)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            visible = vis;
        }
        public override void WriteData()
        {
            Console.WriteLine($"Цвет точки - {color}");
            Console.WriteLine($"Видимый - {visible}");
            Console.WriteLine($"Коорединаты по Х - {x}");
            Console.WriteLine($"Координаты по Y - {y}");
        }

    }
}
