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
        // 宣告硬幣面額常數（以元為單位）
        private const decimal FIVE_CENT = 5m;
        private const decimal TEN_CENT = 10m;
        private const decimal TWENTY_FIVE_CENT = 25m;
        private const decimal FIFTY_CENT = 50m;

        // 儲存目前累計的總金額（以元為單位）
        private decimal total = 0m;

        // 自訂事件：當有硬幣被點擊時會觸發，帶入 CoinEventArgs
        public event EventHandler<CoinEventArgs> CoinClicked;

        // 建構子，初始化表單元件，並訂閱自訂事件的處理方法
        public Form1()
        {
            InitializeComponent();

            // 將自訂事件綁定到處理方法
            this.CoinClicked += HandleCoinClicked;
        }

        // 自訂 EventArgs，攜帶硬幣面額
        public class CoinEventArgs : EventArgs
        {
            public decimal Amount { get; }

            public CoinEventArgs(decimal amount)
            {
                Amount = amount;
            }
        }

        // 保護方法：觸發自訂事件（可被覆寫）
        protected virtual void OnCoinClicked(CoinEventArgs e)
        {
            CoinClicked?.Invoke(this, e);
        }

        // 公開自訂方法：用於從程式中主動觸發硬幣點擊事件
        public void RaiseCoinClicked(decimal amount)
        {
            OnCoinClicked(new CoinEventArgs(amount));
        }

        // 自訂方法：將硬幣金額加入總額並更新顯示
        private void AddCoin(decimal amount)
        {
            total += amount;
            UpdateTotalLabel();
        }

        // 自訂事件的處理器：當事件發生時呼叫 AddCoin
        private void HandleCoinClicked(object sender, CoinEventArgs e)
        {
            AddCoin(e.Amount);
        }

        // 各 PictureBox 的 Click 事件改為觸發自訂事件
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            RaiseCoinClicked(FIVE_CENT);
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            RaiseCoinClicked(TEN_CENT);
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            RaiseCoinClicked(TWENTY_FIVE_CENT);
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            RaiseCoinClicked(FIFTY_CENT);
        }

        // 離開按鈕事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 更新總金額顯示（格式為貨幣，C2）
        private void UpdateTotalLabel()
        {
            totalLabel.Text = total.ToString("C2");
        }
    }
}
