using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            
            {
                //建立兩個物件並實體化
                Student s1 = new Student();
                Student s2 = new Student();

                //ShowName() 方法傳入參數
                s1.InputName("Toams Dalton");
                s2.InputName("Emily VanCamp");

                //InputName() 方法傳入參數
                WriteLine($"第一個學生{s1.ShowName()}");
                WriteLine($"第二個學生{s2.ShowName()}");
                ReadKey();

            }
        }
    }
}

