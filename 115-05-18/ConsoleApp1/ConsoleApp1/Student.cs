using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {

           private string name; //類別的欄位
        
            
        //定義方法--設定名字，接受參數，存取範圍公開
        public void InputName(string title) => name = title;


        //定義方法--取得名字，return敘述回傳name
        public string ShowName() => name;
    }
}



