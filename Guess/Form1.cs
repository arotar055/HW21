using System;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        private int attempts;
        private int lowerBound = 1;
        private int upperBound = 100;
        private int targetNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void StartNewGame()
        {
            attempts = 0;
            lowerBound = 1;
            upperBound = 100;

            MessageBox.Show("��������� ����� �������� ������� ���� ����� �� 1 �� 100.",
                            "������ ����", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GuessNumber();
        }

        private void GuessNumber()
        {
            DialogResult result;
            do
            {
                attempts++;
                int guess = (lowerBound + upperBound) / 2; // �������� �����
                result = MessageBox.Show($"���� ����� ������, ������ ��� ����� {guess}?", "���������� �����",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    upperBound = guess - 1; // ���� ����� ������ ��� �����
                }
                else if (result == DialogResult.No)
                {
                    lowerBound = guess + 1; // ���� ����� ������
                }
                else
                {
                    break; // ���� ������ ������ Cancel, ���������� ����
                }

                // ���� �������� �������� �� ������ �����, ������ ��������� �������
                if (lowerBound == upperBound)
                {
                    MessageBox.Show($"� ������ ���� ����� {lowerBound} �� {attempts} �������!",
                                    "�����!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ����������, ����� �� ������������ ������� �����
                    DialogResult replayResult = MessageBox.Show("������ ������� �����?", "���� ���������",
                                                               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (replayResult == DialogResult.Yes)
                    {
                        StartNewGame(); // ���������� ����
                    }
                    else
                    {
                        this.Close(); // �������� ����������
                    }
                }
            } while (result != DialogResult.Cancel);
        }
    }
}
