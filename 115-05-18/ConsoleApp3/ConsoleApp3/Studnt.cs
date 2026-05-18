using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public string Name { get; set; }
        public int Ages { get; set; }

        public void ShowMessage() =>
        Console.WriteLine($"Hollo!{Name},年齡:{Ages}.");
    }
}
