namespace Typographer
{
    partial class Typograph_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Typograph_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_textbox = new System.Windows.Forms.RichTextBox();
            this.copy_btn = new System.Windows.Forms.Button();
            this.typograph_btn = new System.Windows.Forms.Button();
            this.arrow_picture = new System.Windows.Forms.PictureBox();
            this.theme_picture = new System.Windows.Forms.PictureBox();
            this.about_picture = new System.Windows.Forms.PictureBox();
            this.updated_textbox = new System.Windows.Forms.RichTextBox();
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace_Every_Second_Word_Heart_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Non_Breaking_Space_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace_Ellipsis_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace_Plus_Minus_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace_Quotes_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.True_Punctuation_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace_Dash_To_Minus_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Every_Second_Letter_Upper_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.input_textbox);
            this.panel1.Controls.Add(this.copy_btn);
            this.panel1.Controls.Add(this.typograph_btn);
            this.panel1.Controls.Add(this.arrow_picture);
            this.panel1.Controls.Add(this.theme_picture);
            this.panel1.Controls.Add(this.about_picture);
            this.panel1.Controls.Add(this.updated_textbox);
            this.panel1.Controls.Add(this.logo_picture);
            this.panel1.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // input_textbox
            // 
            this.input_textbox.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.input_textbox, "input_textbox");
            this.input_textbox.ForeColor = System.Drawing.Color.Black;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Enter += new System.EventHandler(this.input_textbox_Enter);
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.OldLace;
            resources.ApplyResources(this.copy_btn, "copy_btn");
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click_1);
            // 
            // typograph_btn
            // 
            this.typograph_btn.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.typograph_btn, "typograph_btn");
            this.typograph_btn.Name = "typograph_btn";
            this.typograph_btn.UseVisualStyleBackColor = false;
            this.typograph_btn.Click += new System.EventHandler(this.typograph_btn_Click);
            // 
            // arrow_picture
            // 
            resources.ApplyResources(this.arrow_picture, "arrow_picture");
            this.arrow_picture.Name = "arrow_picture";
            this.arrow_picture.TabStop = false;
            // 
            // theme_picture
            // 
            this.theme_picture.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.theme_picture, "theme_picture");
            this.theme_picture.Name = "theme_picture";
            this.theme_picture.TabStop = false;
            this.theme_picture.Click += new System.EventHandler(this.theme_picture_Click);
            // 
            // about_picture
            // 
            resources.ApplyResources(this.about_picture, "about_picture");
            this.about_picture.Name = "about_picture";
            this.about_picture.TabStop = false;
            this.about_picture.Click += new System.EventHandler(this.about_picture_Click);
            // 
            // updated_textbox
            // 
            this.updated_textbox.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.updated_textbox, "updated_textbox");
            this.updated_textbox.ForeColor = System.Drawing.Color.Black;
            this.updated_textbox.Name = "updated_textbox";
            this.updated_textbox.Enter += new System.EventHandler(this.updated_textbox_Enter);
            // 
            // logo_picture
            // 
            resources.ApplyResources(this.logo_picture, "logo_picture");
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Replace_Every_Second_Word_Heart_MenuItem,
            this.Add_Non_Breaking_Space_MenuItem,
            this.Replace_Ellipsis_MenuItem,
            this.Replace_Plus_Minus_MenuItem,
            this.Replace_Quotes_MenuItem,
            this.True_Punctuation_MenuItem,
            this.Replace_Dash_To_Minus_MenuItem,
            this.Every_Second_Letter_Upper_MenuItem});
            resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            // 
            // Replace_Every_Second_Word_Heart_MenuItem
            // 
            this.Replace_Every_Second_Word_Heart_MenuItem.CheckOnClick = true;
            this.Replace_Every_Second_Word_Heart_MenuItem.Name = "Replace_Every_Second_Word_Heart_MenuItem";
            resources.ApplyResources(this.Replace_Every_Second_Word_Heart_MenuItem, "Replace_Every_Second_Word_Heart_MenuItem");
            this.Replace_Every_Second_Word_Heart_MenuItem.Click += new System.EventHandler(this.Replace_Every_Second_Word_Heart_MenuItem_Click);
            // 
            // Add_Non_Breaking_Space_MenuItem
            // 
            this.Add_Non_Breaking_Space_MenuItem.CheckOnClick = true;
            this.Add_Non_Breaking_Space_MenuItem.Name = "Add_Non_Breaking_Space_MenuItem";
            resources.ApplyResources(this.Add_Non_Breaking_Space_MenuItem, "Add_Non_Breaking_Space_MenuItem");
            this.Add_Non_Breaking_Space_MenuItem.Click += new System.EventHandler(this.Add_Non_Breaking_Space_MenuItem_Click);
            // 
            // Replace_Ellipsis_MenuItem
            // 
            this.Replace_Ellipsis_MenuItem.CheckOnClick = true;
            this.Replace_Ellipsis_MenuItem.Name = "Replace_Ellipsis_MenuItem";
            resources.ApplyResources(this.Replace_Ellipsis_MenuItem, "Replace_Ellipsis_MenuItem");
            this.Replace_Ellipsis_MenuItem.Click += new System.EventHandler(this.Replace_Ellipsis_MenuItem_Click);
            // 
            // Replace_Plus_Minus_MenuItem
            // 
            this.Replace_Plus_Minus_MenuItem.CheckOnClick = true;
            this.Replace_Plus_Minus_MenuItem.Name = "Replace_Plus_Minus_MenuItem";
            resources.ApplyResources(this.Replace_Plus_Minus_MenuItem, "Replace_Plus_Minus_MenuItem");
            this.Replace_Plus_Minus_MenuItem.Click += new System.EventHandler(this.Replace_Plus_Minus_MenuItem_Click);
            // 
            // Replace_Quotes_MenuItem
            // 
            this.Replace_Quotes_MenuItem.CheckOnClick = true;
            this.Replace_Quotes_MenuItem.Name = "Replace_Quotes_MenuItem";
            resources.ApplyResources(this.Replace_Quotes_MenuItem, "Replace_Quotes_MenuItem");
            this.Replace_Quotes_MenuItem.Click += new System.EventHandler(this.Replace_Quotes_MenuItem_Click);
            // 
            // True_Punctuation_MenuItem
            // 
            this.True_Punctuation_MenuItem.CheckOnClick = true;
            this.True_Punctuation_MenuItem.Name = "True_Punctuation_MenuItem";
            resources.ApplyResources(this.True_Punctuation_MenuItem, "True_Punctuation_MenuItem");
            this.True_Punctuation_MenuItem.Click += new System.EventHandler(this.Add_Space_After_Comma_MenuItem_Click);
            // 
            // Replace_Dash_To_Minus_MenuItem
            // 
            this.Replace_Dash_To_Minus_MenuItem.CheckOnClick = true;
            this.Replace_Dash_To_Minus_MenuItem.Name = "Replace_Dash_To_Minus_MenuItem";
            resources.ApplyResources(this.Replace_Dash_To_Minus_MenuItem, "Replace_Dash_To_Minus_MenuItem");
            this.Replace_Dash_To_Minus_MenuItem.Click += new System.EventHandler(this.Replace_Dash_To_Minus_MenuItem_Click);
            // 
            // Every_Second_Letter_Upper_MenuItem
            // 
            this.Every_Second_Letter_Upper_MenuItem.CheckOnClick = true;
            this.Every_Second_Letter_Upper_MenuItem.Name = "Every_Second_Letter_Upper_MenuItem";
            resources.ApplyResources(this.Every_Second_Letter_Upper_MenuItem, "Every_Second_Letter_Upper_MenuItem");
            this.Every_Second_Letter_Upper_MenuItem.Click += new System.EventHandler(this.Every_Second_Letter_Upper_MenuItem_Click);
            // 
            // Typograph_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Typograph_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.RichTextBox updated_textbox;
        private System.Windows.Forms.PictureBox about_picture;
        private System.Windows.Forms.PictureBox theme_picture;
        private System.Windows.Forms.PictureBox arrow_picture;
        private System.Windows.Forms.Button typograph_btn;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Replace_Every_Second_Word_Heart_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Non_Breaking_Space_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Replace_Ellipsis_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Replace_Plus_Minus_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Replace_Quotes_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem True_Punctuation_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Replace_Dash_To_Minus_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Every_Second_Letter_Upper_MenuItem;
        private System.Windows.Forms.RichTextBox input_textbox;
    }
}

