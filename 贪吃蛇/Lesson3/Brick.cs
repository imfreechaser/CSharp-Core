﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class Brick
    {
        Vector position;
        public Brick(int x, int y)
        {
            position = new Vector(x, y);
        }
        public void Print()
        {
            Console.SetCursorPosition(position.posX, position.posY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("■");
        }
    }
}
