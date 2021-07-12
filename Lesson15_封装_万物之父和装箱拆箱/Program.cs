using System;

namespace Lesson15_封装_万物之父和装箱拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 10;
            object o1 = intValue;
            //intValue = 20;
            o1 = 15;
            Console.WriteLine("intvalue:{0},o1:{1}",intValue,o1);
        }
    }
}
