using System;

namespace ConsoleApp2
{
    class LXT
    {
        static void Main(string[] args)
        {
            #region 循环


            //            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9

            //            //    用数组
            //            int[] age = { 1, 2, 3, 4, 5 };
            //            for (int i = 0; i < age.Length; i++)
            //            {
            //                Console.WriteLine(age[i]);
            //            }


            //            //不用数组
            //            for (int i = 1; i <= 5; i++)
            //            {
            //                Console.WriteLine(i);
            //            }

            //            int i = 1;
            //            while (i <= 5)
            //            {
            //                Console.WriteLine(i);
            //                i += 1;
            //            }

            //            //用数组输出
            //            int[] age = { 1, 3, 5, 7, 9 };
            //            int i = 0;//累加器
            //            while (i < age.Length)
            //            {
            //                Console.WriteLine(age[i]);
            //                i++;
            //            }


            //            //不用数组
            //            int i = 1;
            //            while (i <= 9)
            //            {
            //                Console.WriteLine(i);
            //                i += 2;
            //            }

            //            for (int i = 1; i <= 9; i++)
            //            {
            //                Console.WriteLine(i);
            //                i += 1;
            //            }

            //            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称

            //            string[] name = { "阿泰", "龚廷义", "刘伟", "廖光银", "周丁浩", "李智博", "皱丽", "胡涛" };
            //            for (int i = 0; i < name.Length; i++)
            //            {
            //                Console.WriteLine(name[i]);
            //            }


            //            string[,] seat = new string[3, 4];//多态
            //            seat[0, 0] = "龚廷义";
            //            seat[0, 1] = "刘伟";
            //            seat[1, 1] = "廖光银";
            //            seat[1, 2] = "周丁浩";
            //            seat[1, 3] = "李智博";
            //            seat[2, 0] = "胡涛";
            //            seat[2, 1] = "阿泰";
            //            seat[2, 2] = "皱丽";
            //            int b = 0;
            //            for (int i = 0; i < 3; i++)
            //            {
            //                for (int j = 0; j < 4; j++)
            //                {
            //                    if (seat[i, j] != null)
            //                    {
            //                        b++;
            //                        Console.WriteLine(seat[i, j]);
            //                    }
            //                }
            //            }
            //            Console.WriteLine(b);

            //            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值

            //            int sum = 0;
            //            for (int i = 1; i < 100; i += 2)//i++
            //            {
            //                sum += i;//sum+=i++;
            //            }
            //            Console.WriteLine(sum);

            //            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //            double[] grade = { 81.3, 74.2, 67.2, 65.7, 95.5, 85.5, 57.2, 85.3, 84.1, 100, 152 };
            //            double max = grade[0], min = grade[0];
            //            for (int i = 0; i < grade.Length; i++)
            //            {
            //                if (grade[i] > max)
            //                {
            //                    max = grade[i];
            //                }//else do nothing
            //                if (grade[i] < min)
            //                {
            //                    min = grade[i];
            //                }//else do nothing
            //            }
            //            Console.WriteLine(max);
            //            Console.WriteLine(min);


            //            //找到100以内的所有质数（只能被1和它自己整除的数）

            //            for (int i = 2; i < 100; i++)
            //            {
            //                bool a = true;
            //                for (int j = 2; j < i - 1; j++) //判断当前判断的数字是不是质数
            //                {
            //                    if (i % j == 0) //说明不是质数
            //                    {
            //                        a = false;
            //                    }
            //                }
            //                if (a)
            //                {
            //                    Console.WriteLine(i);
            //                }
            //            }


            //            //生成一个元素（值随机）从小到大排列的数组

            //            int[] receive = new int[10];

            //            for (int i = 0; i < receive.Length; i++)
            //            {
            //                receive[i] = new Random().Next(10, 50);
            //            }
            //            //这是只是为了输出
            //            //for (int i = 0; i < receive.Length; i++)
            //            //{
            //            //    Console.Write(receive[i] + ",");
            //            //}
            //            for (int i = 0; i < receive.Length - 1; i++)
            //            {
            //                for (int j = 0; j < receive.Length - 1 - i; j++)
            //                {
            //                    if (receive[j] > receive[j + 1])
            //                    {
            //                        int temp = receive[j];
            //                        receive[j] = receive[j + 1];
            //                        receive[j + 1] = temp;
            //                    }
            //                }
            //            }
            //            for (int i = 0; i < receive.Length; i++)
            //            {//只是为了输出数字
            //                Console.Write(receive[i] + ",");
            //            }



            //            int[] age = new int[10];
            //            for (int i = 0; i < age.Length; i++)
            //            {
            //                Random r = new Random();
            //                int temp = r.Next(10, 50);
            //                age[i] = temp;//生产随机10数组
            //            }
            //            //冒泡排序
            //            for (int i = 0; i < age.Length; i++)
            //            {
            //                for (int j = 0; j < age.Length - 1; j++)
            //                {
            //                    if (age[j] > age[j + 1])
            //                    {
            //                        int temp = age[j];
            //                        age[j] = age[j + 1];
            //                        age[j + 1] = temp;
            //                    }
            //                }
            //            }
            //            for (int i = 0; i < age.Length; i++)
            //            {
            //                Console.Write(age[i] + ",");
            //            }



            //            //生成一个数组从小到大排序

            //            int[] grade = { 52, 65, 2, 8, 45, 86, 98, 24, 32, 15, 71, 82, 91, -1 };
            //            for (int i = 1; i < grade.Length; i++)
            //            {
            //                for (int j = 0; j < grade.Length - 1; j++)
            //                {
            //                    if (grade[j] > grade[j + 1])
            //                    {
            //                        int temp = grade[j];
            //                        grade[j] = grade[j + 1];
            //                        grade[j + 1] = temp;
            //                    }
            //                }
            //            }
            //            for (int i = 0; i < grade.Length; i++)
            //            {
            //                Console.WriteLine(grade[i]);
            //            }

            //            //设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()


            //            int[,] seat = new int[3, 4];

            //            for (int i = 0; i < seat.GetLength(0); i++)
            //            {
            //                for (int j = 0; j < seat.GetLength(1); j++)
            //                {
            //                    seat[i, j] = i + j;
            //                    Console.Write(seat[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }


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
            #region 数组
            //            //将源栈同学姓名 / 昵称分别：
            //            //        按进栈时间装入一维数组，
            //            //        按座位装入二维数组，
            //            //    并输出共有多少名同学。

            //                string[] time = new string[] { "阿泰", "龚廷义", "刘伟", "廖光银", "周丁浩", "李智博", "皱丽", "胡涛" };

            //            string[,] seat = new string[3, 4];
            //            seat[0, 0] = "龚廷义";
            //            seat[0, 1] = "刘伟";
            //            seat[1, 1] = "廖光银";
            //            seat[1, 2] = "周丁浩";
            //            seat[1, 3] = "李智博";
            //            seat[2, 0] = "胡涛";
            //            seat[2, 1] = "阿泰";
            //            seat[2, 2] = "皱丽";

            //            int a = 0;
            //            for (int i = 0; i < 3; i++)
            //            {
            //                for (int j = 0; j < 4; j++)
            //                {
            //                    if (seat[i, j] != null)
            //                    {
            //                        Console.WriteLine(seat[i, j]);
            //                        a++;
            //                    }
            //                }
            //            }
            //            Console.WriteLine(a);
            #endregion
            #region 分支
            //            //用户依次由控制台输入：验证码、用户名和密码：
            //            //        如果验证码输入错误，直接输出：“*验证码错误”；
            //            //        如果用户名不存在，直接输出：“*用户名不存在”；
            //            //        如果用户名或密码错误，输出：“*用户名或密码错误”
            //            //        以上全部正确无误，输出：“恭喜！登录成功！”

            //            //    ps：验证码 / 用户名 / 密码直接预设在源代码中，输入由console.readline()完成。




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

            //        if ("1212" != Console.ReadLine())
            //        {
            //            Console.WriteLine("用户名或密码错误");
            //        }
            //        else
            //        {
            //            Console.WriteLine("密码正确");
            //            Console.WriteLine("恭喜！登陆成功！");
            //        }
            //    }
            //}
            #endregion
        }
      
    }
 }
