using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PacMan
{
    class CollisionDetector
    {
        //public List<Obstacle> Wall { get; set; }
        //public Player MainPlayer { get; set; }

        //public CollisionDetector(List<Obstacle> wall, Player mainPlayer)
        //{
        //    Wall = wall;
        //    MainPlayer = mainPlayer;
        //}

        public bool CheckCollision(List<Obstacle> Walls, Player MainPlayer)
        {

            bool isCollision = false;
            foreach (var wall in Walls)
            {
                Rectangle rect2 = wall.Rect;
                Rectangle rect1 = MainPlayer.Rect;
                Rectangle rect3 = Rectangle.Intersect(rect1, rect2);
                if (rect3.Width * rect3.Height > 0)
                {
                    isCollision = true;
                    MainPlayer.RevertPosition();
                    return isCollision;
                }
            }
            return isCollision;
        }

        internal bool CheckEnemyCollision(List<Obstacle> Walls, Enemy elem)
        {
            bool isCollision = false;
            
              
                foreach (var wall in Walls)
                {
                    Rectangle rect2 = wall.Rect;
                    Rectangle rect1 = elem.Rect;
                    Rectangle rect3 = Rectangle.Intersect(rect1, rect2);
                    if (rect3.Width * rect3.Height > 0)
                    {
                        isCollision = true;
                        elem.RevertPosition();
                        return isCollision;
                    }
                }
                    return isCollision;
        }
    }
}
