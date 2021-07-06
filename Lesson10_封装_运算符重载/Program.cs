using System;

namespace Lesson10_封装_运算符重载
{
    struct Position
    {
        public float x;
        public float y;
        public Position(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Position p1, Position p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
                return true;
            else
                return false;
        }
        public static bool operator !=(Position p1, Position p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
                return false;
            else
                return true;
        }
    }

    class Vector3
    {
        public float x, y, z;
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 v = new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            return v;
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 v = new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            return v;
        }
        public static Vector3 operator *(Vector3 v1, float num)
        {
            Vector3 v = new Vector3(v1.x * num, v1.y * num, v1.z * num);
            return v;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position p1 = new Position(1, 2);
            Position p2 = new Position(1, 2);
            Console.WriteLine(p1 == p2);
            Console.WriteLine("*********************************************");
            Vector3 v1 = new Vector3(1, 2, 3);
            Vector3 v2 = new Vector3(4, 5, 6);
            Vector3 v = v1 * 5.5f;
            Console.WriteLine($"{v.x}\t{v.y}\t{v.z}");


        }
    }
}
