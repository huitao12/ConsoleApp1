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







            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] grade = { 81.3, 74.2, 67.2, 65.7, 95.5, 85.5, 57.2, 85.3, 84.1, 100, 152 };
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




            //生成一个元素（值随机）从小到大排列的数组


            //int[] age = new int[10];
            //Random random = new Random();
            //age[0] = random.Next(7);
            //for (int i = 1; i < 100; i++)
            //{
            //    age[i] = random.Next() + age[i - 1];
            //}



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


            //int[,] seat = new int[3, 4];
            //for (int i = 0; i < seat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        Console.Write(i+ j + " ");
            //    }
            //    Console.WriteLine();
            //}


            //二分查找：在有序数组里面找到某个值
            //int[] array = { 1, 3, 9, 12, 17,23, 28, 33 ,35};
            //int left = 0, right = array.Length-1 , middle = (left + right) / 2;
            //int target = 3;
            //bool result = false;
            //while (left<=right )//left<rigth  就找不到边缘
            //{
            //    middle = (left + right) / 2;
            //    if (array[middle] >target )
            //    {
            //        right = middle - 1;
            //    }
            //    else if (array[middle] < target)
            //    {
            //        left = middle + 1;
            //    }
            //    else
            //    {
            //        array[middle] = target;
            //        result = true ;//找到了就输出下标，
            //        break;
            //    }
            //}
            //if (result )
            //{
            //    Console.WriteLine(middle);
            //}
            //else
            //{
            //    Console.WriteLine("找不到");
            //}


            #endregion


            string result = Judge("ut91", "yezi", "1212");//调用
            student(new string[] { "阿泰", "龚廷义", "刘伟", "廖光银", "周丁浩", "李智博", "邹丽", "胡涛" });
            circulation(5, 9);
            calculate(100);
            //seek(new double[] { 81.3, 74.2, 67.2, 65.7, 95.5, 85.5, 57.2, 85.3, 84.1, 100, 152 });
            find(100);
            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            double[] grade = { 64.23, 65.44, 83.54, 75.35, 95.18, 54.66 };
            Console.WriteLine(Math.Round(GetAverage(grade), 2));
            //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            LogOn("ut91", "yezi", "121");
        }

        //http://17bang.ren/Article/299
        //将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。

        /// <summary>
        /// 登录界面
        /// </summary>
        /// <param name="code">验证码</param>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        static string Judge(string code, string name, string password)
        {
            //将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。
            //用户依次由控制台输入：验证码、用户名和密码：
            //    如果验证码输入错误，直接输出：“*验证码错误”；
            //    如果用户名不存在，直接输出：“*用户名不存在”；
            //    如果用户名或密码错误，输出：“*用户名或密码错误”
            //    以上全部正确无误，输出：“恭喜！登录成功！”
            //ps：验证码 / 用户名 / 密码直接预设在源代码中，输入由console.readline()完成。

            if ("ut91" != code)
            {
                Console.WriteLine("验证码错误");
            }
            else
            {
                Console.WriteLine("验证码正确");
                if ("yezi" != name)
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    Console.WriteLine("用户名存在");

                    if ("1212" != password)
                    {
                        Console.WriteLine("用户名或密码错误");
                    }
                    else
                    {
                        //    Console.WriteLine("密码正确");
                        //    Console.WriteLine("恭喜！登陆成功！");
                        return "恭喜！登陆成功！";
                    }
                }
            }
            return "用户名或密码错误";

        }

        /// <summary>
        /// 一维数组/用for循环输出
        /// </summary>
        /// <param name="name">同学姓名</param>
        static string student(string[] name)
        {
            //    将源栈同学姓名 / 昵称分别：
            //    按进栈时间装入一维数组，/ //用for循环输出存储在一维
            //    按座位装入二维数组，
            //    并输出共有多少名同学。

            //string[] time = name;
            string[] schoolmate = name;
            for (int i = 0; i < schoolmate.Length; i++)
            {
                //Console.WriteLine(schoolmate[i]);
                return schoolmate[i];
            }
            return "1";
        }

        /// <summary>
        /// 用for跟while循环输出
        /// </summary>
        /// <param name="length">5</param>
        /// <param name="odd">9</param>
        static void circulation(int length, int odd)
        {
            //for (int i = 1; i <= length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int j = 1;
            //while (j <= 5)
            //{
            //    Console.WriteLine(j);
            //    j += 1;
            //}

            //int k = 1;
            //while (k <= odd)
            //{
            //    Console.WriteLine(k);
            //    k += 2;
            //}

            //for (int l = 1; l <= odd; l += 2)//i++
            //{
            //    Console.WriteLine(l);
            //    //i += 1;
            //}


        }

        /// <summary>
        /// 一百以内奇数的和
        /// </summary>
        /// <param name="number">最大值</param>
        static int calculate(int number)
        {
            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值

            int sum = 0;
            for (int i = 1; i < number; i += 2)//i++
            {
                sum += i;//sum+=i++;
            }
            return sum;
            //Console.WriteLine(sum);

        }

        static void rank(double array)
        {
            ////将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] grade = { 81.3, 74.2, 67.2, 65.7, 95.5, 85.5, 57.2, 85.3, 84.1, 100, 152 };
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
        }

        /// <summary>
        ///一百以内的质数
        /// </summary>
        /// <param name="number">最大值</param>
        static int find(int number)
        {
            ////找到100以内的所有质数（只能被1和它自己整除的数）

            for (int i = 2; i < number; i++)
            {
                bool isprime = true;//isprime是质数还是不是质数
                for (int j = 2; j < i - 1; j++) //判断当前判断的数字是不是质数
                {
                    if (i % j == 0) //说明不是质数
                    {
                        isprime = false;//不是质数
                        break;
                    }
                }
                if (isprime)//是质数
                {
                    return i;
                }
            }
            return 1;
        }
        /// <summary>
        /// 计算成绩平均值
        /// </summary>
        /// <param name="grade">同学的分数</param>
        /// <returns></returns>
        static double GetAverage(double[] grade)
        {
            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()

            double sum = 0, average;
            for (int i = 0; i < grade.Length; i++)
            {
                sum = sum + grade[i];
            }
            average = sum / grade.Length;
            return average;
        }

        //完成“猜数字”游戏，方法名GuessMe()：
        //随机生成一个大于0小于1000的整数
        //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        //没猜中可以继续猜，但最多不能超过10次
        //如果5次之内猜中，输出：你真牛逼！
        //如果8次之内猜中，输出：不错嘛！
        //10次还没猜中，输出：(～￣(OO)￣)ブ
        //static void GuessMe()
        //{
        //    Random r = new Random();
        //    int temp = r.Next(0, 1000);


        //    int week = 528, middle;
        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        if (left < 528)
        //        {
        //            Console.WriteLine("太小了")次数—1;
        //            j--;
        //            break;
        //        }
        //        else if (right > 528)
        //        {
        //            Console.WriteLine("太大了");
        //            j--;
        //        }

        //        if (middle == week)
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //}


        //http://17bang.ren/Article/303
        //利用ref调用Swap()方法交换两个同学的床位号

        /// <summary>
        /// 交换床位
        /// </summary>
        /// <param name="bunk1">一号床</param>
        /// <param name="bunk2">二号床</param>
        static void swap(ref int bunk1, ref int bunk2)
        {
            int temp = bunk1;
            bunk1 = bunk2;
            bunk2 = temp;
        }


        //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //true/false，表示登陆是否成功
        //string，表示登陆失败的原因
        static bool LogOn(string code, string name, string password)
        {




            if ("ut91" != code)
            {
                Console.WriteLine("验证码错误");
            }
            else
            {
                Console.WriteLine("验证码正确");
                if ("yezi" != name)
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    Console.WriteLine("用户名存在");

                    if ("1212" != password)
                    {
                        Console.WriteLine("用户名或密码错误");
                    }
                    else
                    {
                        //Console.WriteLine("密码正确");
                        //Console.WriteLine("恭喜！登陆成功！");
                        return true;
                    }
                }
            }
            return false;
        }



    }

}

