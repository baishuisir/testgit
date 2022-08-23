using System;
using System.Threading;

namespace FirstPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread t1 = new Thread(_ => {

                Console.WriteLine("hello you will win");
            });
            Class1.fun();
            Console.WriteLine("*********");

            Console.WriteLine("class2删除了");

            Console.WriteLine("分支1修改的");//分支1修改
            Console.WriteLine("分支1修改的再次xxxxxxx");//分支1修改
            Console.Read();
        }
    }
}
