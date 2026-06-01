using System;
using System.Windows.Forms;

namespace 學校專案
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 表單載入時顯示示範
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 範例：一般教師
                var prof = new Professor("T001", "王小明", 90000m);

                // 範例：系主任
                var head = new DeptHead("T010", "陳主任", 95000m, 30000m);

                // 組合顯示文字
                string message =
                    $"一般教師：\n編號：{prof.TeacherId}\n姓名：{prof.Name}\n基本薪資：{prof.BaseSalary:N0}\n實領（扣 6%）：{prof.CalculateNetSalary():N2}\n\n" +
                    $"系主任：\n編號：{head.TeacherId}\n姓名：{head.Name}\n基本薪資：{head.BaseSalary:N0}\n主任加給：{head.Allowance:N0}\n加總（基本薪資 + 加給）：{head.TotalSalary():N0}\n實領（基本薪資 扣 6%）：{head.CalculateNetSalary():N2}";
                                                  
                MessageBox.Show(message, "薪資計算示範", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"輸入值錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
