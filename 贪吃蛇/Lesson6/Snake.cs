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
        Vector snakeHead;
        //上一帧尾巴位置
        Vector lastFramePos = new Vector(0, 0);
        //判断上一帧有没有吃食物
        bool hasEaten = false;
        //蛇的运动方向
        E_MoveDirection moveDirection;

        public Snake()
        {
            snake = new SnakePart[partCapacity];
            //初始化蛇头
            snakeHead = new Vector(40, 10);
            snake[0] = new SnakePart(snakeHead.posX, snakeHead.posY, E_PartType.SnakeHead);
            //初始化运动方向
            moveDirection = E_MoveDirection.right;
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
            lastFramePos = snake[partLength - 1].position;

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

            //擦除上一帧的痕迹
            if (lastFramePos != new Vector(0, 0) && !hasEaten)
            {
                Console.SetCursorPosition(lastFramePos.posX, lastFramePos.posY);
                Console.Write("  ");
            }
        }
        public void ChangeDirection(E_MoveDirection newDir)//传入一个新方向，然后判断如何改变原方向
        {
            //只有头部时，没有转向的限制，各个方向都能走；
            //有身体时，有转向限制：不能往身体的方向走；
            //所以，有限制的情况比较少，单独拎出来写，其他都是没有限制的情况，就按输入的新方向来改变方向；

            //有限制的情况时，不改变方向
            if (partLength > 1 &&
                (moveDirection == E_MoveDirection.right && newDir == E_MoveDirection.left) ||
                (moveDirection == E_MoveDirection.left && newDir == E_MoveDirection.right) ||
                (moveDirection == E_MoveDirection.up && newDir == E_MoveDirection.down) ||
                (moveDirection == E_MoveDirection.down && newDir == E_MoveDirection.up)
                )
                return;
            else
                moveDirection = newDir;
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
