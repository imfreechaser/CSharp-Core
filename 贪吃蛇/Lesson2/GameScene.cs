using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class GameScene : ISceneUpdate
    {
        //初始化地图
        Map map = new Map();
        //初始化蛇
        Snake snake = new Snake();
        //更新速度
        int frame = 1;
        int frameSpeed = 150000000;
        public void Update()
        {
            //打印食物,在上一个食物吃完之后
            //Food food = new Food();
            //ConsoleKey key = Console.ReadKey(true).Key;
            //if (key == ConsoleKey.E)
            //{
            //    food.Print();
            //}

            if(frame % frameSpeed == 0)
            {
                //初始化蛇
                //snake.Print();
                snake.Move();
            }

            frame++;
        }
    }
}
