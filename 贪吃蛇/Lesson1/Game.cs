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
        public int w = 80;
        public int h = 20;
        //当前选中场景
        public ISceneUpdate nowScene;

        E_SceneType sceneType = E_SceneType.Begin;

        //初始化控制台,写在构造函数中，只有当创建对象的时候才会调用，符合本游戏需求。也可以单独写一个初始化函数，适用于需要多次调用的场景。
        public Game()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
        }

        //游戏开始的方法
        public void Start()
        {
            nowScene = new Begin();
            while (true)
            {
                //判断游戏场景不为空则更新
                if(nowScene != null)
                {
                    ChangeScene(sceneType);
                }

            }
        }
        public void ChangeScene(E_SceneType type)
        {
            //切场景之前，应该把上一个场景的绘制内容擦除
            Console.Clear();

            switch (type)
            {
                case E_SceneType.Begin:
                    nowScene.Update();
                    break;
                case E_SceneType.Game:
                    break;
                case E_SceneType.End:
                    break;
                default:
                    break;
            }
        }
    }
}
