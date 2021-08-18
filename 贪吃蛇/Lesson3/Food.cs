using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class Food:GameObject
    {
        int x, y;
        Random r = new Random();
        public override void Print()
        {
            x = r.Next(2, Game.w - 4);
            y = r.Next(1, Game.h - 2);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("⊙");
        }

    }
}
