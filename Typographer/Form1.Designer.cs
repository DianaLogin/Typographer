﻿namespace Typographer
{
    partial class typograph_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(typograph_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.input_textbox = new System.Windows.Forms.RichTextBox();
            this.updated_textbox = new System.Windows.Forms.RichTextBox();
            this.settings_picture = new System.Windows.Forms.PictureBox();
            this.about_picture = new System.Windows.Forms.PictureBox();
            this.theme_picture = new System.Windows.Forms.PictureBox();
            this.arrow_picture = new System.Windows.Forms.PictureBox();
            this.typograph_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.typograph_btn);
            this.panel1.Controls.Add(this.arrow_picture);
            this.panel1.Controls.Add(this.theme_picture);
            this.panel1.Controls.Add(this.about_picture);
            this.panel1.Controls.Add(this.settings_picture);
            this.panel1.Controls.Add(this.updated_textbox);
            this.panel1.Controls.Add(this.input_textbox);
            this.panel1.Controls.Add(this.logo_picture);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // logo_picture
            // 
            resources.ApplyResources(this.logo_picture, "logo_picture");
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.TabStop = false;
            this.logo_picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // input_textbox
            // 
            resources.ApplyResources(this.input_textbox, "input_textbox");
            this.input_textbox.Name = "input_textbox";
            // 
            // updated_textbox
            // 
            resources.ApplyResources(this.updated_textbox, "updated_textbox");
            this.updated_textbox.Name = "updated_textbox";
            // 
            // settings_picture
            // 
            resources.ApplyResources(this.settings_picture, "settings_picture");
            this.settings_picture.Name = "settings_picture";
            this.settings_picture.TabStop = false;
            this.settings_picture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // about_picture
            // 
            resources.ApplyResources(this.about_picture, "about_picture");
            this.about_picture.Name = "about_picture";
            this.about_picture.TabStop = false;
            // 
            // theme_picture
            // 
            resources.ApplyResources(this.theme_picture, "theme_picture");
            this.theme_picture.Name = "theme_picture";
            this.theme_picture.TabStop = false;
            // 
            // arrow_picture
            // 
            resources.ApplyResources(this.arrow_picture, "arrow_picture");
            this.arrow_picture.Name = "arrow_picture";
            this.arrow_picture.TabStop = false;
            // 
            // typograph_btn
            // 
            this.typograph_btn.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.typograph_btn, "typograph_btn");
            this.typograph_btn.Name = "typograph_btn";
            this.typograph_btn.UseVisualStyleBackColor = false;
            this.typograph_btn.Click += new System.EventHandler(this.typograph_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.OldLace;
            resources.ApplyResources(this.clear_btn, "clear_btn");
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // typograph_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "typograph_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.RichTextBox updated_textbox;
        private System.Windows.Forms.RichTextBox input_textbox;
        private System.Windows.Forms.PictureBox settings_picture;
        private System.Windows.Forms.PictureBox about_picture;
        private System.Windows.Forms.PictureBox theme_picture;
        private System.Windows.Forms.PictureBox arrow_picture;
        private System.Windows.Forms.Button typograph_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

