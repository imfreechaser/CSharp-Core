using System;

namespace Lesson4_封装_构造函数和析构函数
{
    enum E_sex
    {
        male,
        female
    }
    struct Vector
    {
        public int posX, posY;
        public Vector(int x, int y)
        {
            posX = x;
            posY = y;
        }
    }
    class Human
    {
        public string name;
        public int age;
        public E_sex sex;
        public Human[] friends;
        public Vector position;

        public void Speak(string sth)
        {
            Console.WriteLine($"{name}说{sth}");
        }
        public void Walk(int x, int y)
        {
            position.posX = x;
            position.posY = y;
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{name}吃了{food}");
        }

        public Human()
        {
            sex = E_sex.female;
            age = 18;
        }

        public Human(string name):this()
        {
            this.name = name;
        }

        public Human(Vector pos):this()
        {
            position = pos;
        }
        public Human(Human[] h):this()
        {
            friends = h;
        }
    }
    class Student
    {
        public string name;
        public int studentNum;
        public int age;
        public Student deskmate;

        public void Study(string lesson)
        {
            Console.WriteLine($"{name}学习了{lesson}课程");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{name}吃了{food}");
        }
    }
    class Food
    {
        public string name;
        public float calory;

        public float GetCalories(string name)
        {
            switch (name)
            {
                case "菠萝":
                    return 134;
                case "香蕉":
                    return 120;
                case "苹果":
                    return 56;
                default:
                    return 0;
                    break;
            }
        }
    }
    class Ticket
    {
        float distance;
        float price;

        public Ticket(float distance)
        {
            this.distance = distance;
            price = GetPrice();
        }

        private float GetPrice()
        {
            if (distance >= 0 && distance <= 100)
                return distance;
            else if (distance >= 101 && distance <= 200)
                return distance * 0.95f;
            else if (distance >= 201 && distance <= 300)
                return distance * 0.9f;
            else if (distance > 300)
                return distance * 0.8f;
            else return 0;
        }
        public void ShowTicket()
        {
            Console.WriteLine("距离为{0}，价格为{1:N2}",distance,price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Human h1 = new Human();
            //Console.WriteLine(h1.age);
            //Console.WriteLine(h1.name);
            //Console.WriteLine(h1.sex);
            //Human h2 = new Human("小小明");
            //Console.WriteLine(h2.age);
            //Console.WriteLine(h2.name);
            //Console.WriteLine(h2.sex);
            //Human h3 = new Human(h2);
            //Console.WriteLine(h2.age);
            //Console.WriteLine(h2.name);
            //Console.WriteLine(h2.sex);
            //Console.WriteLine(h2.friends[0]);

            Ticket t1 = new Ticket(234);
            t1.ShowTicket();



        }
    }
}
