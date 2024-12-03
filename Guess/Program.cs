using System;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Настроим визуальный стиль приложения
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск основной формы приложения
            Application.Run(new Form1());
        }
    }
}
