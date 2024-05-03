namespace Typographer
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBox_Replace_Every_Second_Word = new System.Windows.Forms.CheckBox();
            this.checkBox_Add_Non_Breaking_Space = new System.Windows.Forms.CheckBox();
            this.checkBox_Replace_Ellipsis = new System.Windows.Forms.CheckBox();
            this.checkBox_Replace_Plus_Minus = new System.Windows.Forms.CheckBox();
            this.checkBox_Replace_Quotes = new System.Windows.Forms.CheckBox();
            this.checkBox_Add_Space_After_Comma = new System.Windows.Forms.CheckBox();
            this.checkBox_Replace_Dash = new System.Windows.Forms.CheckBox();
            this.checkBox_Every_Second_Letter_Upper = new System.Windows.Forms.CheckBox();
            this.check_pictureBox = new System.Windows.Forms.PictureBox();
            this.choose_label = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.beauty_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.check_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_Replace_Every_Second_Word
            // 
            this.checkBox_Replace_Every_Second_Word.AutoSize = true;
            this.checkBox_Replace_Every_Second_Word.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Replace_Every_Second_Word.Location = new System.Drawing.Point(62, 122);
            this.checkBox_Replace_Every_Second_Word.Name = "checkBox_Replace_Every_Second_Word";
            this.checkBox_Replace_Every_Second_Word.Size = new System.Drawing.Size(639, 51);
            this.checkBox_Replace_Every_Second_Word.TabIndex = 0;
            this.checkBox_Replace_Every_Second_Word.Text = "Заменить каждое второе слово на ❤️";
            this.checkBox_Replace_Every_Second_Word.UseVisualStyleBackColor = true;
            // 
            // checkBox_Add_Non_Breaking_Space
            // 
            this.checkBox_Add_Non_Breaking_Space.AutoSize = true;
            this.checkBox_Add_Non_Breaking_Space.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.checkBox_Add_Non_Breaking_Space.Location = new System.Drawing.Point(62, 174);
            this.checkBox_Add_Non_Breaking_Space.Name = "checkBox_Add_Non_Breaking_Space";
            this.checkBox_Add_Non_Breaking_Space.Size = new System.Drawing.Size(1264, 51);
            this.checkBox_Add_Non_Breaking_Space.TabIndex = 1;
            this.checkBox_Add_Non_Breaking_Space.Text = "Заменить пробел на непереносимый пробел между числами и словом \"10 В\"";
            this.checkBox_Add_Non_Breaking_Space.UseVisualStyleBackColor = true;
            // 
            // checkBox_Replace_Ellipsis
            // 
            this.checkBox_Replace_Ellipsis.AutoSize = true;
            this.checkBox_Replace_Ellipsis.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.checkBox_Replace_Ellipsis.Location = new System.Drawing.Point(62, 228);
            this.checkBox_Replace_Ellipsis.Name = "checkBox_Replace_Ellipsis";
            this.checkBox_Replace_Ellipsis.Size = new System.Drawing.Size(1069, 51);
            this.checkBox_Replace_Ellipsis.TabIndex = 2;
            this.checkBox_Replace_Ellipsis.Text = "Заменить последовательность двух точек (..) на многоточие (…)";
            this.checkBox_Replace_Ellipsis.UseVisualStyleBackColor = true;
            // 
            // checkBox_Replace_Plus_Minus
            // 
            this.checkBox_Replace_Plus_Minus.AutoSize = true;
            this.checkBox_Replace_Plus_Minus.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.checkBox_Replace_Plus_Minus.Location = new System.Drawing.Point(62, 284);
            this.checkBox_Replace_Plus_Minus.Name = "checkBox_Replace_Plus_Minus";
            this.checkBox_Replace_Plus_Minus.Size = new System.Drawing.Size(368, 51);
            this.checkBox_Replace_Plus_Minus.TabIndex = 3;
            this.checkBox_Replace_Plus_Minus.Text = "Заменить \"+-\" на \"±\"";
            this.checkBox_Replace_Plus_Minus.UseVisualStyleBackColor = true;
            // 
            // checkBox_Replace_Quotes
            // 
            this.checkBox_Replace_Quotes.AutoSize = true;
            this.checkBox_Replace_Quotes.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.checkBox_Replace_Quotes.Location = new System.Drawing.Point(62, 339);
            this.checkBox_Replace_Quotes.Name = "checkBox_Replace_Quotes";
            this.checkBox_Replace_Quotes.Size = new System.Drawing.Size(1058, 51);
            this.checkBox_Replace_Quotes.TabIndex = 4;
            this.checkBox_Replace_Quotes.Text = "Заменить кавычки программистов (\"\") на кавычки «ёлочки» («»)";
            this.checkBox_Replace_Quotes.UseVisualStyleBackColor = true;
            // 
            // checkBox_Add_Space_After_Comma
            // 
            this.checkBox_Add_Space_After_Comma.AutoSize = true;
            this.checkBox_Add_Space_After_Comma.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.checkBox_Add_Space_After_Comma.Location = new System.Drawing.Point(62, 391);
            this.checkBox_Add_Space_After_Comma.Name = "checkBox_Add_Space_After_Comma";
            this.checkBox_Add_Space_After_Comma.Size = new System.Drawing.Size(760, 51);
            this.checkBox_Add_Space_After_Comma.TabIndex = 5;
            this.checkBox_Add_Space_After_Comma.Text = "Добавить пробел после запятых в строке \",  \"";
            this.checkBox_Add_Space_After_Comma.UseVisualStyleBackColor = true;
            // 
            // checkBox_Replace_Dash
            // 
            this.checkBox_Replace_Dash.AutoSize = true;
            this.checkBox_Replace_Dash.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.checkBox_Replace_Dash.Location = new System.Drawing.Point(62, 440);
            this.checkBox_Replace_Dash.Name = "checkBox_Replace_Dash";
            this.checkBox_Replace_Dash.Size = new System.Drawing.Size(1198, 51);
            this.checkBox_Replace_Dash.TabIndex = 6;
            this.checkBox_Replace_Dash.Text = "Заменить одиночный дефис (-) на дефис с пробелами с обеих сторон (–)";
            this.checkBox_Replace_Dash.UseVisualStyleBackColor = true;
            // 
            // checkBox_Every_Second_Letter_Upper
            // 
            this.checkBox_Every_Second_Letter_Upper.AutoSize = true;
            this.checkBox_Every_Second_Letter_Upper.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.checkBox_Every_Second_Letter_Upper.Location = new System.Drawing.Point(62, 490);
            this.checkBox_Every_Second_Letter_Upper.Name = "checkBox_Every_Second_Letter_Upper";
            this.checkBox_Every_Second_Letter_Upper.Size = new System.Drawing.Size(740, 51);
            this.checkBox_Every_Second_Letter_Upper.TabIndex = 7;
            this.checkBox_Every_Second_Letter_Upper.Text = "Сделать каждую вторую букву ЗаГлАвНоЙ";
            this.checkBox_Every_Second_Letter_Upper.UseVisualStyleBackColor = true;
            // 
            // check_pictureBox
            // 
            this.check_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("check_pictureBox.Image")));
            this.check_pictureBox.Location = new System.Drawing.Point(1, 5);
            this.check_pictureBox.Name = "check_pictureBox";
            this.check_pictureBox.Size = new System.Drawing.Size(80, 76);
            this.check_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check_pictureBox.TabIndex = 8;
            this.check_pictureBox.TabStop = false;
            // 
            // choose_label
            // 
            this.choose_label.AutoSize = true;
            this.choose_label.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_label.Location = new System.Drawing.Point(87, 26);
            this.choose_label.Name = "choose_label";
            this.choose_label.Size = new System.Drawing.Size(851, 55);
            this.choose_label.TabIndex = 9;
            this.choose_label.Text = "Выберите фильтры редактирования текста";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Orange;
            this.ok_btn.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_btn.Location = new System.Drawing.Point(482, 596);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(340, 76);
            this.ok_btn.TabIndex = 11;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // beauty_label
            // 
            this.beauty_label.AutoSize = true;
            this.beauty_label.Location = new System.Drawing.Point(153, 607);
            this.beauty_label.Name = "beauty_label";
            this.beauty_label.Size = new System.Drawing.Size(1014, 29);
            this.beauty_label.TabIndex = 13;
            this.beauty_label.Text = "_____________________________________________________________________________";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1328, 701);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.choose_label);
            this.Controls.Add(this.check_pictureBox);
            this.Controls.Add(this.checkBox_Every_Second_Letter_Upper);
            this.Controls.Add(this.checkBox_Replace_Dash);
            this.Controls.Add(this.checkBox_Add_Space_After_Comma);
            this.Controls.Add(this.checkBox_Replace_Quotes);
            this.Controls.Add(this.checkBox_Replace_Plus_Minus);
            this.Controls.Add(this.checkBox_Replace_Ellipsis);
            this.Controls.Add(this.checkBox_Add_Non_Breaking_Space);
            this.Controls.Add(this.checkBox_Replace_Every_Second_Word);
            this.Controls.Add(this.beauty_label);
            this.MaximumSize = new System.Drawing.Size(1356, 780);
            this.MinimumSize = new System.Drawing.Size(1356, 780);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.check_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBox_Replace_Every_Second_Word;
        public System.Windows.Forms.CheckBox checkBox_Add_Non_Breaking_Space;
        public System.Windows.Forms.CheckBox checkBox_Replace_Ellipsis;
        public System.Windows.Forms.CheckBox checkBox_Replace_Plus_Minus;
        public System.Windows.Forms.CheckBox checkBox_Replace_Quotes;
        public System.Windows.Forms.CheckBox checkBox_Add_Space_After_Comma;
        public System.Windows.Forms.CheckBox checkBox_Replace_Dash;
        public System.Windows.Forms.CheckBox checkBox_Every_Second_Letter_Upper;
        public System.Windows.Forms.PictureBox check_pictureBox;
        public System.Windows.Forms.Label choose_label;
        public System.Windows.Forms.Button ok_btn;
        public System.Windows.Forms.Label beauty_label;
    }
}