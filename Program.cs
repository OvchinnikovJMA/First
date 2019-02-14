using System;
using System.Windows.Forms;

namespace Проект
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // Необходимые функции для работы программы
            var form = new Form(); // Создание Windows-формы
            form.FormClosing += (sender, args) => // добавление события перед закрытием формы
            {
                var closingMessage = MessageBox.Show("Вы действительно хотите закрыть приложение?",
                    "Сравнение текстовых файлов",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                if (closingMessage != DialogResult.Yes) args.Cancel = true; // Создание сообщения о дополнительном подтверждении выхода из программы
            };
            form.MaximizeBox = false; // Запрет на "Разворачивание" окна приложения, чтобы оно было компактным
            MessageBox.Show("Вас приветствует программа для сравнения тексовых файлов!\n" +
                " Ознакомьтесь с инструкцией программы:\n" +
                "-  Время работы программы зависит от размера загружаемых файлов и от количества отличий в них. В среднем программа работает не более 1 - 2 секунд;\n" +
                "-  Желательно, чтобы оба текста были в виде одного неразрывного текста - это обеспечит дополнительную точность при сравнении.",
                "Сравнение текстовых файлов", MessageBoxButtons.OK, MessageBoxIcon.Information); // Вывод инструкций для пользователя перед запуском программы
            Application.Run(form); // Запуск Формы
        }
    }
}
