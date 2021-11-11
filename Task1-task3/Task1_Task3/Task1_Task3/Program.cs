using System;
using System.Collections.Generic;

namespace Task1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //List<int> list = new List<int> { 1, 2, 3, 4 };

            //string str = "";
            //foreach (var item in MultiList(list))
            //{
            //    str = str + item + " ";
            //}
            //Console.WriteLine(str);

            #endregion

            #region Task2

            //List<int> list = new List<int> { 1, 2, 3, 4 };

            //string str = "";

            //foreach (var item in ThreeTimeList(list))
            //{
            //    str = str + item + " ";
            //}
            //Console.WriteLine(str);

            #endregion

            #region Task3

            List<string> strlist = new List<string> { "A", "B", "C", "D" };

            string str = "";

            foreach (var item in AddChar(strlist)) 
            {
                str = str + item + " ";
            }
            Console.WriteLine(str);

            #endregion
        }

        #region Task1 Method
        public static List<int> MultiList(List<int> number)
        {
            List<int> listmethod = new List<int>();

            foreach (var item in number)
            {
                listmethod.Add(item * 3);
            }
            return listmethod;
        }

        #endregion

        #region Task2 Method

        public static List<int> ThreeTimeList(List<int> number)
        {
            List<int> listmethod = new List<int>();

            int res = 1;

            foreach (var item in number)
            {
                int num = item;
                
                for (int i = 0; i < 3; i++)
                {
                    res *= num;
                }

                listmethod.Add(res);
                res = 1;
            }
            return listmethod;
        }

        #endregion

        #region Task3 Method

        public static List<string> AddChar(List<string> list)
        {
            List<string> strlistmethod = new List<string>();

            foreach (var item in list)
            {
                strlistmethod.Add($"#{item}#");
            }
            return strlistmethod;
        }

        #endregion
    }
}
