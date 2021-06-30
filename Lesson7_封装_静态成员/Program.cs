using System;

namespace Lesson7_封装_静态成员
{
    class Person
    {
        static Person p = new Person();
        public int testInt = 10;

        public static Person P
        {
            get
            {
                return p;
            }
        }

        private Person()
        {
            
        }
    
    }
    //练习题
    static class MathTool
    {
        public const float PI = 3.1415f;

        public static float CircleArea(float r)
        {
            return PI * r * r;
        }
        public static float CirclePeri(float r)
        {
            return 2 * PI * r;
        }
        public static float RecArea(float l,float w)
        {
            return l * w;
        }
        public static float RecPeri(float l, float w)
        {
            return 2 * (l + w);
        }
        public static float AbsoVal(float num)
        {
            return num < 0 ? -num:num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathTool.CircleArea(3.5f));
                
            
        }
    }
}
