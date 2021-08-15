using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    /// <summary>
    /// 场景类型枚举
    /// </summary>
    enum E_SceneType
    {
        Begin,
        Game,
        End
    }
    class Game
    {
        //游戏窗口宽高
        public const int w = 80;
        public const int h = 20;
        //当前选中场景
        public static ISceneUpdate nowScene;

        //初始化控制台,写在构造函数中，只有当创建对象的时候才会调用，符合本游戏需求。也可以单独写一个初始化函数，适用于需要多次调用的场景。
        public Game()//进行一些初始化设置
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            //老师方法
            //ChangeScene(E_SceneType.Begin);
            //自己方法
            nowScene = new Begin();
        }

        //游戏开始的方法
        public void Start()
        {
            while (true)
            {
                //判断游戏场景不为空则更新
                if(nowScene != null)
                {
                    nowScene.Update();
                }

            }
        }
        public static void ChangeScene(E_SceneType type)//每次场景切换时才调用，不是每次游戏主循环里都会调用！
        {
            //切场景之前，应该把上一个场景的绘制内容擦除
            Console.Clear();

            switch (type)//应用场景类型枚举来判断，当前是什么场景
            {
                case E_SceneType.Begin://创建对应场景的场景对象，并调用场景的帧更新方法，即运行此场景；
                    nowScene = new Begin();
                    nowScene.Update();
                    break;
                case E_SceneType.Game:
                    nowScene = new GameScene();
                    nowScene.Update();
                    break;
                case E_SceneType.End:
                    nowScene = new End();
                    nowScene.Update();
                    break;
                default:
                    break;
            }
        }
    }
}
