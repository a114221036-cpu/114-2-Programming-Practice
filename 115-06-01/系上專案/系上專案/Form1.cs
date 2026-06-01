using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 系上專案
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // method that calculates the weighted score and returns the result
        private double CalculateWeightedScore(double xueScore, double shuScore, double kouScore)
        {
            // 學測滿分 75，占比 10% -> scale to 100 then apply weight relative to 97.5 total
            // But simpler: compute weighted contribution directly as described: total max is 97.5
            // weights: 學測 10%, 書審 45%, 口試 45% of the final max 97.5
            double maxTotal = 97.5;
            double weightXue = 0.10;
            double weightShu = 0.45;
            double weightKou = 0.45;

            // Normalize each score to percentage (0..1) relative to its max
            double pXue = Math.Max(0, Math.Min(1.0, xueScore / 75.0));
            double pShu = Math.Max(0, Math.Min(1.0, shuScore / 100.0));
            double pKou = Math.Max(0, Math.Min(1.0, kouScore / 100.0));

            double total = maxTotal * (pXue * weightXue + pShu * weightShu + pKou * weightKou);
            return total;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double xue = 0, shu = 0, kou = 0;
            double result = 0;
            bool ok1 = double.TryParse(textBoxXue.Text, out xue);
            bool ok2 = double.TryParse(textBoxShu.Text, out shu);
            bool ok3 = double.TryParse(textBoxKou.Text, out kou);

            if (!ok1 || !ok2 || !ok3)
            {
                MessageBox.Show("請輸入有效數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            result = CalculateWeightedScore(xue, shu, kou);
            labelResult.Text = $"最終加權分數：{result:F2} / 97.5";
        }
    }
}
