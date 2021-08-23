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
        public static bool operator ==(Vector v1,Vector v2)
        {
            if (v1.posX == v2.posX && v1.posY == v2.posY)
                return true;
            return false;
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            if (v1.posX == v2.posX && v1.posY == v2.posY)
                return false;
            return true;
        }
    }
    abstract class GameObject : IPrint
    {
        public abstract void Print();
        public Vector position;
    }
}
