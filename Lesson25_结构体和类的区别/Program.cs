using System;

namespace Lesson25_结构体和类的区别
{
    interface I_Draw
    {
        public void DrawMap();
    }
     struct map:I_Draw
    {
        public static ConsoleColor mapColor;
        public int length;
        public map(int length)
        {
            this.length = length;
        }
        public void DrawMap()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            map m1 = new map();
            Console.WriteLine(m1.length);
            m1.length = 10;
            map.mapColor = ConsoleColor.Red;

            map m2 = new map(12);
            Console.WriteLine(map.mapColor.ToString());
        }
    }
}
