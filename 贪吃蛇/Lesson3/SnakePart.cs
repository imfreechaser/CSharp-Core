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
        E_PartType partType;
        public SnakePart(int x, int y)
        {
            position = new Vector(x, y);
        }
        public override void Print()
        {
            Console.SetCursorPosition(position.posX, position.posY);
            Console.Write("{0}",partType == E_PartType.SnakeHead?"¤":"●");
        }
    }
}
