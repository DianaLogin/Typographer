using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typographer
{
    public partial class typograph_Form : Form
    {
        public typograph_Form()
        {
            InitializeComponent();
            new ToolTip().SetToolTip(logo_picture, "The desired tool-tip text.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
            string inputText = input_textbox.Text;
            string outputText = ProcessText(inputText);
            updated_textbox.Text = outputText;
        }

        private string ProcessText(string inputText)
        {
            // Удаление лишних пробелов
            inputText = Regex.Replace(inputText, @"\s+", " ");

            // Замена троеточий на...
            inputText = inputText.Replace("...", "...");

            // Замена символов степени на их числовые эквиваленты
            inputText = Regex.Replace(inputText, @"(\d+)\^", "$1^");

            // Замена кавычек программистов на ёлочки
            inputText = inputText.Replace("\"", "«");

            // Замена кавычек лапок на ёлочки
            inputText = inputText.Replace("\"", "«");

            // Замена плюс-минус на ±
            inputText = inputText.Replace("+-", "±");

            // Замена буквы е на ё
            inputText = inputText.Replace("е", "ё");

            // Модификация регистра букв: каждая вторая буква становится заглавной
            StringBuilder sb = new StringBuilder(inputText.Length);
            for (int i = 0; i < inputText.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(char.ToUpper(inputText[i]));
                }
                else
                {
                    sb.Append(inputText[i]);
                }
            }
            inputText = sb.ToString();

            // Замена каждого второго слова на знак сердечка
            string[] words = inputText.Split(' ');
            for (int i = 1; i < words.Length; i += 2)
            {
                words[i] = "❤";
            }
            inputText = string.Join(" ", words);

            return inputText;
        }
    }
    
}
