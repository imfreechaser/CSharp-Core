using System;
//封装类中的数组的增删改查方法
//面向的使用者：不深入到类的内部的开发者，直接调用类的方法来进行类中数组的增删改查。
//数组的初始化：在类的构造函数中设置一个初始长度；
//增：每次在方法里传一个要增加的值，方法将值加在数组有效长度的后一位，当有效长度 = 数组容量时则自动给数组扩容一定空间； 
//删：指定一个数组的索引位置进行删除，将指定位后面的元素依次向前挪一位，然后数组有效长度-1;注意判断边界；
//改：通过索引器的方法在set访问器中设置对应索引位置值的修改，注意判断边界；
//查：通过索引器的方法在get访问器中访问对应索引位置的值，注意判断边界；
namespace Lesson6_封装_索引器
{
    class IntArray
    {
        public int[] array;
        int arrLth;
        int arrCap;

        public IntArray()
        {
            //设置有效长度,即外部用户看到的数组长度
            arrLth = 0;
            //设置数组容量
            arrCap = 5;

            array = new int[arrCap];
        }

        //增
        public void AddEle(int num)
        {
            if (arrLth < arrCap)
            {
                array[arrLth] = num;
                arrLth++;
            }
            else
            {
                arrCap += 5;
                int[] newArray = new int[arrCap];
                for (int i = 0; i < arrLth; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                array[arrLth++] = num;
                
            }
        }
        //删
        public void DeleteAt(int index)
        {
            if (index >= arrLth || index < 0)
            {
                Console.WriteLine("越界");
            }
            else
            {
                for (int i = index; i < arrLth - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[arrLth - 1] = 0;
                --arrLth;
            }
        }
        //改、查
        public int this[int index]
        {
            get
            {
                if (index >= arrLth || index < 0)
                {
                    Console.WriteLine("越界");
                    return -1;
                }
                else
                    return array[index];
            }
            set
            {
                if (index >= arrLth || index < 0)
                {
                    Console.WriteLine("越界");
                }
                else
                    array[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntArray arr2 = new IntArray();
            arr2.AddEle(3);
            arr2.AddEle(5);
            arr2.AddEle(7);
            arr2.AddEle(9);
            arr2.AddEle(11);
            arr2.AddEle(13);
            arr2.AddEle(15);
            arr2.AddEle(17);

            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);
            Console.WriteLine(arr2[2]);
            Console.WriteLine(arr2[3]);
            Console.WriteLine(arr2[4]);
            Console.WriteLine(arr2[5]);
            Console.WriteLine(arr2[6]);
            Console.WriteLine(arr2[7]);

            arr2[7] = 37;
            Console.WriteLine(arr2[7]);
            arr2.DeleteAt(5);
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);
            Console.WriteLine(arr2[2]);
            Console.WriteLine(arr2[3]);
            Console.WriteLine(arr2[4]);
            Console.WriteLine(arr2[5]);
            Console.WriteLine(arr2[6]);
            Console.WriteLine(arr2[7]);


        }
    }
}
