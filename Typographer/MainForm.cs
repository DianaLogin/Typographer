using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Typographer
{
    public partial class Typograph_Form : Form
    {
        public Typograph_Form()
        {
            InitializeComponent();
           
            new System.Windows.Forms.ToolTip().SetToolTip(logo_picture, "Логотип приложения");
            new System.Windows.Forms.ToolTip().SetToolTip(theme_picture, "Поменять тему");
            new System.Windows.Forms.ToolTip().SetToolTip(about_picture, "Посмотреть справку");
        }

        private void typograph_btn_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void SetBlackTheme()
        {
            this.BackColor = Color.MidnightBlue;
            panel1.BackColor = Color.MidnightBlue;
            input_textbox.BackColor = Color.DarkSlateBlue;
            updated_textbox.BackColor = Color.DarkSlateBlue;
            input_textbox.ForeColor = Color.AliceBlue;
            updated_textbox.ForeColor = Color.AliceBlue;
        }

        private void SetBeigeTheme()
        {
            this.BackColor = Color.Beige;
            panel1.BackColor = Color.Beige;
            input_textbox.BackColor = Color.Ivory;
            updated_textbox.BackColor = Color.Ivory;
            input_textbox.ForeColor = Color.Black;
            updated_textbox.ForeColor = Color.Black;
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


        private void copy_btn_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(updated_textbox.Text);
            MessageBox.Show("Текст успешно скопирован.");
        }

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

        public static string Replace_Every_Second_Word_Heart(ref string text)
        {
            string[] words = text.Split(' ');
            for (int i = 1; i < words.Length; i += 2)
            {
                words[i] = "❤";
            }
            text = string.Join(" ", words);
            return text;
        }
        public static string True_Punctuation(ref string text)
        {
            // Обработка знаков препинания
            string punctuationLeftRight = Regex.Replace(text, @"([\.,;:!?\-])(\w)", "$1 $2");
            string punctuationRight = Regex.Replace(punctuationLeftRight, @"([\.,;:!?\-])\s*(\w)", "$1 $2");

            // Обработка тире
            string dashes = Regex.Replace(punctuationRight, @"(-)\s*(-)", " $1 $2");

            // Обработка скобок и кавычек
            string quotes = Regex.Replace(dashes, @"([()\""'])(\s*\w+\s*)", "$1 $2");

            return quotes;
        }

        private static string Add_Non_Breaking_Space(ref string text)
        {
            string updated_text = Regex.Replace(text, @"(\p{L})(\d+)", "$1 $2");
            updated_text = Regex.Replace(text, @"\s+", " ");
            return Regex.Replace(text, @"(\p{L})(\d+)|(\p{L}+)", "$1$2 $3");
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


        private static string Replace_Dash_To_Minus(ref string text)
        {
            string updatedText = Regex.Replace(text, @"(-\d+)", match => "−" + match.Groups[1].Value);
               
            return Regex.Replace(updatedText, @"(\d+)\s*([−+\*\/])\s*(\d+)", "$1 $2 $3");
        }

        private void Set_Formatting()
        {
            string input_text = input_textbox.Text;

            if (Every_Second_Letter_Upper_MenuItem.Checked)
            {
                input_text = Every_Second_Letter_Upper(ref input_text);
            }
            if (Replace_Every_Second_Word_Heart_MenuItem.Checked)
            {
                input_text = Replace_Every_Second_Word_Heart(ref input_text);
            }
            if (Add_Non_Breaking_Space_MenuItem.Checked)
            {
                input_text = Add_Non_Breaking_Space(ref input_text);
            }
            if (Replace_Ellipsis_MenuItem.Checked)
            {
                input_text = Replace_Ellipsis(ref input_text);
            }
            if (Replace_Plus_Minus_MenuItem.Checked)
            {
                input_text = Replace_Plus_Minus(ref input_text);
            }
            if (Replace_Quotes_MenuItem.Checked)
            {
                input_text = Replace_Quotes(ref input_text);
            }
            if (True_Punctuation_MenuItem.Checked)
            {
                input_text = True_Punctuation(ref input_text);
            }
            if (Replace_Dash_To_Minus_MenuItem.Checked)
            {
                input_text = Replace_Dash_To_Minus(ref input_text);
            }

            updated_textbox.Text = input_text;
        }

        private void Replace_Every_Second_Word_Heart_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void Add_Non_Breaking_Space_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void Replace_Ellipsis_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void Replace_Plus_Minus_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void Replace_Quotes_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void Add_Space_After_Comma_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void Replace_Dash_To_Minus_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void Every_Second_Letter_Upper_MenuItem_Click(object sender, EventArgs e)
        {
            Set_Formatting();
        }

        private void input_textbox_Enter(object sender, EventArgs e)
        {
            if (input_textbox.Text == "Введите текст, который нужно исправить...")
            {
                input_textbox.Text = string.Empty;
            }
        }

        private void updated_textbox_Enter(object sender, EventArgs e)
        {
            if (updated_textbox.Text == "Здесь появится отредактированный текст...")
            {
                input_textbox.Text = string.Empty;
            }
        }

    }

}
