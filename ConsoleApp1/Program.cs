using System;
using System.Diagnostics.SymbolStore;
using System.Net.Mail;
using System.Numerics;
using System.Xml.Resolvers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {




            #region 数组
            //        将源栈同学姓名 / 昵称分别：
            //    按进栈时间装入一维数组，
            //    按座位装入二维数组，
            //并输出共有多少名同学。

            string[] time = new string[] { "阿泰", "龚廷义", "刘伟", "廖光银", "周丁浩", "李智博", "皱丽", "胡涛" };

            string[,] seat = new string[3, 4];
            seat[0, 0] = "龚廷义";
            seat[0, 1] = "刘伟";
            seat[1, 1] = "廖光银";
            seat[1, 2] = "周丁浩";
            seat[1, 3] = "李智博";
            seat[2, 0] = "胡涛";
            seat[2, 1] = "阿泰";
            seat[2, 2] = "皱丽";
            
            Console.WriteLine(time.Length);
            #endregion
            #region 分支
            //用户依次由控制台输入：验证码、用户名和密码：
            //    如果验证码输入错误，直接输出：“*验证码错误”；
            //    如果用户名不存在，直接输出：“*用户名不存在”；
            //    如果用户名或密码错误，输出：“*用户名或密码错误”
            //    以上全部正确无误，输出：“恭喜！登录成功！”

            //ps：验证码 / 用户名 / 密码直接预设在源代码中，输入由console.readline()完成。



            //string readline = console.readline();
            //string verification = "ut91";
            //string username = "yezi";
            //string password = "1212";

            //if (verification != readline)
            //{
            //    console.writeline("验证码错误");
            //}
            //else
            //{
            //    console.writeline("验证码正确");
            //    string writeline = console.readline();
            //    if (username != writeline)
            //    {
            //        console.writeline("用户名不存在");
            //    }
            //    else
            //    {

            //        if (username != "yezi")
            //        {
            //            console.writeline("用户名错误");
            //        }
            //        else
            //        {
            //            console.writeline("用户名正确");
            //            string readline = console.readline();
            //            if (password != readline)
            //            {
            //                console.writeline("密码错误");
            //            }
            //            else
            //            {
            //                if (password != "1212")
            //                {
            //                    console.writeline("密码错误");

            //                }
            //                else
            //                {
            //                    console.writeline("密码正确");
            //                    console.writeline("恭喜！登陆成功！");
            //                }

            //            }




            //        }

            //    }
            //}
            #endregion
        }
    }
}
