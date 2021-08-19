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
        int partLength = 0;
        //蛇当前的运动方向
        E_MoveDirection moveDirection = E_MoveDirection.right;
        //绘制蛇
        public void Print()
        {
            
        }
        //蛇移动
        public void Move()
        {
            for (int i = 0; i < snake.Length; i++)
            {
                switch (moveDirection)
                {
                    case E_MoveDirection.up:
                        snake[i].position.posY--;
                        break;
                    case E_MoveDirection.down:
                        snake[i].position.posY++;
                        break;
                    case E_MoveDirection.left:
                        snake[i].position.posX--;
                        break;
                    case E_MoveDirection.right:
                        snake[i].position.posX++;
                        break;
                    default:
                        break;
                }
                //死亡判断
                if((snake[i].position.posX == 0 || snake[i].position.posX == 38) && (snake[i].position.posY >= 0 && snake[i].position.posY <= 19)
                    ||(snake[i].position.posY == 0 || snake[i].position.posY == 19)&&(snake[i].position.posX >= 0 && snake[i].position.posX <= 38))

                //绘 制蛇
                Print();
                

                //吃食物判断
            }
            
        }
        public void ChangeDirection()
        {

        }
        public void AddBodyParts()
        {
            if (partLength < partCapacity)
               ++partLength;//添加长度
            else
            {
                //扩容、迁移数组
                partCapacity += 10;
                SnakePart[] snake1 = new SnakePart[partCapacity];
                for (int i = 0; i < snake.Length; i++)
                {
                    snake1[i] = snake[i];
                }
                snake = snake1;
                //添加长度
                ++partLength;
            }
            //添加身体，定位置
            //snake[partLength - 1] = new SnakePart();
        }
        public void Eat()
        {

        }
        public void Die()
        {

        }

    }
}
