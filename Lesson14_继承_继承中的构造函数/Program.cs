using System;

namespace Lesson14_继承_继承中的构造函数
{
    class Employee
    {
        public string CareerType
        {
            get;
            set;
        }
        public string CareerDetail
        {
            get;
            set;
        }
        public void work()
        {

        }

        public Employee(string careerType)
        {
            Console.WriteLine("打工人构造函数");
            CareerType = careerType;
        }
    }
    class Programmer : Employee
    {
        public Programmer(string careerType) : base(careerType)
        {
            CareerType = careerType;
            Console.WriteLine("{0}构造函数", CareerType);
        }
    }
    class Planner : Employee
    {
        public Planner(string careerType) : base(careerType)
        {
            CareerType = careerType;
            Console.WriteLine("{0}构造函数", CareerType);
        }
    }
    class Art : Employee
    {
        public Art(string careerType) : base(careerType)
        {
            CareerType = careerType;
            Console.WriteLine("{0}构造函数",CareerType);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Programmer pm = new Programmer("程序员");
            Planner p = new Planner("策划");
            Art a = new Art("美术");
        }
    }
}
