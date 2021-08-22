using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class Food:GameObject
    {
        public static bool foodExist = true;
        Random r = new Random();
        public override void Print()
        {
            position.posX = 2 * r.Next(1, (Game.w - 4)/2);
            position.posY = r.Next(1, Game.h - 2);
            Console.SetCursorPosition(position.posX, position.posY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("⊙");
        }
        public Food()
        {
            Print();
        }
    }
}
