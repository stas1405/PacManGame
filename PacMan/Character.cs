using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PacMan
{
    abstract class Character: GameElement
    {
        public Character()
        {

        }
        public Character(string type, int posX, int posY, Color color, int size, int velocity):base (type, posX, posY, color, size, velocity)
        {

        }
        public override void Draw(System.Drawing.Graphics ctx)
        {

        }
    }
}
