using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class GameScene : ISceneUpdate
    {
        Map map;
        Food food;
        Snake snake;
        //更新速度
        int frame = 1;
        int frameSpeed = 15000;

        public GameScene()
        {
            map = new Map();
            food = new Food();
            snake = new Snake();
        }
        public void Update()
        {
            if (frame % frameSpeed == 0)//游戏帧的内容
            {
                //打印食物,在上一个食物吃完之后
                if (Food.foodExist == false)
                {
                    food.Print();
                    Food.foodExist = true;
                }
                snake.Print();
                snake.Move(food);

            }
            frame++;
            //判断有无键盘输入
            if (Console.KeyAvailable)
            {
                //检测输入输出
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDirection(E_MoveDirection.up);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDirection(E_MoveDirection.down);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDirection(E_MoveDirection.left);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDirection(E_MoveDirection.right);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
