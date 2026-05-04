using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_0504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student sl = new Student();
            sl.Name = "賈斯柏";
            sl.Score_Chi = 90;
            sl.Score_Math = 70;
            sl.Score_Eng = 80;
            sl.ShowSum();
            sl.ShowPass();

            Student s2 = new Student();
            s2.Name = "愛麗絲";
            s2.Score_Chi = 60;
            s2.Score_Math = 70;
            s2.Score_Eng = 60;
            s2.ShowSum();
            s2.ShowPass();
        }
    }
}
