using System;

namespace Lesson12_继承_继承的基本规则
{
    class Teacher
    {
        public string name;
        public int number;
        public void SpeakName()
        {
            Console.WriteLine(name);
        }
    }
    class TeachingTeacher : Teacher
    {
        public string subject;
        public void SpeakSubject()
        {
            Console.WriteLine(subject + "老师");
        }
    }
    class ChineseTeacher : TeachingTeacher
    {
        public void Skill()
        {
            Console.WriteLine("念诗");
        }
    }

    class Human
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 年龄
        /// </summary>
        public ushort age;
        /// <summary>
        /// 说话行为
        /// </summary>
        public void Speak()
        {
            Console.WriteLine("每个人都可以说话。");
        }
    }

    class Warrior : Human
    {
        public void Attack()
        {
            Console.WriteLine("战士攻击");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TeachingTeacher tt = new TeachingTeacher();
            //tt.name = "章老师";
            //tt.number = 1;
            //tt.SpeakName();
            //tt.subject = "历史";
            //tt.SpeakSubject();
            //ChineseTeacher ct = new ChineseTeacher();
            //ct.Skill();
            //ct.SpeakName();

            Human h1 = new Human();
            h1.age = 100;
            h1.name = "张三";
            h1.Speak();
            Console.WriteLine("{0} {1}",h1.age,h1.name);

            Warrior w = new Warrior();
            w.name = "亚瑟";
            w.age = 33;
            Console.WriteLine("{0} {1}", w.age, w.name);
            w.Speak();
            w.Attack();

        }
    }
}
