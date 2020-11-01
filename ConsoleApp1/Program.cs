using System;
using System.Diagnostics.SymbolStore;
using System.Net.Mail;
using System.Xml.Resolvers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            用户依次由控制台输入：验证码、用户名和密码：

            //    如果验证码输入错误，直接输出：“*验证码错误”；
            //    如果用户名不存在，直接输出：“*用户名不存在”；
            //    如果用户名或密码错误，输出：“*用户名或密码错误”
            //    以上全部正确无误，输出：“恭喜！登录成功！”

            //PS：验证码 / 用户名 / 密码直接预设在源代码中，输入由Console.ReadLine()完成。


            string readLine = Console.ReadLine();
            string verification = "ut91";
            string username = "yezi";
            string password = "1212";

            if (verification != readLine)
            {
                Console.WriteLine("验证码错误");
            }
            else
            {
                Console.WriteLine("验证码正确");
                string WriteLine=Console.ReadLine();
                if (username != WriteLine)
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    Console.WriteLine("用户名存在");
                }
            }


            if (username != "yezi")
            {
                Console.WriteLine("用户名错误");
            }
            else
            {
                Console.WriteLine("用户名正确");
                string WriteLine = Console.ReadLine();
                if (password != "1212")
                {
                    Console.WriteLine("密码错误");
                }
                else
                {
                    Console.WriteLine("密码正确");
                }
                    Console.WriteLine("恭喜！登陆成功！");


            }





            //string[,] mda = new string[4, 8];
            //mda[0, 0] = "龚廷义";
            //mda[0, 1] = "刘伟";
            //mda[1, 1] = "廖光银";
            //mda[1, 2] = "周丁浩";
            //mda[1, 3] = "李智博";
            //mda[2, 1] = "胡涛";
            //mda[2, 2] = "阿泰";
            //mda[2, 3] = "邹丽";
            //string[,] mda = {  };
            //Console.WriteLine(mda);

            //string[] time = { "2020.08.20" };
            //Console.WriteLine(time[]);




        }
    }
}
