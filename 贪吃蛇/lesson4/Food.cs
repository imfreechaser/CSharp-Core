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
            Console.SetCursorPosition(position.posX, position.posY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("⊙");
        }
        public Food(Map map, Snake snake)
        {
            RandomPos(map, snake);
        }
        public void RandomPos(Map map,Snake snake)
        {
            position.posX = 2 * r.Next(1, (Game.w - 4) / 2);
            position.posY = r.Next(1, Game.h - 2);
            //不与地图重合
            for (int i = 0; i < map.bricks.Length; i++)
            {
                if (position == map.bricks[i].position)
                    RandomPos(map, snake);
            }
            //不与蛇重合
            for (int i = 0; i < snake.partLength; i++)
            {
                if (position == snake.snake[i].position)
                    RandomPos(map, snake);
            }

        }
    }
}
