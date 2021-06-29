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

    class Program
    {
        static void Main(string[] args)
        {
            Person.P.testInt = 2;
            Console.WriteLine();
                
            
        }
    }
}
