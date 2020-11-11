using Factory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities
{
    class Present : Toy
    {
        public Color Ribbon { get; private set; }
        public Color Box { get; private set; }

        public Present(Color color1, Color color2)
        {
            Box = color1;
            Ribbon = color2;
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Box), new Rectangle(0, 0, 200, 200));
            g.FillRectangle(new SolidBrush(Ribbon), new Rectangle(0, 0, 20, 50));
            g.FillRectangle(new SolidBrush(Ribbon), new Rectangle(0, 20, 20, 0));
        }
    }
}
