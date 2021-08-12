using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    abstract class BeginOrEnd:ISceneUpdate
    {
        public int NowSelectedID = 0;
        public string title;
        public string btn1Name;
        public abstract void enterKeyDown();
        public void Update()
        {
            Console.SetCursorPosition(Game.w/2 - title.Length, Game.h/4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(title);

            Console.SetCursorPosition(Game.w / 2 - btn1Name.Length, Game.h / 2 + 1);
            Console.ForegroundColor = NowSelectedID == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(btn1Name);

            Console.SetCursorPosition(Game.w / 2 - 4, Game.h / 2 + 3);
            Console.ForegroundColor = NowSelectedID == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("退出游戏");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    NowSelectedID--;
                    if (NowSelectedID < 0)
                        NowSelectedID = 0;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                     NowSelectedID++;
                    if (NowSelectedID > 1)
                       NowSelectedID = 1;
                    break;
                case ConsoleKey.Enter:
                    if (NowSelectedID == 0)
                    {
                        enterKeyDown();
                    }
                    else if (NowSelectedID == 1)
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    break;
            }
            

        }
    }
    class Begin : BeginOrEnd
    {
        public Begin()
        {
            title = "贪吃蛇";
            btn1Name = "开始游戏";
        }
        public override void enterKeyDown()
        {
            Game.ChangeScene(E_SceneType.Game);
        }
    }
    class End : BeginOrEnd
    {
        public End()
        {
            title = "游戏结束";
            btn1Name = "回到开始界面";
        }
        public override void enterKeyDown()
        {
            Game.ChangeScene(E_SceneType.Begin);
        }
    }
}
