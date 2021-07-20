﻿using System;

namespace Lesson19_多态_接口
{
    #region Practice1
    class Person : ICheckIn
    {
        public void CheckIn()
        {
            Console.WriteLine("到派出所登记");
        }
    }
    class Car : ICheckIn
    {
        public void CheckIn()
        {
            Console.WriteLine("到车管所登记");
        }
    }
    class House : ICheckIn
    {
        public void CheckIn()
        {
            Console.WriteLine("到房管局登记");
        }
    }
    interface ICheckIn
    {
        void CheckIn();
    }
    #endregion
    #region Practice2
    class Sparrow:IFly,IWalk
    {
       public void Fly()
        {
            Console.WriteLine("能飞");
        }
        public void Walk()
        {
            Console.WriteLine("能走");
        }
    }
    /// <summary>
    /// 鸵鸟
    /// </summary>
    class ostrich:IWalk
    {
        public void Walk()
        {
            Console.WriteLine("能走");
        }
    }
    class Penguin:ISwim, IWalk
    {
        void ISwim.Fly()
        {
            Console.WriteLine("会游泳");
        }
        public void Walk()
        {
            Console.WriteLine("能走");
        }
}
    class Parrot : IFly, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("能飞");
        }
        public void Walk()
        {
            Console.WriteLine("能走");
        }
}
    class Helicopter : IFly
    {
        public void Fly()
        {
            Console.WriteLine("能飞");
        }
    }
    class Swan : IFly,ISwim,IWalk
    {
        void IFly.Fly()
        {
            Console.WriteLine("能飞");
        }
        void ISwim.Fly()
        {
            Console.WriteLine("会游泳");
        }
        public void Walk()
        {
            Console.WriteLine("能走");
        }
    }
    interface IFly
    {
        void Fly();
    }
    interface ISwim 
    {
        void Fly();    
    }
    interface IWalk
    {
        void Walk();
    }
    #endregion
    class Program 
    {
        static void Main(string[] args)
        {
            ICheckIn pCheckIn = new Person();
            pCheckIn.CheckIn();
            ICheckIn cCheckIn = new Car();
            cCheckIn.CheckIn();
            ICheckIn hCheckIn = new House();
            hCheckIn.CheckIn();

            Swan swan = new Swan();
            IFly swanFly = new Swan();
            ISwim swimFly = new Swan();

            swanFly.Fly();
            swimFly.Fly();

            (swan as IFly).Fly();
            swan.Walk();



        }
    }
}
