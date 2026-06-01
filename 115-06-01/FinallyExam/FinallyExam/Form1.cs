using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinallyExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算方法：接受學測、書審、口試三個分數當作參數，回傳加權總分（滿分 97.5）
        // 學測滿級分 75 分，占比 10%（換算滿分貢獻為 9.75）
        // 書審滿分 100 分，占比 45%（換算滿分貢獻為 43.875）
        // 口試滿分 100 分，占比 45%（換算滿分貢獻為 43.875）
        private double CalculateTotalScore(double scholastic, double review, double interview)
        {
            // scholastic: 0-75 -> normalize to 0-100 by /75*100, then apply 10%
            double scholasticNormalized = (scholastic / 75.0) * 100.0; // 0-100
            double scholasticWeighted = scholasticNormalized * 0.10; // contributes up to 10

            // review and interview are 0-100, each 45%
            double reviewWeighted = review * 0.45;
            double interviewWeighted = interview * 0.45;

            // Sum weighted parts, then scale to match described maximum 97.5
            // The current maximum would be 10 + 45 + 45 = 100, but the problem states full score is 97.5
            // We will scale the total by 97.5/100.
            double totalPercent = scholasticWeighted + reviewWeighted + interviewWeighted; // 0-100
            double total = totalPercent * (97.5 / 100.0);
            return total;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            var rnd = new Random();
            var students = new List<Tuple<int, double>>(); // id, total

            for (int i = 1; i <= 100; i++)
            {
                // Generate sample scores. In a real scenario you'd input these.
                double scholastic = Math.Round(rnd.NextDouble() * 75.0, 2);
                double review = Math.Round(rnd.NextDouble() * 100.0, 2);
                double interview = Math.Round(rnd.NextDouble() * 100.0, 2);

                double total = CalculateTotalScore(scholastic, review, interview);
                students.Add(Tuple.Create(i, total));
            }

            // Sort descending by total score
            var sorted = students.OrderByDescending(s => s.Item2).ToList();

            lstResults.Items.Add("排名\t學號\t總分(滿分97.5)");
            int rank = 1;
            foreach (var s in sorted)
            {
                lstResults.Items.Add(string.Format("{0}\t{1}\t{2:F2}", rank, s.Item1, s.Item2));
                rank++;
            }
        }
    }
}
