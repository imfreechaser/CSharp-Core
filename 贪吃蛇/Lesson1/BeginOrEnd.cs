using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    class BeginOrEnd:ISceneUpdate
    {
        int NowSelectedID = 0;
        string title = "贪吃蛇";
        string btn1Name = "开始游戏";
        string btn2Name = "退出游戏";

        public void Print()
        {

            
        }
        public void Update()
        {
            Console.SetCursorPosition(37, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(title);

            Console.SetCursorPosition(36, 11);
            Console.ForegroundColor = NowSelectedID == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(btn1Name);

            Console.SetCursorPosition(36, 13);
            Console.ForegroundColor = NowSelectedID == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(btn2Name);

            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
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
                default:
                    break;
            }


        }
    }
    class Begin : BeginOrEnd
    {

    }
}
