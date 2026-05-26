using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW2_s1121524
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateCards();
        }

        private void GenerateCards()
        {
            // 在 4x4 的 TableLayoutPanel 中填滿 16 張卡牌
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox card = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(5),      // 讓卡牌之間有一點間距
                        BackColor = Color.LightGray,  // 預設卡牌背面的顏色 (之後可換成你的圖片)
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand         // 滑鼠移過去變成手指游標
                    };

                    // 綁定點擊事件
                    card.Click += Card_Click;

                    // 將卡牌加入對應的格子裡
                    tableLayoutPanel1.Controls.Add(card, j, i);
                }
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            PictureBox clickedCard = sender as PictureBox;

            // 這裡撰寫你的翻牌邏輯、播放音效與配對檢查
            clickedCard.BackColor = Color.White; // 測試用：點擊後變色
        }
    }
}