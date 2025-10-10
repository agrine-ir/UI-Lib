using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Agrine.UI.Controls.Forms.AGForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX2.Checked)
                this.Style = Agrine.UI.Controls.Core.Enums.Appearance.Styles.Office2010;
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX1.Checked)
                this.Style = Agrine.UI.Controls.Core.Enums.Appearance.Styles.Office2007;
        }
    }
}
