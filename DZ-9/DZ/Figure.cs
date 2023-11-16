using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    public enum Colors { red, green, blue, black, yellow, orange, pink }
    internal abstract class Figure : IMove, IColor, IVisible
    {
        protected Colors color;
        protected bool visible;
        protected double x;
        protected double y;

        public abstract void WriteData();

        public void SetVisible(bool visible)
        { 
            this.visible = visible;
        }
        public void ChangeColor(int num)
        {
            color = (Colors)num;
        }

        public void MoveX(double num)
        {
            x += num;
        }

        public void MoveY(double num)
        {
            y += num;
        }

    }
}
