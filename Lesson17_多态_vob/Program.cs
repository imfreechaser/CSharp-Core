using System;

namespace Lesson17_多态_vob
{
    #region Practice1
    class Duck
    {
        protected string quackString;
        public void Quack()
        {
            Console.WriteLine(quackString);
        }
        public Duck(string quackString)
        {
            this.quackString = quackString;
        }
    }
    class WoodenDuck : Duck
    {
        public WoodenDuck() : base("吱吱")
        {

        }
    }
    class RubberDuck : Duck
    {
        public RubberDuck() : base("唧唧")
        {

        }
    }
    #endregion
    #region Practice2
    class Staff
    {
        public int checkInTime = 9;
        public virtual void CheckIn()
        {
            Console.WriteLine("所有员工{0}点打卡上班",checkInTime);
        } 
    }
    class Manager : Staff
    {
        new int checkInTime = 11;
        public override void CheckIn()
        {
            Console.WriteLine("所有员工{0}点打卡上班", checkInTime);
        }
    }
    class SoftwareEngineer : Staff
    {
        new int checkInTime = -1;
        public override void CheckIn()
        {
            if (checkInTime != -1)
                base.CheckIn();
            else
                Console.WriteLine("程序员不打卡！~");
        }
    }

    #endregion
    #region Practice3
    class Grandpa
    {
        public int gdvar;
        public virtual void Test()
        {
            Console.WriteLine("grandpa");
        }
    }
    class Aunt : Grandpa
    {
        public int avar;
        public override void Test()
        {
            Console.WriteLine("aunt");

        }
    }
    class Father : Aunt
    {
        public int fvar;

        public new void Test()
        {
            Console.WriteLine("father");
        
        }
    }
        class Son : Father
        {
            public int svar;
        
            public new void Test()
            {
                Console.WriteLine("Son");
            }
        }
    #endregion
    #region Practice4
    class Graph
    {

        public virtual float CalArea()
        {
            return 0;
        }
        public virtual float CalPerimeter()
        {
            return 0;
        }
    }
    class rectangle:Graph
    {
        public float length;
        public float width;
        public override float CalArea()
        {
            return length * width;
        }
        public override float CalPerimeter()
        {
            return (length + width) * 2;
        }
    }
    class Circle:Graph
    {
        public float r;
        public override float CalArea()
        {
            return r * r * 3.1415f;
        }
        public override float CalPerimeter()
        {
            return r * 3.1415f * 2;
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1
        Duck d = new Duck("嘎嘎"); 
        d.Quack();
        Duck wd = new WoodenDuck();
        wd.Quack();
        RubberDuck rd = new RubberDuck();
        rd.Quack();
            #endregion
            #region Practice2
            //Staff s = new Staff();
            //s.CheckIn();
            //Staff manager1 = new Manager();
            //(manager1 as Manager).CheckIn();
            //Staff se = new SoftwareEngineer();
            //(se as SoftwareEngineer).CheckIn();
            #endregion
            #region Practice3
            //Aunt f = new Father();
            //f.Test();
            //(f as Father).Test();


            #endregion

        }
    }
}
