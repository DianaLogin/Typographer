using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Typographer
{
    public partial class typograph_Form : Form
    {
        public typograph_Form()
        {
            InitializeComponent();
            new System.Windows.Forms.ToolTip().SetToolTip(logo_picture, "Логотип приложения");
            new System.Windows.Forms.ToolTip().SetToolTip(settings_picture, "Открыть настройки");
            new System.Windows.Forms.ToolTip().SetToolTip(theme_picture, "Поменять тему");
            new System.Windows.Forms.ToolTip().SetToolTip(about_picture, "Посмотреть справку");
        }


        private void panel1_Resize(object sender, EventArgs e)
        {
            /*
            input_textbox.Width = (int)(panel1.Width * 0.45);
            updated_textbox.Width = (int)(panel1.Width * 0.45);
            logo_picture.Width = (int)(panel1.Width * 0.21);
            settings_picture.Width = (int)(panel1.Width * 0.05);
            theme_picture.Width = (int)(panel1.Width * 0.05);
            about_picture.Width = (int)(panel1.Width * 0.05);
            arrow_picture.Width = (int)(panel1.Width * 0.05);
            clear_btn.Width = (int)(panel1.Width * 0.21);
            typograph_btn.Width = (int)(panel1.Width * 0.21);

            input_textbox.Height = (int)(panel1.Height * 0.74);
            updated_textbox.Height = (int)(panel1.Height * 0.74);
            logo_picture.Height = (int)(panel1.Height * 0.08);
            settings_picture.Height = (int)(panel1.Height    * 0.08);
            theme_picture.Height = (int)(panel1.Height * 0.08);
            about_picture.Height = (int)(panel1.Height * 0.08);
            arrow_picture.Height = (int)(panel1.Height * 0.08);
            clear_btn.Height = (int)(panel1.Height * 0.07);
            typograph_btn.Height = (int)(panel1.Height * 0.07);

            input_textbox.Top = (int)(panel1.Width * 0.45);
            updated_textbox.Top = (int)(panel1.Width * 0.45);
            logo_picture.Top = (int)(panel1.Width * 0.21);
            settings_picture.Top = (int)(panel1.Width * 0.05);
            theme_picture.Top = (int)(panel1.Width * 0.05);
            about_picture.Top = (int)(panel1.Width * 0.05);
            arrow_picture.Top = (int)(panel1.Width * 0.05);
            clear_btn.Top = (int)(panel1.Width * 0.21);
            typograph_btn.Top = (int)(panel1.Width * 0.21);
            */
        }

        private void typograph_btn_Click(object sender, EventArgs e)
        {
            string text = input_textbox.Text;

            // Применяем все выбранные фильтры к тексту одновременно
            text = Replace_Every_Second_Word(ref text);
            text = Add_Non_Breaking_Space(ref text);
            text = Replace_Ellipsis(ref text);
            text = Replace_Plus_Minus(ref text);
            text = Replace_Quotes(ref text);
            text = Add_Space_After_Comma(ref text);
            text = Replace_Dash(ref text);
            text = Every_Second_Letter_Upper(ref text);

            updated_textbox.Text = text;
        }

        private void SetBlackTheme()
        {
            this.BackColor = Color.MidnightBlue;
            panel1.BackColor = Color.MidnightBlue;
            input_textbox.BackColor = Color.DarkSlateBlue;
            updated_textbox.BackColor = Color.DarkSlateBlue;
        }

        private void SetBeigeTheme()
        {
            this.BackColor = Color.Beige;
            panel1.BackColor = Color.Beige;
            input_textbox.BackColor = Color.Azure;
            updated_textbox.BackColor = Color.Azure;
        }

        private void theme_picture_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.MidnightBlue)
            {
                SetBeigeTheme();
            }
            else
            {
                SetBlackTheme();
            }
        }

        private void about_picture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Типограф – это удобное приложение для автоматической коррекции текста, адаптированное под специфические требования обработки текста. Оно позволяет быстро и эффективно преобразовывать текст, соблюдая особенности русского языка и технической терминологии.\r\n\r\nОсновные возможности\r\n1.) Непереносимый пробел между значениями и единицами измерения: При вводе технических характеристик, например, \"10 В\", приложение автоматически добавляет непереносимый пробел между значением и единицей измерения, превращая его в \"10 В\".\r\n2.) Замена троеточия на знак \"...\": Вместо традиционного использования трех точек для обозначения продолжения текста, приложение заменяет их на знак \"…\", делая текст более читабельным и соответствующим стандартам.\r\n3.) Использование чисел для обозначения степеней: Для указания степени квадрата и куба используется соответствующее число (2 для квадрата, 3 для куба), что упрощает чтение и понимание текста.\r\n4.) Символ \"плюс-минус\": Приложение позволяет использовать символ \"±\" для обозначения положительного и отрицательного значений, исключая ненужные конструкции.\r\n5.) Замена кавычек программистов на кавычки \"ёлочки\": Вместо использования кавычек программистов (\"\"\"), приложение предлагает использовать кавычки \"ёлочки\" («»), что делает текст более естественным и понятным для русскоязычных пользователей.\r\n6.) Использование кавычек \"лапок\": Кавычки \"лапки\" („ „) используются в случаях, когда необходимо вложенное использование кавычек, что обеспечивает гибкость в форматировании текста.\r\n8.) Слитное размещение знаков препинания: Знаки препинания размещаются слева от слова и отделяются пробелом справа, что соответствует стандартам русского языка.\r\n9.) Использование буквы \"ё\": Приложение корректно обрабатывает использование буквы \"ё\", исключая её замену на \"е\".\r\n11.) Замена каждой второй буквы на заглавную: Для улучшения читаемости текста приложение автоматически делает каждую вторую букву заглавной.\r\n12.) Замена каждого второго слова на знак сердечка: Эта функция позволяет сделать текст более ярким и эмоциональным, заменяя каждое второе слово на заменяя каждое второе слово на знак сердечка.\r\n\r\nПрименение\r\n\"Типограф\" идеально подходит для редактирования технического и научного текста, а также для общего использования в повседневной переписке и документообороте. Благодаря своей универсальности и удобству использования, приложение помогает сократить время на корректировку текста и повышает его качество.", "Описание приложения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        delegate void TextFilter(ref string text);

        private static string Every_Second_Letter_Upper(ref string text)
        {
            StringBuilder sb = new StringBuilder(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(char.ToUpper(text[i]));
                }
                else
                {
                    sb.Append(text[i]);
                }
            }
            return sb.ToString();
        }

        private static string Replace_Every_Second_Word(ref string text)
        {
            return Regex.Replace(text, @"\b\w+\b", delegate (Match m)
            {
                if (m.Index % 2 == 0)
                    return m.Value;
                else
                    return "❤️";
            });
        }

        private static string Add_Non_Breaking_Space(ref string text)
        {
            return Regex.Replace(text, @"\d\s[А-Яа-яA-Za-z]+\b", delegate (Match m)
            {
                return m.Value.Replace(" ", "\u00A0");
            });
        }

        private static string Replace_Ellipsis(ref string text)
        {
            return Regex.Replace(text, @"\.\.\.", "…");
        }

        private static string Replace_Plus_Minus(ref string text)
        {
            return Regex.Replace(text, @"\+\-", "±");
        }

        private static string Replace_Quotes(ref string text)
        {
            return Regex.Replace(text, @"""([^""]*)""", "«$1»");
        }

        private static string Add_Space_After_Comma(ref string text)
        {
            return Regex.Replace(text, @",", ", ");
        }

        private static string Replace_Dash(ref string text)
        {
            return Regex.Replace(text, @"(\s)-(\s)", "$1–$2");
        }

        private void copy_btn_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(updated_textbox.Text);
            MessageBox.Show("Текст успешно скопирован.");
        }

        private void settings_picture_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                var result = settingsForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Применяем выбранные настройки к тексту
                    string text = input_textbox.Text;
                    updated_textbox.Text = ApplySettings(text, settingsForm);
                }
            }
        }



        private string ApplySettings(string text, SettingsForm settingsForm)
        {
            // Создаем экземпляр StringBuilder для эффективной обработки текста
            StringBuilder sb = new StringBuilder(text.Length);

            // Применяем все фильтры последовательно к исходному тексту
            if (settingsForm.CheckBoxReplaceEverySecondWord)
            {
                text = Replace_Every_Second_Word(ref text);
            }

            if (settingsForm.CheckBoxAddNonBreakingSpace)
            {
                text = Add_Non_Breaking_Space(ref text);
            }

            if (settingsForm.CheckBoxReplaceEllipsis)
            {
                text = Replace_Ellipsis(ref text);
            }

            if (settingsForm.CheckBoxReplacePlusMinus)
            {
                text = Replace_Plus_Minus(ref text);
            }

            if (settingsForm.CheckBoxReplaceQuotes)
            {
                text = Replace_Quotes(ref text);
            }

            if (settingsForm.CheckBoxAddSpaceAfterComma)
            {
                text = Add_Space_After_Comma(ref text);
            }

            if (settingsForm.CheckBoxReplaceDash)
            {
                text = Replace_Dash(ref text);
            }

            if (settingsForm.CheckBoxEverySecondLetterUpper)
            {
                text = Every_Second_Letter_Upper(ref text);
            }

            // Добавляем итоговый текст в StringBuilder
            sb.Append(text);

            return sb.ToString();
        }




    }

}
