using System;

//备注，快捷键 command+/
namespace P01_Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "YaoLei";
            Console.WriteLine("姓名为:{0}", name);  //输出语句学习
            var age = Convert.ToInt32(Console.ReadLine());  //输出语句学习 
            Console.WriteLine("年龄为：{0}", age);
        }
    }
}