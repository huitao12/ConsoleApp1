using System;
using System.Xml.Resolvers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string verification = Console.ReadLine();
            verification = "ut91";
            string UserName = "yizi";
            //string password = "";

            if (verification != "verification") 
            {
                Console.WriteLine("验证码错误");
            }
            else
            {
                Console.WriteLine("验证码正确");
            }
            if (UserName != "UserName") 
            {
                Console.WriteLine("用户名不存在");
            }
            else
            {
                Console.WriteLine("用户名存在");
            }


        }
    }
}
