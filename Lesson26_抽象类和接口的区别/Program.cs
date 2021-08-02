using System;

namespace Lesson26_抽象类和接口的区别
{
    abstract class Animal
    {
        public string name;
        public abstract string catagory
        {
            get;
            set;
        }

        public abstract void Eat();
        public void Walk()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
