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
            Agrine.UI.Sounds.Manager.StartupSound startupSound = new Agrine.UI.Sounds.Manager.StartupSound(this, Agrine.UI.Sounds.Core.Enums.StartupSoundTypes.SSoundOne);
        }
    }
}
