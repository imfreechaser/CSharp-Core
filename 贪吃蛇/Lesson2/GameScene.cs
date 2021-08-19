using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class GameScene : ISceneUpdate
    {
        public void Update()
        {
            //打印地图墙壁
            Map map = new Map();
            map.Print();
            //打印食物,在上一个食物吃完之后
            Food food = new Food();
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.E)
            {
                food.Print();
            }
            
        }
    }
}
