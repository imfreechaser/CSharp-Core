using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class Map
    {
        Brick[] bricks = new Brick[Game.w + Game.h * 2 - 4];
        public void Print()
        {
            for (int i = 0, x = 0, y = 0; i < Game.w/2; i++)
            {
                bricks[i] = new Brick(x, y);
                bricks[i].Print();
                x += 2;
            }
            for (int i = Game.w / 2, x = 0, y = Game.h-1; i >= Game.w / 2 && i < Game.w; i++)
            {
                bricks[i] = new Brick(x, y);
                bricks[i].Print();
                x += 2;
            }
            for (int i = Game.w, x = 0, y = 1; i >= Game.w && i < Game.w + Game.h - 2; i++)
            {
                bricks[i] = new Brick(x, y);
                bricks[i].Print();
                y++;
            }
            for (int i = Game.w + Game.h - 2, x = Game.w - 2, y = 1; i >= Game.w + Game.h - 2 && i < Game.w + Game.h * 2 - 4; i++)
            {
                bricks[i] = new Brick(x, y);
                bricks[i].Print();
                y++;
            }
        }
    }
}
