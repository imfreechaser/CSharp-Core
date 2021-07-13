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
        public virtual void 
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

            #endregion
        }
    }
}
