using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 修正 CS1003: 語法錯誤，必須是 ','
        // 修正 CS0246: 找不到類型或命名空間名稱 'FIVE_CENT'
        // 正確宣告常數於類別內部
        private const decimal FIVE_CENT = 5.0m;
        private const decimal TEN_CENT = 10.0m;
        private const decimal TWENTY_FIVE_CENT = 25.0m;
        private const decimal FIFTY_CENT = 50.0m;   

        private decimal total;

        // 建構子，初始化表單元件
            public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENT;
            totalLabel.Text = total.ToString();
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENT;
            totalLabel.Text = total.ToString();
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENT;
            totalLabel.Text = total.ToString();
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENT;
            totalLabel.Text = total.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTotalLabel()
        {
            totalLabel.Text = total.ToString("C2");
        }
    }
}
