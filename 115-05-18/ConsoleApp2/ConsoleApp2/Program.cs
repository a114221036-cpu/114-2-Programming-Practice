using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
           Person p1=new Person();
           WriteLine("請輸入你的名字");
            p1.Name = ReadLine();
            p1.Display();
            ReadKey();

            Person p2 = new Person();
            WriteLine("請輸入你的名字");
            p1.Name = ReadLine();
            p1.Display();
            ReadKey();
        }
    }
}
