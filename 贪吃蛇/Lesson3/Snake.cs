using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇
{
    enum E_MoveDirection
    {
        up,
        down,
        left,
        right
    }
    class Snake
    {
        //初始化蛇
        SnakePart[] snake = new SnakePart[partCapacity];
        static int partCapacity = 10;
        int partLength = 1;
        int snakeHeadPosX = 40;
        int snakeHeadPosY = 10;
        public Snake()
        {
            Print();
        }
        //蛇当前的运动方向
        E_MoveDirection moveDirection = E_MoveDirection.right;
        //绘制蛇
        public void Print()
        {
            for (int i = 0; i < partLength; i++)
            {
                if (i == 0)
                    snake[0].partType = E_PartType.SnakeHead;
                else
                {
                    snake[i].partType = E_PartType.SnakeBody;
                }
                snake[i].Print();
            }
        }
        //蛇移动
        public void Move()
        {
            int lastFramePosX = 0, lastFramePosY = 0;
            int midVarX = 0, midVarY = 0;
            for (int i = 0; i < partLength; i++)
            {
            //    if(i == 0)
            //    {
                    lastFramePosX = snakeHeadPosX;
                    lastFramePosY = snakeHeadPosY;
            //}
            //else
            //{
            //    snake[i].position.posX = lastFramePosX;
            //    snake[i].position.posY = lastFramePosY;

            //    lastFramePosX = snake[i].position.posX;
            //    lastFramePosY = snake[i].position.posY;
            //}
            }
            ChangeDirection();
            //改变蛇头的位置
            switch (moveDirection)
            {
                case E_MoveDirection.up:
                    snakeHeadPosY--;
                    break;
                case E_MoveDirection.down:
                    snakeHeadPosY++;
                    break;
                case E_MoveDirection.left:
                    snakeHeadPosX-=2;
                    break;
                case E_MoveDirection.right:
                    snakeHeadPosX+=2; 
                    break;
                default:
                    break;
            }
            
            //绘 制蛇
            Print();
            //擦除上一帧的痕迹
            Console.SetCursorPosition(lastFramePosX, lastFramePosY);
            Console.Write("  ");
            #region 死亡判断
            //1.蛇头撞到墙壁
            if ((snakeHeadPosX == 0 || snakeHeadPosX == 78) &&
                (snakeHeadPosY >= 0 && snakeHeadPosY <= 19) ||
                (snakeHeadPosY == 0 || snakeHeadPosY == 19) &&
                (snakeHeadPosX >= 0 && snakeHeadPosX <= 78))
            {
                Die();
            }
            //2.蛇头撞到自己的身体
            #endregion

            //吃食物判断

        }
        public void ChangeDirection()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    moveDirection = E_MoveDirection.up;
                    break;
                case ConsoleKey.S:
                    moveDirection = E_MoveDirection.down;
                    break;
                case ConsoleKey.A:
                    moveDirection = E_MoveDirection.left;
                    break;
                case ConsoleKey.D:
                    moveDirection = E_MoveDirection.right;
                    break;
                default:
                    break;
            }

        }
        public void AddBodyParts()
        {
            if (partLength >= partCapacity)
            {
                //扩容、迁移数组
                partCapacity += 10;
                SnakePart[] snake1 = new SnakePart[partCapacity];
                for (int i = 0; i < snake.Length; i++)
                {
                    snake1[i] = snake[i];
                }
                snake = snake1;

            }
            //添加长度
            ++partLength;
        }
        public void Eat()
        {

        }
        public void Die()
        {
            Game.ChangeScene(E_SceneType.End);
        }

    }
}
