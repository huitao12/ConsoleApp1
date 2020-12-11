using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class User
    {
        //C#-面向对象：基础中的基础-类和对象
        //https://zhuanlan.zhihu.com/p/92362781
        //观察“一起帮”的：
        //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish(）
        //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //为这些类的字段和方法设置合适的访问修饰符

        public /*static*/  string Name/* = "小哥"*/;
        public /*static*/  string Password/* = "a2123"*/;
        public  /*static*/  string InvitedBy /*= "小弟"*/;
        public static string Register(User user)
        {
            if (user.Name != "小哥")
            {
                return "用户名不存在";
            }
            if (user.InvitedBy != "小弟")
            {
                return "邀请人不存在";
            }
            return "注册成功";
            //Name = "小哥";
            //Password = 2123;
            //InvitedBy = "小弟";
            //Console.WriteLine(Name/*,Password,InvitedBy);
        }
        public static string Login(User user)
        {
            if (user.Name != "小哥" || user.Password != "qw123")
            {
                return "用户名或者密码错误";
            }
            //else
            //{
            //    Console.WriteLine("登录成功");
            //}
            return "登录成功";
        }
        public double grade;
        public double age;
        //public static void Stature(User user) 
        //{
        //    user.age++;
        //}
    }
}
