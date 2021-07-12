using System;

namespace Lesson16_封装_密封类
{
    class Person
    {
        public string name;
        public string vocation;
    }
    class Driver : Person
    {

    }
    class Passenger : Person
    {

    }
    class Vehicle
    {
        public Vehicle()
        {
            capaAvailable = 2;
            passengers = new Passenger[capaAvailable];
            maxSpeed = 50f;
            nowPassengersAmt = 0;
        }

        public float speed;
        public float maxSpeed;
        public int capaAvailable;
        public Driver d1;
        public Passenger[] passengers;
        public int nowPassengersAmt;

        public void GetOn(Passenger p)
        {
            if (nowPassengersAmt + 1 <= capaAvailable)
            {
                passengers[nowPassengersAmt] = p;
                nowPassengersAmt++;
            }
            else
                Console.WriteLine("车已满载，无法再载乘客！");
        }
        public void GetOff(Passenger p)
        {
            for (int i = 0; i < passengers.Length; i++)
            {
                if(i == passengers.Length - 1)
                {
                    if (passengers[i] == p)
                        passengers[i] = null;
                }
                else
                {
                    if (passengers[i] == p)
                    {
                        passengers[i] = passengers[i + 1];
                        if(i != passengers.Length - 2)
                            passengers[i + 1] = p;
                    }
                }
            }
        }
        public void Drive()
        {

        }
        public void Accident()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bus = new Vehicle();
            Passenger p1 = new Passenger();
            p1.name = "p1";
            Passenger p2 = new Passenger();
            p2.name = "p2";
            Passenger p3 = new Passenger();
            p3.name = "p3";
            Passenger p4 = new Passenger();
            p4.name = "p4";
            Console.WriteLine(bus.nowPassengersAmt);
            bus.GetOn(p1);
            Console.WriteLine(bus.nowPassengersAmt);
            bus.GetOn(p2);
            Console.WriteLine(bus.nowPassengersAmt);
            bus.GetOn(p3);
            Console.WriteLine(bus.nowPassengersAmt);
            bus.GetOn(p4);
            Console.WriteLine(bus.nowPassengersAmt);
            Driver d = new Driver();
            bus.d1 = d;
            bus.GetOff(p3);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(bus.passengers[i].name);
            //}

        }
    }
}
