using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            WriteLine("請輸入你的名字");
            s1.Name = ReadLine();
            WriteLine("請輸入你的年齡");
            s1.Ages = int.Parse(ReadLine());
            s1.ShowMessage();

            ReadKey();
        }
    }
}
