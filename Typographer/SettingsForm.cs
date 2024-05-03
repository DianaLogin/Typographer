using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typographer
{
    public partial class SettingsForm : Form
    {
        public bool CheckBoxReplaceEverySecondWord { get; set; }
        public bool CheckBoxAddNonBreakingSpace { get; set; }
        public bool CheckBoxReplaceEllipsis { get; set; }
        public bool CheckBoxReplacePlusMinus { get; set; }
        public bool CheckBoxReplaceQuotes { get; set; }
        public bool CheckBoxAddSpaceAfterComma { get; set; }
        public bool CheckBoxReplaceDash { get; set; }
        public bool CheckBoxEverySecondLetterUpper { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBox_Replace_Every_Second_Word.Checked = true;
            checkBox_Add_Non_Breaking_Space.Checked = true;
            checkBox_Replace_Ellipsis.Checked = true;
            checkBox_Replace_Plus_Minus.Checked = true;
            checkBox_Replace_Quotes.Checked = true;
            checkBox_Add_Space_After_Comma.Checked = true;
            checkBox_Replace_Dash.Checked = true;
            checkBox_Every_Second_Letter_Upper.Checked = true;
        }

       

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ok_btn_Click(sender, e);
        }

        
    }
}
