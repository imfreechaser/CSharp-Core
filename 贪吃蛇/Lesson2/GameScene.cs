using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class GameScene : ISceneUpdate
    {
        public void Update()
        {
            Console.SetCursorPosition(0,0);
            MapWall mapWall = new MapWall();
            mapWall.Print();
        }
    }
}
