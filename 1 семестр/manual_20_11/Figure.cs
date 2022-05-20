using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manual_20_11
{
    class Figure
    {
        public string Color;
        bool Visible;

        public void MoveHorizont()
        {
            Console.WriteLine("Вы переместили фигуру горизонтально");
        }
        public void MoveVertically()
        {
            Console.WriteLine("Вы переместили фигуру вертикально");
        }
        public void ChangeColor(string color)
        {
            Color = color;
        }
            public void ChangeVisible()
        {
            Visible = !Visible;
        }

        public string PrintInfo()
        {
            return $"({Color}, {Visible})";
        }
    }
}
