using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class Food : GameObject
    {
        public Food(int x, int y)
        {
            position = new Vector(x, y);
            //this.icon = icon;
            //this.color = color;
        }
        public override void Print()
        {
            Console.SetCursorPosition(position.posX, position.posY);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("⊙");
        }

    }
}
