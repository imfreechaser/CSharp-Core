using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class GameScene : ISceneUpdate
    {
        //初始化地图
        Map map = new Map();
        //初始化食物
        Food food = new Food();
        //初始化蛇
        Snake snake = new Snake();
        //更新速度
        int frame = 1;
        int frameSpeed = 150000000;
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
