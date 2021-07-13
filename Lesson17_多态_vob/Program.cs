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

            #region Practice3
            Aunt f = new Father();
            f.Test();
            (f as Father).Test();
         

            #endregion

        }
    }
}
