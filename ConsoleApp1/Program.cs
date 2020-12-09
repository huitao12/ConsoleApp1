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
            User.Register();
            User.Login();

            //    DateTime mimicNow = new DateTime(13);
            //    //Console.WriteLine(DateTime.Now);
            //    Console.WriteLine(mimicNow.Hour);
            //DateTime dateTime = new DateTime(2019, 12, 1, 19, 52, 24);
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.Day);//Year/Month
            //Console.WriteLine(DateTime.Now.ToString( "yyyy年MM月dd日 hh点mm分ss秒"));

            //string result = logon("ut91", "yezi", "1212");//调用
            //showStudent(new string[] { "阿泰", "龚廷义", "刘伟", "廖光银", "周丁浩", "李智博", "邹丽", "胡涛" });
            //getArray(1, 5);
            //getArray(1, 9, 2);
            //calculate(100);
            ////将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] acores = { 81.3, 74.2, 67.2, 65.7, 95.5, 85.5, 57.2, 85.3, 84.1, 100, 152 };
            //getMax(acores);
            //getMin(acores);
            ////find(100);
            ////计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //double[] grade1 = { 64.23, 65.44, 83.54, 75.35, 95.18, 54.66 };
            //Console.WriteLine(Math.Round(GetAverage(grade1), 2));
            ////将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            ////LogOn("灰堆", "1223");
            ////利用ref调用Swap()方法交换两个同学的床位号
            //int bunk1 = 111, bunk2 = 222;
            //swap(ref bunk1, ref bunk2);
            ////http://17bang.ren/Article/641
            ////方法进阶：参数：重载/可选/params 
            ///第一题
            //GetArray();
            ///第二题
            BinarySeek(new int[] { 1, 3, 6, 9, 23, 28, 32, 42, 53, 66 });
        }

        //http://17bang.ren/Article/299
        //将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。

        /// <summary>
        /// 登录界面
        /// </summary>
        /// <param name="code">验证码</param>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        static string logon(string code, string name, string password)
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
                return "验证码错误";
            }
            else
            {
                Console.WriteLine("验证码正确");
                if ("yezi" != name)
                {
                    return "用户名不存在";
                }
                else
                {
                    Console.WriteLine("用户名存在");

                    if ("1212" != password)
                    {
                        return "用户名或密码错误";
                    }
                    else
                    {
                        return "恭喜！登陆成功！";
                    }
                }
            }


        }

        /// <summary>
        /// 一维数组/用for循环输出
        /// </summary>
        /// <param name="names">同学姓名</param>
        static void showStudent(string[] names)
        {
            //    将源栈同学姓名 / 昵称分别：
            //    按进栈时间装入一维数组，/ //用for循环输出存储在一维
            //    按座位装入二维数组，
            //    并输出共有多少名同学。

            //string[] time = name;
            string[] schoolmate = names;
            for (int i = 0; i < schoolmate.Length; i++)
            {
                Console.WriteLine(schoolmate[i]);
            }

        }

        /// <summary>
        /// 循环
        /// </summary>
        /// <param name="start">起始值</param>
        /// <param name="end">结束值</param>
        static void getArray(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i); ;
            }

            int j = start;
            while (j <= end)
            {
                Console.WriteLine(j);
                j += 1;
            }

        }

        /// <summary>
        /// 循环
        /// </summary>
        /// <param name="start"起始值</param>
        /// <param name="end">结束值</param>
        /// <param name="skip">间隔2</param>
        static void getArray(int start, int end, int skip)
        {
            int i = start;
            while (i <= end)
            {
                Console.WriteLine(i);
                i += skip;
            }

            for (int j = start; j <= end; j += skip)
            {
                Console.WriteLine(j);
            }
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

        /// <summary>
        /// z找到最大值
        /// </summary>
        /// <param name="acores">成绩</param>
        /// <returns></returns>
        static double getMax(double[] acores)
        {
            double max = acores[0];
            for (int i = 0; i < acores.Length; i++)
            {
                if (acores[i] > max)
                {
                    max = acores[i];
                }//else do nothing
            }
            return max;
        }
        /// <summary>
        /// 找到最小值
        /// </summary>
        /// <param name="acores">成绩</param>
        /// <returns></returns>
        static double getMin(double[] acores)
        {
            double min = acores[0];
            for (int i = 0; i < acores.Length; i++)
            {
                if (acores[i] < min)
                {
                    min = acores[i];
                }//else do nothing
            }
            return min;
        }


        /// <summary>
        ///number以内的质数
        /// </summary>
        /// <param name="number">最大值</param>
        //static int[] find(int number)
        //{
        //找到100以内的所有质数（只能被1和它自己整除的数）

        //for (int i = 2; i < number; i++)
        //{
        //    bool isprime = true;//isprime是质数还是不是质数
        //    for (int j = 2; j < i - 1; j++) //判断当前判断的数字是不是质数
        //    {
        //        if (i % j == 0) //说明不是质数
        //        {
        //            isprime = false;//不是质数
        //            break;
        //        }
        //    }
        //    if (isprime)//是质数
        //    {
        //        return i;
        //    }
        //}
        //    return 1;
        //}

        /// <summary>
        /// 计算成绩平均值
        /// </summary>
        /// <param name="grade1">同学的分数</param>
        /// <returns></returns>
        static double GetAverage(double[] grade1)
        {
            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()

            double sum = 0;
            for (int i = 0; i < grade1.Length; i++)
            {
                sum = sum + grade1[i];
            }
            double average = sum / grade1.Length;
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
        //    int result = r.Next(0, 1000);
        //    Console.WriteLine("输入一千以内的数：");
        //    int guess = int.TryParse(Console.ReadLine());
        //    for (int i = 10; i < 10; i++)
        //    {
        //        if (guess > result)
        //        {
        //            Console.WriteLine("太大了" + "（还剩1次）");
        //        }
        //        else
        //        {
        //            Console.WriteLine("太小了" + "还剩8次");
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
        //static /*bool*/void LogOn(string name, string password, out bool reason)
        //{
        //    password = "1223"; name = "灰堆";
        //    password = Console.ReadLine("输入用户名");
        //    if ("灰堆" != Console.ReadLine())
        //    {
        //        Console.WriteLine("请输入密码");
        //        if ("1223" != Console.ReadLine())
        //        {
        //            Console.WriteLine("恭喜！登陆成功！");
        //        }
        //        else
        //        {
        //            Console.WriteLine("密码错误");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("用户名错误");
        //    }
        //    return "1";
        //}


        /// <summary>
        /// 随机数
        /// </summary>
        /// <param name="min">起始值</param>
        /// <param name="gap">两个元素最大差</param>
        /// <param name="length">数组长度为10</param>
        /// <returns></returns>
        ////http://17bang.ren/Article/641
        ////方法进阶：参数：重载/可选/params 
        ////第一题
        ////定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
        ////最小值min（默认为1）
        ////相邻两个元素之间的最大差值gap（默认为5）
        ////元素个数length（默认为10个）

        static int[] GetArray(int min = 1, int gap = 5, int length = 10)
        {
            int[] array = new int[length];
            Random random = new Random();
            //array[0] = random.Next(10, 100);
            for (int i = min; i < array.Length; i++)
            {
                //array[i] += gap;
                //array = GetArray(min);

                array[i] = random.Next(gap) + array[i - 1];
                Console.WriteLine(array[i]);
                //array[i] += gap;

            }
            //Console.WriteLine(array);
            return array;
        }

        /// <summary>
        /// 二分查找 找到某个元素
        /// </summary>
        /// <param name="numbers">数组</param>
        /// <param name="target">找到28</param>
        /// <returns></returns>
        //第二题
        //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
        //传入一个有序（从大到小/从小到大）数组和数组中要查找的元素
        //如果找到，返回该元素所在的下标；否则，返回-1
        static int BinarySeek(int[] numbers, int target = 28)
        {
            int left = 0, right = numbers.Length - 1, middle = (left + right) / 2;
            bool result = false;
            while (left <= right)//left<rigth  就找不到边缘
            {
                middle = (left + right) / 2;
                if (numbers[middle] > target)
                {
                    right = middle - 1;
                }
                else if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    numbers[middle] = target;
                    result = true;//找到了，
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine(middle);//就输出下标
            }
            return -1;//没找到返回
        }





        //C#-面向对象：基础中的基础-类和对象
        //https://zhuanlan.zhihu.com/p/92362781
        //观察“一起帮”的：
        //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish(）
        //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //为这些类的字段和方法设置合适的访问修饰符



    }

}

