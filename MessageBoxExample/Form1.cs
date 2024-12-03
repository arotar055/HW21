using System;
using System.Windows.Forms;

namespace MouseClickCounter
{
    public partial class Form1 : Form
    {
        private int leftClickCount = 0;
        private int rightClickCount = 0;
        private int middleClickCount = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateTitle();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftClickCount++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                rightClickCount++;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                middleClickCount++;
            }

            UpdateTitle();
        }

        private void UpdateTitle()
        {
            Text = $"Левая: {leftClickCount}, Правая: {rightClickCount}, Средняя: {middleClickCount}";
        }
    }
}
