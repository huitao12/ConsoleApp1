using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class User
    {
        public static string name /*= "小哥"*/;
        private static int Password /*= 2123*/;
        public static string InvitedBy /*= "小弟"*/;
        public static void Register()
        {
            name = "小哥";
            Password = 123;
            InvitedBy = "小弟";
            //Console.WriteLine(name/*,Password,InvitedBy*/);
        }
        public static string  Login(/*User user*/)
        {
            if (name != "小哥" || Password != 2123)
            {
              return "用户名或者密码错误";
            }
            //else
            //{
            //    Console.WriteLine("登录成功");
            //}
            return "登录成功";
        }

    }
}
