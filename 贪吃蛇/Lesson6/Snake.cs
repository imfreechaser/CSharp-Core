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
        public SnakePart[] snake;
        static int partCapacity = 10;
        public int partLength = 1;

        //蛇的运动方向
        E_MoveDirection moveDirection;

        public Snake()
        {
            snake = new SnakePart[partCapacity];
            //初始化蛇头
            snake[0] = new SnakePart(40,10, E_PartType.SnakeHead);
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
            //擦除上一帧的痕迹
            Vector lastFramePos = snake[partLength - 1].position;
            Console.SetCursorPosition(lastFramePos.posX, lastFramePos.posY);
            Console.Write("  ");

            //蛇身位置移动,蛇身子先变位置，一个一个往前顶，最前面的一个蛇身子应该顶替蛇头改变之前的位置，所以蛇头改变位置的顺序应该在蛇身改变位置后面；
            for (int i = partLength - 1; i > 0; i--)
            {
                snake[i].position = snake[i - 1].position;
            }

            //改变蛇头的位置
            switch (moveDirection)
            {
                case E_MoveDirection.up:
                    snake[0].position.posY--;
                    break;
                case E_MoveDirection.down:
                    snake[0].position.posY++;
                    break;
                case E_MoveDirection.left:
                    snake[0].position.posX -= 2;
                    break;
                case E_MoveDirection.right:
                    snake[0].position.posX += 2;
                    break;
                default:
                    break;
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
            //添加身体
            snake[partLength] = new SnakePart(snake[partLength-1].position.posX, snake[partLength - 1].position.posY, E_PartType.SnakeBody);
            //添加长度
            ++partLength;
        }
        public bool CheckEat(Food food)//身体长度+1、重新长出另一个食物
        {
            if (snake[0].position == food.position)
            {
                AddBodyParts();
                return true;
            }
            return false;
        }
        public bool CheckEnd(Map map)
        {
            //1.蛇头撞到墙壁
            for (int i = 0; i < map.bricks.Length; i++)
            {
                if (map.bricks[i].position == snake[0].position)
                {
                    return true;
                }
            }
            
            //2.蛇头撞到自己的身体
            for (int i = 3; i < partLength; i++)
            {
                if (snake[0].position == snake[i].position)
                    return true;
            }
            return false;
        }

    }
}
