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
        //创建蛇及数组字段
        SnakePart[] snake;
        static int partCapacity = 10;
        int partLength = 1;

        //蛇头位置
        Vector snakeHead = new Vector(40, 10);

        //上一帧尾巴位置
        Vector lastFramePos = new Vector(0, 0);

        //判断上一帧有没有吃食物
        bool hasEaten = false;

        //蛇当前的运动方向
        E_MoveDirection moveDirection = E_MoveDirection.right;

        public Snake()
        {
            snake = new SnakePart[partCapacity];
            //初始化蛇头
            snake[0] = new SnakePart(snakeHead.posX, snakeHead.posY, E_PartType.SnakeHead);
        }

        public void Print()
        {
            for (int i = 0; i < partLength; i++)
            { 
                snake[i].Print();
            }
        }
        public void Move(Food food)
        {
            //绘 制蛇
            Print();

            //擦除上一帧的痕迹
            if (lastFramePos != new Vector(0,0) && !hasEaten)
            {
                Console.SetCursorPosition(lastFramePos.posX, lastFramePos.posY);
                Console.Write("  ");
            }

            //检测输入
            ChangeDirection();

            //改变蛇头的位置
            switch (moveDirection)
            {
                case E_MoveDirection.up:
                    snakeHead.posY--;
                    break;
                case E_MoveDirection.down:
                    snakeHead.posY++;
                    break;
                case E_MoveDirection.left:
                    snakeHead.posX -= 2;
                    break;
                case E_MoveDirection.right:
                    snakeHead.posX += 2;
                    break;
                default:
                    break;
            }

            #region 死亡判断
            //1.蛇头撞到墙壁
            if (snakeHead.posX == 0 || snakeHead.posX == Game.w - 2 ||
                snakeHead.posY == 0 || snakeHead.posY == Game.h - 1 )
            {
                Die();
            }
            //2.蛇头撞到自己的身体
            for (int i = 3; i < partLength; i++)
            {
                if(snakeHead == snake[i].position)
                    Die();
            }
            #endregion

            //尾巴位置赋值
            lastFramePos.posX = snake[partLength - 1].position.posX;
            lastFramePos.posY = snake[partLength - 1].position.posY;

            //吃食物判断
            hasEaten = false;
            if (snakeHead == food.position)
            {
                Eat();
                hasEaten = true;
            }

            //设置蛇身位置、蛇头赋值
            for (int i = partLength - 1; i > 0; i--)
            {
                snake[i] = new SnakePart(snake[i - 1].position.posX, snake[i - 1].position.posY, E_PartType.SnakeBody);
            }
            snake[0] = new SnakePart(snakeHead.posX, snakeHead.posY, E_PartType.SnakeHead); 
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
