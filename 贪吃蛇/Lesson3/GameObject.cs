using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    struct Vector
    {
        public int posX;
        public int posY;
        public Vector(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
    class GameObject : IPrint
    {
        public virtual void Print()
        {
            
        }
        public Vector position;
    }
}
