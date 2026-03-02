using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _115_03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 宣告arrPic變數為圖片控制項陣列，陣列元素arrPic[0]~arrPic[2]
        PictureBox[] arrPic = new PictureBox[3];
        // 宣告getPoint陣列用來存放亂數值，陣列元素getPoint[0]~getPoint[2]
        int[] getPoint = new int[3];
        int total = 0;        // total整數變數用來存放三個骰子的總點數

        // coins 狀態索引 (0 = Heads, 1 = Tails)
        int coin1Index = 0;
        int coin2Index = 0;

        // 隨機數應為欄級避免每次 Tick 重新以時間為種子建立造成偏差
        Random rnd = new Random();

        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            TmrGo.Interval = 50;  // 每0.05秒執行TmrGo_Tick事件處理函式一次
            arrPic[0] = Pic1;      // 控制項陣列的第一個元素即為Pic1圖片控制項
            arrPic[1] = Pic2;
            arrPic[2] = Pic3;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 保持原本按標題時也可設定 (與 Form1_Load 行為相同)
            TmrGo.Interval = 50;
            arrPic[0] = Pic1;
            arrPic[1] = Pic2;
            arrPic[2] = Pic3;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrGo.Enabled = true;
        }

        // 當TmrGo啟動時，每0.05秒會執行TmrGo_Tick_1事件處理函式一次
        private void TmrGo_Tick_1(object sender, EventArgs e)
        {
            total = 0;

            // 產生三顆骰子的亂數並顯示
            for (int i = 0; i < arrPic.Length; i++)   // 控制產生亂數的次數
            {
                getPoint[i] = rnd.Next(0, 6);  // 產生0~5 間之亂數
                total += getPoint[i] + 1;      // 產生的點數累加到total變數
                // 將指定圖檔置入控制項陣列在表單對應的圖片控制項      
                arrPic[i].Image = ImgDice.Images[getPoint[i]];
            }

            // 同步產生兩個 COIN 的動畫 (0 = Heads, 1 = Tails)
            coin1Index = rnd.Next(0, 2);
            coin2Index = rnd.Next(0, 2);
            pictureBox1.Image = imgCoin.Images[coin1Index];
            pictureBox2.Image = imgCoin.Images[coin2Index];

            // 清除訊息區（保持在滾動時不顯示結果）
            LblMsg.Text = string.Empty;
        }

        // 按 [停止] 鈕執行（Designer 綁定 BtnStop_Click_1）
        private void BtnStop_Click_1(object sender, EventArgs e)
        {
            TmrGo.Enabled = false;

            // 只有當兩個 coin 停在同一面（同索引）時，才加總並顯示骰子點數；否則顯示重來一次
            if (coin1Index == coin2Index)
            {
                LblMsg.Text = $"共得到 {total} 點 !!";
            }
            else
            {
                LblMsg.Text = "重來一次";
            }
        }
    }
}

