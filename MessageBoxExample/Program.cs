namespace MessageBoxExample
{
    internal static class Program
    {
        // Single Threaded Apartment
        // Модель потоков STA необходима для взаимодействия с COM
        /*
         * STA-single-threaded apartment 
        Microsoft утверждает,что данный атрибут ф-ция Main() должна иметь во всех windows-приложениях.
         * Это означает, что все потоки в этой программе выполняются в рамках одного процесса, а управление приложением осуществляется одним главным потоком.
         * Это необходимо, чтоб не было проблем, если приложение подключает компоненты. Разработчики компонентов могут дать своему компоненту много прав. 
         * При подключении компонента, он запускает какое-то модальное действие и приложение зависает. При STA всеми потоками руководит поток, запущеный с Main().
         * */
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Этот метод автоматически создается во время компиляции и содержит код для настройки Windows Forms. 
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}