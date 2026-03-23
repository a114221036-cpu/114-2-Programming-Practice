using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butChi_Click(object sender, EventArgs e)
        {
            if(sender.Equals(butChi))
            {
              label1.Text = "快樂";
            }
            else
            {
                label1.Text = "Happy";
            }   
        }
    }
}
