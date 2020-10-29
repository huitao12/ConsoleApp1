using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 6;
            //int b = 2;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);

            //Console.WriteLine($"{a + b},{a - b},{a * b},{a / b}");

            //double a = 0.2;
            //double b = 0.4;
            //Console.WriteLine(a - b);
            //Console.WriteLine(a + b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);

            //Console.WriteLine($"{a - b},{a + b},{a * b},{a / b}");//字符串${}，{}，


            //  (1) 算出来是整数
            //int a = ((23 + 7) * 12 - 8) / 6;//整数转整数=整数
            //Console.WriteLine(a);

            //（2）**精确小数
            //double a =(double)((23 + 7) * 12 - 8) / 6;
            //int→→double 整数转小数，没报错是隐式转换 
            //int age = 23;
            //double dAge = age;
            //doubles双倍精确=double显示转换
            //Console.WriteLine(a);


            //强制转换 float+后缀F，decimal
            //float age=12.2F;
            //int a = (int)age;

            //decimal stature = 173;
            //int a = (int)stature;
            //Console.WriteLine(a);


            int i = 15;
            //onsole.WriteLine(i);//++i=16,i++=15
            i -= 5;
            Console.WriteLine(i);//i=10
            //Console.WriteLine(i >= 10);//true

            //Console.WriteLine("i值的最终结果为：" + i);//15

            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i + j}");//15+20=35


            //int a = 10;
            //Console.WriteLine(a > 9 && (!(a < 11) || a > 10));
            //false,！优先级高，(a < 11)为真  ‘！’取反 就为false，a>9 && false （&& bool值有一个false就为false）


            int a = 10;
            bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;

            Console.WriteLine(result);

        }
    }
}