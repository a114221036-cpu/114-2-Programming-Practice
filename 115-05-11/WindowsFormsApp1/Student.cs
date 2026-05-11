using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Student
    {
        private string name; //name姓名欄位宣告為private
        private int _score;  //_score姓名欄位宣告為private

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score   //建立Score屬性，此屬性限制在0-100
            {
            get { 
                  return _score; 
                }
            set
            {
                if (value >= 100) value = 100;
                if (value <= 0) value = 0;
                _score = value;
            
            }

        }
        public void ShowMsg()
        {
            MessageBox.Show($" {Name}同學的分數是 {Score}");
        }
    }
}
