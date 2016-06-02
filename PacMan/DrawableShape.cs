using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PacMan
{
    interface DrawableShape
    {
        Rectangle Rect { get; set; }

        string Type { get; set; }
        double PositionX { get; set; }
        double PositionY { get; set; }
        Color Color { get; set; }
        int Size { get; set; }
        void Draw(Graphics ctx);
        
    }
}
