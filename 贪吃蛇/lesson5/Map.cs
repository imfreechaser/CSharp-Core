using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class Map
    {
        Brick[] bricks;
        public void Print()
        {
            for (int i = 0; i < bricks.Length; i++)
            {
                bricks[i].Print();
            }
        }
        public Map()
        {
            //初始化
            bricks = new Brick[Game.w + Game.h * 2 - 4];
            for (int i = 0, x = 0; i < Game.w / 2; i++)
            {
                bricks[i] = new Brick(x, 0);
                x += 2;
            }
            for (int i = Game.w / 2, x = 0, y = Game.h - 1; i >= Game.w / 2 && i < Game.w; i++)
            {
                bricks[i] = new Brick(x, y);
                x += 2;
            }
            for (int i = Game.w, y = 1; i >= Game.w && i < Game.w + Game.h - 2; i++)
            {
                bricks[i] = new Brick(0, y);
                y++;
            }
            for (int i = Game.w + Game.h - 2, x = Game.w - 2, y = 1; i >= Game.w + Game.h - 2 && i < Game.w + Game.h * 2 - 4; i++)
            {
                bricks[i] = new Brick(x, y);
                y++;
            }
            //画地图
            Print();
        }
    }
}
