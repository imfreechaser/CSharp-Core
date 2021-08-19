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
        
        //蛇当前的运动方向
        E_MoveDirection moveDirection = E_MoveDirection.right;
        //绘制蛇
        public void Print()
        {
            for (int i = 0; i < partLength; i++)
            {
                if(i != 0)
                    snake[i].partType = E_PartType.SnakeBody;
                else
                {
                    snake[0] = new SnakePart(snakeHeadPosX, snakeHeadPosY);
                    snake[0].partType = E_PartType.SnakeHead;
                }
                snake[i].Print();
            }
        }
        //蛇移动
        public void Move()
        {
            int lastFramePosX = 0, lastFramePosY = 0;
            for (int i = 0; i < partLength; i++)
            {
                if(i == 0)
                {
                    lastFramePosX = snakeHeadPosX;
                    lastFramePosY = snakeHeadPosY;
                }
                else
                {
                    snake[i].position.posX = lastFramePosX;
                    snake[i].position.posY = lastFramePosY;

                    lastFramePosX = snake[i].position.posX;
                    lastFramePosY = snake[i].position.posY;
                }
            }
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
                    snakeHeadPosX--;
                    break;
                case E_MoveDirection.right:
                    snakeHeadPosX++; 
                    break;
                default:
                    break;
            }
            #region 死亡判断
            //1.蛇头撞到墙壁
            if ((snakeHeadPosX == 0 || snakeHeadPosX == 38) &&
                (snakeHeadPosY >= 0 && snakeHeadPosY <= 19) ||
                (snakeHeadPosY == 0 || snakeHeadPosY == 19) &&
                (snakeHeadPosX >= 0 && snakeHeadPosX <= 38))
            {
                Die();
            }
            //2.蛇头撞到自己的身体
            #endregion
            //绘 制蛇
            Print();
            //吃食物判断
        }
        public void ChangeDirection()
        {

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
