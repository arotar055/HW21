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

            MessageBox.Show("Программа будет пытаться угадать ваше число от 1 до 100.",
                            "Начало игры", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GuessNumber();
        }

        private void GuessNumber()
        {
            DialogResult result;
            do
            {
                attempts++;
                int guess = (lowerBound + upperBound) / 2; // Бинарный поиск
                result = MessageBox.Show($"Ваше число больше, меньше или равно {guess}?", "Угадывание числа",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    upperBound = guess - 1; // Если число меньше или равно
                }
                else if (result == DialogResult.No)
                {
                    lowerBound = guess + 1; // Если число больше
                }
                else
                {
                    break; // Если нажата кнопка Cancel, прекращаем игру
                }

                // Если диапазон сужается до одного числа, значит программа угадала
                if (lowerBound == upperBound)
                {
                    MessageBox.Show($"Я угадал ваше число {lowerBound} за {attempts} попыток!",
                                    "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Спрашиваем, хочет ли пользователь сыграть снова
                    DialogResult replayResult = MessageBox.Show("Хотите сыграть снова?", "Игра завершена",
                                                               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (replayResult == DialogResult.Yes)
                    {
                        StartNewGame(); // Перезапуск игры
                    }
                    else
                    {
                        this.Close(); // Закрытие приложения
                    }
                }
            } while (result != DialogResult.Cancel);
        }
    }
}
