using System;

namespace Lesson6_封装_索引器
{
    class IntArray
    {
        int[] array;

        public IntArray(int length)
        {
            array = new int[length];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void AddElements(int amount)
        {
            int[] arrayNew = new int[array.Length + amount];
            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = array[i];
            }
            array = arrayNew;
        }
        public void DelElements(int amount)
        {
            if(amount >= array.Length)
            {
                Console.WriteLine("删除的元素数量不能大于等于数组长度！");
            }
            else
            {
                int[] arrayNew = new int[array.Length - amount]; ;
                for (int i = 0; i < arrayNew.Length; i++)
                {
                    arrayNew[i] = array[i];
                }
                array = arrayNew;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntArray a1 = new IntArray(10);
            Console.WriteLine(a1[0]);
            a1[0] = 5;
            Console.WriteLine(a1[0]);
            a1.AddElements(3);
            a1[10] = 10; a1[11] = 11; a1[12] = 12;
            Console.WriteLine(a1[10]);
            Console.WriteLine(a1[11]);
            Console.WriteLine(a1[12]);
            a1.DelElements(3);
            Console.WriteLine(a1[9]);
            Console.WriteLine(a1[8]);
            Console.WriteLine(a1[7]);
        }
    }
}
