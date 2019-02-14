using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string firstFileText, secondFileText; // Введение глобальных переменных
        public string[] ftext, stext; // Файлы, представленные в виде массива строк
        public int y = 0, nextWordCounter = 0, extraPrev = 0, i = 0; //Переменные-счетчики
        public bool flag = false;

        public Form() // Конструктор формы
        {
            InitializeComponent(); // Требуемый метод для поддержки конструктора
            Start.Enabled = false; // Отключение кнопки начала сравнения
            FirstButton.Click += FirstButton_Click;
            SecondButton.Click += button2_Click;
            Start.Click += Start_Click; // добавление методов, осуществляемых после нажатия кнопки
            FirstOpenFileDialog.Filter = "Text files(*.txt)|*.txt|*.dos|";
            SecondOpenFileDialog.Filter = "Text files(*.txt)|*.txt|*.dos|"; // Здесь задаем фильтры для обзорщика файлов

        }

        private void Form1_Load(object sender, EventArgs e) // Метод формы
        {

        }

        public void ChangeExtraTextPrev(string[] changedText, string[] mainText, RichTextBox text) // Метод, осуществляющий выделение отличающегося текста с начала файла до первой одинаковой строки 
        {
            y = 0; // Обнуление глобальных переменных при условии, что пользователь начнет новое сравнение без перезапуска программы
            extraPrev = 0;
            if (mainText[0] != changedText[0])//Проверка условия отличаются ли первые строки текста
            {
                flag = true;
                while (changedText[y] != mainText[0]) //Находим количество отличающихся слов перед началом исходного текста
                {
                    y++;
                    if (y > mainText.Length) // Выход из цикла, если текст полностью отличается от исходного
                        break;
                }
                while (extraPrev != y)
                {
                    if (y > mainText.Length)
                        break;
                    ChangeBackground(changedText, 0, extraPrev, text); //По одному закрашивает лишние слова
                    extraPrev++;
                }
            }
        }

        public void ChangeExtraTextNext(string[] changedText, string[] mainText, RichTextBox text) // Метод, осуществляющий выделение отличающегося текста, идущего после конца сравниваемого текста
        {
            var extra = 0;
            if (mainText[mainText.Length - 1] != changedText[changedText.Length - 1]) //Проверяет не равны ли последние слова текстов
            {
                flag = true;
                while (mainText.Length + nextWordCounter + extraPrev + extra != changedText.Length) // пока длина исходного текста не будет равна длине второго
                {
                    if (y > mainText.Length)
                        break;
                    ChangeBackground(changedText, nextWordCounter, mainText.Length + extra + extraPrev, text); // Закрашиваются лишние слова с конца, начиная с последнего
                    extra++;
                }
            }
        }

        public static void ChangeBackground(string[] changedText, int counter, int i, RichTextBox text) //Метод, который находит и выделяет схожий текст, путём изменения фона этого текста
        {
            var c = changedText[i + counter];
            for (int p = 0; p < c.Length; p++)//Цикл для нахождения символа перевода на новую строку в тексте
            {
                if (c[p] == '\n' && p == 1)
                    c = c.Remove(0, 2);//удаляем из сравниваемой строки символы для перевода на новую строку
                else if (c[p] == '\n' && p == c.Length - 1)
                    c = c.Remove(c.Length - 2, 2);
            }                
            var l = text.Find(c); //Поиск позиции с которой начинается слово
            text.SelectionStart = l; //Начало выделения текста
            text.SelectionLength = c.Length; //Длина выделения
            text.SelectionBackColor = Color.Red; //Изменение цвета выделенной части
        }

        private void Start_Click(object sender, EventArgs e)
        {
            flag = false;
            var separators = new[] { '@', '.', '?', '!', ',', '-', ' ' }; //Разделители слов
            ftext = firstFileText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            stext = secondFileText.Split(separators, StringSplitOptions.RemoveEmptyEntries); //Преобразование текстов файлов в массивы строк
            if (ftext.Length > stext.Length)
            {
                Another(ftext, stext, FirstText);
            }
            else Another(stext, ftext, SecondText);
            if (flag == false)
            {
                MessageBox.Show("Загруженные файлы одинаковые",
                    "Сравнение текстовых файлов", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Реализация загрузки и отображения содержания файла путём нажатия кнопки
        {
            if (SecondOpenFileDialog.ShowDialog() == DialogResult.Cancel) // ОТкрывает диалоговое окно
                return;
            var secondFileName = SecondOpenFileDialog.FileName;
            secondFileText = System.IO.File.ReadAllText(secondFileName, Encoding.GetEncoding(1251)); //Считывает весь текст выбранного пользователем файла принимая его имя
            SecondText.Text = secondFileText; //Присвоение значения глобальной переменной
        }

        private void FirstButton_Click(object sender, EventArgs e) // Метод аналогичный методу выше
        {
            if (FirstOpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var firstFileName = FirstOpenFileDialog.FileName;
            firstFileText = System.IO.File.ReadAllText(firstFileName, Encoding.GetEncoding(1251)); // Исключаем нечитаемые символы с помощью кодировки Encoding.GetEncoding(1251)
            FirstText.Text = firstFileText;
        }

        private void FirstText_TextChanged(object sender, EventArgs e) //Проверка на наличие текста в обоих текстовых RichTextBox: если условия соблюдаются, то кнопка запуска программы становится доступной пользователю
        {
            Start.Enabled = FirstText.Text.Length > 0 && SecondText.Text.Length > 0;
        }

        private void SecondText_TextChanged(object sender, EventArgs e) // Аналогично для второго RichTextBox
        {
            Start.Enabled = FirstText.Text.Length > 0 && SecondText.Text.Length > 0;
        }

        public void Another(string[] redText, string[] text, RichTextBox assignText)
        {
            ChangeExtraTextPrev(redText, text, assignText);
            nextWordCounter = 0;
            for (i = 0;  i + extraPrev < text.Length && i < redText.Length; i++) // с помощью цикла пробегаемся по всем элементам текста
            {
                if (redText[i + extraPrev + nextWordCounter] != text[i])//Сравнение слов с соотетствующим порядковым номером
                {
                    flag = true; //Присвоение значения true для переменной flag, что показывает наличие отличий в текстах
                    ChangeBackground(redText, nextWordCounter, i + extraPrev, assignText);
                    for (int k = 0; i + nextWordCounter + extraPrev + k < redText.Length; k++) //Алгоритм поиска и выделения лишних или заменённых слов в середине текста
                    {
                        if (redText[i + nextWordCounter + extraPrev + k] == text[i])
                        {
                            for (int l = 1; l < k; l++)
                            {
                                ChangeBackground(redText, nextWordCounter, i + k - l + extraPrev, assignText);
                            }
                            nextWordCounter += k;
                            break;
                        }
                    }
                }
            }
            ChangeExtraTextNext(redText, text, assignText);
        }
    }
}