using System;
using System.Windows.Forms;

namespace MouseClickCounter
{
    public partial class Form1 : Form
    {
        private int leftClicks = 0;
        private int middleClicks = 0;
        private int rightClicks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTitle();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    leftClicks++;
                    break;
                case MouseButtons.Middle:
                    middleClicks++;
                    break;
                case MouseButtons.Right:
                    rightClicks++;
                    break;
            }
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            this.Text = $"Левые: {leftClicks} | Средние: {middleClicks} | Правые: {rightClicks}";
        }
    }
}
