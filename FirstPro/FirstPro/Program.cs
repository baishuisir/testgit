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
            Console.Read();
        }
    }
}
