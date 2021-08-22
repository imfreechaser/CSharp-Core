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

        //蛇头位置
        int snakeHeadPosX = 40;
        int snakeHeadPosY = 10;

        //上一帧尾巴位置
        int lastFramePosX = 0;
        int lastFramePosY = 0;

        //判断上一帧有没有吃食物
        bool hasEaten = false;

        //蛇当前的运动方向
        E_MoveDirection moveDirection = E_MoveDirection.right;

        public void Print()
        {
            for (int i = 0; i < partLength; i++)
            {
                if (i == 0)
                {
                    snake[0] = new SnakePart(snakeHeadPosX, snakeHeadPosY);
                    snake[0].partType = E_PartType.SnakeHead;
                }
                else
                {
                    snake[i].partType = E_PartType.SnakeBody;
                }
                snake[i].Print();
            }
        }
        public void Move(Food food)
        {
            //绘 制蛇
            Print();

            //擦除上一帧的痕迹
            if (lastFramePosX != 0 && lastFramePosY != 0 && !hasEaten)
            {
                Console.SetCursorPosition(lastFramePosX, lastFramePosY);
                Console.Write("  ");
            }

            //检测输入
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
                    snakeHeadPosX -= 2;
                    break;
                case E_MoveDirection.right:
                    snakeHeadPosX += 2;
                    break;
                default:
                    break;
            }

            #region 死亡判断
            //1.蛇头撞到墙壁
            if (snakeHeadPosX == 0 || snakeHeadPosX == 78 ||
                snakeHeadPosY == 0 || snakeHeadPosY == 19 )
            {
                Die();
            }
            //2.蛇头撞到自己的身体
            for (int i = 3; i < partLength; i++)
            {
                if(snakeHeadPosX == snake[i].position.posX && snakeHeadPosY == snake[i].position.posY)
                    Die();
            }
            #endregion

            //尾巴位置赋值
            lastFramePosX = snake[partLength - 1].position.posX;
            lastFramePosY = snake[partLength - 1].position.posY;

            //吃食物判断
            hasEaten = false;
            if (snakeHeadPosX == food.position.posX && snakeHeadPosY == food.position.posY)
            {
                Eat();
                hasEaten = true;
            }

            //设置蛇身位置
            for (int i = partLength - 1; i > 0; i--)
            {
                snake[i] = new SnakePart(snake[i - 1].position.posX, snake[i - 1].position.posY);
            }
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
        public void Eat()//身体长度+1、重新长出另一个食物
        {
            AddBodyParts();
            Food.foodExist = false;
        }
        public void Die()
        {
            Game.ChangeScene(E_SceneType.End);
        }

    }
}
