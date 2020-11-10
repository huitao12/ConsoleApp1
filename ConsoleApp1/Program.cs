using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Net.Mail;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Resolvers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 循环
            //int target = 13;
            //int[] age = { 2, 6, 13, 25, 47, 56, 83 };

            //for (int i = 0; i < age.Length; i++)
            //{
            //    if (age[i] == 13)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}






            // 分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9

            //用数组
            //int[] age = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < age.Length; i++)
            //{
            //    Console.WriteLine(age[i]);
            //}


            //不用数组
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i+=1;
            //}

            //用数组输出
            //int[] age = { 1, 3, 5, 7, 9 };
            //int i = 0;//累加器
            //while (i<age.Length)
            //{
            //    Console.WriteLine(age[i]);
            //    i++;
            //}


            //不用数组
            //int i = 1;
            //while (i <= 9)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.WriteLine(i);
            //    i+=1;
            //}

            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称

            //string[] name = { "阿泰", "龚廷义", "刘伟", "廖光银", "周丁浩", "李智博", "皱丽", "胡涛" };
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}


            //string[,] seat = new string[3 ,4];//多态
            //seat[0, 0] = "龚廷义";
            //seat[0, 1] = "刘伟";
            //seat[1, 1] = "廖光银";
            //seat[1, 2] = "周丁浩";
            //seat[1, 3] = "李智博";
            //seat[2, 0] = "胡涛";
            //seat[2, 1] = "阿泰";
            //seat[2, 2] = "皱丽";
            //int b = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (seat[i, j] != null)
            //        {
            //            b++;
            //            Console.WriteLine(seat[i, j]);
            //        }
            //    }
            //}
            //Console.WriteLine(b);

            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值

            //int sum = 0;
            //for (int i = 1; i < 100; i+=2)//i++
            //{
            //    sum += i;//sum+=i++;
            //}
            //Console.WriteLine(sum);

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] grade = { 81.3, 74.2, 67.2, 65.7, 95.5, 85.5, 57.2, 85.3, 84.1, 100, 152};
            //double max = grade[0], min = grade[0];
            //for (int i = 0; i < grade.Length; i++)
            //{
            //    if (grade[i] > max)
            //    {
            //        max = grade[i];
            //    }//else do nothing
            //    if (grade[i] < min)
            //    {
            //        min = grade[i];
            //    }//else do nothing
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);


            ////找到100以内的所有质数（只能被1和它自己整除的数）

            //for (int i = 2; i < 100; i++)
            //{
            //    bool a = true;
            //    for (int j = 2; j < i - 1; j++) //判断当前判断的数字是不是质数
            //    {
            //        if (i % j == 0) //说明不是质数
            //        {
            //            a = false;
            //        }
            //    }
            //    if (a)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //生成一个元素（值随机）从小到大排列的数组


            int[] age = new int[10];
            for (int i = 0; i < age.Length; i++)
            {
                Random r = new Random();
                int temp = r.Next(10, 80);
                age[i] = temp;//生产随机10数组
            }
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(age[i]);

            }


            //生成一个数组从小到大排序

            //int[] grade = { 52, 65, 2, 8, 45, 86, 98, 24, 32, 15, 71, 82, 91, -1 };
            //for (int i = 1; i < grade.Length; i++)
            //{
            //    for (int j = 0; j < grade.Length - 1; j++)
            //    {
            //        if (grade[j] > grade[j + 1])
            //        {
            //            int temp = grade[j];
            //            grade[j] = grade[j + 1];
            //            grade[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < grade.Length; i++)
            //{
            //    Console.WriteLine(grade[i]);
            //}

            //设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()











            //int[] age = { 4, 11, 25, 29, 33, 37, 46, 57, 60, 71, 86, 92 };
            //int[,] seat = new int[3, 4];
            //int sum = 0, array = 0;

            ////seat[0, 0] = 4;
            ////seat[0, 1] = 11;
            ////seat[0, 2] = 25;
            ////seat[0, 3] = 29;
            ////seat[1, 0] = 33;
            ////seat[1, 1] = 37;
            ////seat[1, 2] = 46;
            ////seat[1, 3] = 57;
            ////seat[2, 0] = 60;
            ////seat[2, 1] = 71;
            ////seat[2, 2] = 86;
            ////seat[2, 3] = 92;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(i);
            //        Console.WriteLine(j);
            //        sum = i + j;
            //    }
            //}
            //Console.WriteLine(sum);

            #endregion
            #region 数组
            //        将源栈同学姓名 / 昵称分别：
            //    按进栈时间装入一维数组，
            //    按座位装入二维数组，
            //并输出共有多少名同学。

            //string[] time = new string[] { "阿泰", "龚廷义", "刘伟", "廖光银", "周丁浩", "李智博", "皱丽", "胡涛" };

            //string[,] seat = new string[3, 4];
            //seat[0, 0] = "龚廷义";
            //seat[0, 1] = "刘伟";
            //seat[1, 1] = "廖光银";
            //seat[1, 2] = "周丁浩";
            //seat[1, 3] = "李智博";
            //seat[2, 0] = "胡涛";
            //seat[2, 1] = "阿泰";
            //seat[2, 2] = "皱丽";

            //int a = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (seat[i, j] != null)
            //        {
            //            Console.WriteLine(seat[i, j]);
            //            a++;
            //        }
            //    }
            //}
            //Console.WriteLine(a);
            #endregion
            #region 分支
            //用户依次由控制台输入：验证码、用户名和密码：
            //    如果验证码输入错误，直接输出：“*验证码错误”；
            //    如果用户名不存在，直接输出：“*用户名不存在”；
            //    如果用户名或密码错误，输出：“*用户名或密码错误”
            //    以上全部正确无误，输出：“恭喜！登录成功！”

            //ps：验证码 / 用户名 / 密码直接预设在源代码中，输入由console.readline()完成。




            //if ("ut91" != Console.ReadLine())
            //{
            //    Console.WriteLine("验证码错误");
            //}
            //else
            //{
            //    Console.WriteLine("验证码正确");
            //    if ("yezi" != Console.ReadLine())
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名存在");

            //            if ("1212" != Console.ReadLine())
            //            {
            //                Console.WriteLine("用户名或密码错误");
            //            }
            //                else
            //                {
            //                    Console.WriteLine("密码正确"); 
            //                    Console.WriteLine("恭喜！登陆成功！"); 
            //                }
            //    }
            //}
            #endregion
        }
        static int find(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 13)
                {
                    return i;
                    //Console.WriteLine(i);
                }
            }
            return -1;
        }
    }
}
