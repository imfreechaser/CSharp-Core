using System;
using System.Text;

namespace Lesson23_面向对象_string
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1
            string myStr = "1|2|3|4|5|6|7";
            string[] str = myStr.Split('|');
            string myStr1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = (int.Parse(str[i]) + 1).ToString();
                Console.WriteLine(str[i]);
                myStr1 += str[i];
                if (i != str.Length - 1)
                    myStr1 += "|";
            }
            Console.WriteLine(myStr1);
            #endregion
            string str1 = "123";
            string str2 = str1;
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            str2 = "321";
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            StringBuilder strb = new StringBuilder("iam艾琳娜");

            strb[0] = 'I';
            Console.WriteLine(strb);
        }
    }
}
