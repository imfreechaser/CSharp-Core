using System;

namespace Lesson2_成员变量和访问修饰符
{
    class Human
    {
        public string name;
        public float height;
        public int age;
        public string address;
    }

    class Student
    {
        public string name;
        public int studentNum;
        public int age;
        public Student deskmate;

        public void Study() { }
    }
    class Class
    {
        public string majorName;
        public int teacherAmout;
        public Student[] students;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            Human h2 = new Human();
            Human h3 = new Human();
            Human h4 = new Human();

            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.Study();
            s1.deskmate = new Student();
            s1.deskmate.age = 10;
            s2 = s1.deskmate;
            s2.age = 20;
            Console.WriteLine(s1.deskmate.age);
            
        }
    }
}
