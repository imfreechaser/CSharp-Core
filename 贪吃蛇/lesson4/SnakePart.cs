using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    enum E_PartType
    {
        SnakeHead,
        SnakeBody
    }
    class SnakePart:GameObject
    {
        public E_PartType partType;
        public SnakePart(int x, int y, E_PartType partType)
        {
            position = new Vector(x, y);
            this.partType = partType;
        }
        public override void Print()
        {
            Console.SetCursorPosition(position.posX, position.posY);
            Console.ForegroundColor = partType == E_PartType.SnakeHead ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.Write("{0}",partType == E_PartType.SnakeHead?"¤":"●");
        }
    }
}
