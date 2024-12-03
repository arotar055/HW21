using System;
using System.Windows.Forms;

namespace WindowMoverApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer moveTimer;   // Указываем явно использование Timer из Windows.Forms
        private int xPosition = 0;
        private int yPosition = 0;
        private int speed = 10;
        private bool moving = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Разрешаем перехват клавиш в форме

            moveTimer = new System.Windows.Forms.Timer(); // Указываем явно использование Timer из Windows.Forms
            moveTimer.Interval = 50; // Интервал в миллисекундах
            moveTimer.Tick += MoveTimer_Tick; // Подключаем обработчик события Tick
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                xPosition = 0;
                yPosition = 0;
                moving = true;
                moveTimer.Start();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                moving = false;
                moveTimer.Stop();
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (moving)
            {
                if (xPosition < Screen.PrimaryScreen.WorkingArea.Width - this.Width && yPosition == 0)
                {
                    xPosition += speed;
                }
                else if (xPosition == Screen.PrimaryScreen.WorkingArea.Width - this.Width && yPosition < Screen.PrimaryScreen.WorkingArea.Height - this.Height)
                {
                    yPosition += speed;
                }
                else if (yPosition == Screen.PrimaryScreen.WorkingArea.Height - this.Height && xPosition > 0)
                {
                    xPosition -= speed;
                }
                else if (xPosition == 0 && yPosition > 0)
                {
                    yPosition -= speed;
                }

                this.Location = new System.Drawing.Point(xPosition, yPosition);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(300, 300);
        }
    }
}
