using System;

namespace Lesson3_成员方法
{
    enum E_sex
    {
        male,
        female
    }
    struct Vector
    {
        public int posX, posY;
        public Vector(int x,int y)
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

    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            Console.WriteLine($"x = {h1.position.posX},y = {h1.position.posY}");
            h1.Walk(1, 3);
            Console.WriteLine($"x = {h1.position.posX},y = {h1.position.posY}");
            h1.name = "小银耳";
            h1.Speak("好好学习");
            h1.Eat("冰西瓜");

            Student s1 = new Student();
            s1.name = "梅小名";
            s1.Study("数学");
            Food f1 = new Food();
            f1.name = "苹果";
            s1.Eat(f1.name);
            Console.WriteLine($"摄入了{f1.GetCalories(f1.name)}千卡的热量");

        }
    }
}
