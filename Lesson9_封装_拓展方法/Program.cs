using System;

namespace Lesson9_封装_拓展方法
{
    static class Extension
    {
        public static int SquareMulti(this int value)
        {
            return value * value;
        }

        public static void Suicide(this Player p)
        {
            p.hp = 0;
        }

    }

    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int dfd;
        bool isDead;
        
        public Player()
        {
            hp = 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int extendTest = 5;
            Console.WriteLine(extendTest.SquareMulti());

            Player p = new Player();
            p.Suicide();
            Console.WriteLine(p.hp);
        }
    }
}
