using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 建構式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblMsg_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sudent s1 = new Sudent();  // 無引數的建構式
            s1.Name = "布魯斯";
            s1.Score = 88;
            LblMsg.Text = s1.GetMsg() + "\n\n";

            Sudent s2 = new Sudent("珍妮佛");  //傳一個引數的建構式
            s2.Score = 77;
            LblMsg.Text += s2.GetMsg() + "\n\n";

            Sudent s3 = new Sudent("艾莉絲", 99);  //傳兩個引數的建構式
            LblMsg.Text += s3.GetMsg();

        }
    }
}
