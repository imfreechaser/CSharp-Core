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
            snake = new Snake();
            food = new Food(map, snake);
        }
        public void Update()
        {
            if (frame % frameSpeed == 0)//游戏帧的内容
            {
                food.Print();//食物的绘制应该在吃了食物之后的第二帧进行所以checkEat放后面，食物的print放在前面；

                snake.Move(food);//因为每帧都会检测按键输入，为了让按键按下之后蛇更快的做出改变，所以应该在按下的第二帧先进行move,
                                 //改变蛇的位置,然后紧接着在同一帧进行蛇的绘制，所以print应该在move后面；
                snake.Print();

                if (snake.CheckEnd(map))//游戏结束检测：是否撞到围墙或者自身
                {
                    Game.ChangeScene(E_SceneType.End);
                }

                if (snake.CheckEat(food))
                {
                    food.RandomPos(map, snake);
                }
                
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
