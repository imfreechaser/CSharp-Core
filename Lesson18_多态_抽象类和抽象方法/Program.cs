using System;

namespace Lesson18_多态_抽象类和抽象方法
{
    #region Practice1
    abstract class Animal
    {
        public abstract void Speak();
    }
    class Human : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("人叫");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("狗叫");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("猫叫");
        }
    }
    #endregion
    #region Practice2

    abstract class Graph
    {
        abstract public float GetArea();
        abstract public float GetPeri();
    }
    class Rect : Graph
    {
        public float length, width;
        public override float GetArea()
        {
            return length * width;
        }
        public override float GetPeri()
        {
            return 2 * (length + width);
        }
        public Rect(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
    }
    class Square : Graph
    {
        public float length;
        public override float GetArea()
        {
            return length * length;
        }
        public override float GetPeri()
        {
            return 4 * length;
        }
        public Square(float length)
        {
            this.length = length;
        }
    }
    class Circle : Graph
    {
        public float radius;
        public override float GetArea()
        {
            return radius * radius * 3.14f;
        }
        public override float GetPeri()
        {
            return 2 * radius * 3.14f;
        }
        public Circle(float radius)
        {
            this.radius = radius;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal h = new Human();
            (cat as Cat).Speak();
            (dog as Dog).Speak();
            (h as Human).Speak();
            Console.WriteLine();
            Graph rect = new Rect(2.5f,4f);
            Console.WriteLine("面积为:{0},周长为:{1}", rect.GetArea(), rect.GetPeri());
            Graph square = new Square(2.5f);
            Console.WriteLine("面积为:{0},周长为:{1}", square.GetArea(), square.GetPeri());
            Graph circle = new Circle(3f);
            Console.WriteLine("面积为:{0},周长为:{1}", circle.GetArea(), circle.GetPeri());

        }
    }
}
