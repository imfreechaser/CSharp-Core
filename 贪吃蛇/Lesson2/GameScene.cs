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
        int frameSpeed = 150000000;

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
                //蛇先运动
                snake.Move(food); 
            }
            frame++;
        }
    }
}
