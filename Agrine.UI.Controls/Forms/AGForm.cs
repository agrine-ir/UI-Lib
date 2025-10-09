using Agrine.UI.Sounds.Manager;

namespace Agrine.UI.Controls.Forms
{
    public class AGForm : DevComponents.DotNetBar.OfficeForm
    {
        private StartupSound sound;
        private System.ComponentModel.IContainer components;
        private DevComponents.DotNetBar.StyleManager MainStyleManager;
        private Agrine.UI.Controls.Core.Enums.Appearance.Themes theme = Core.Enums.Appearance.Themes.Auto;
        private Agrine.UI.Controls.Core.Enums.Appearance.Styles style = Core.Enums.Appearance.Styles.Office2007;
        private Agrine.UI.Controls.Core.Enums.Appearance.Palettes palette = Core.Enums.Appearance.Palettes.Gray;
        private StartupSound startupSound;
        public AGForm()
        {
            this.InitializeComponent();
        }


        public Agrine.UI.Controls.Core.Enums.Appearance.Themes Theme
        {
            get { return this.theme; }
            set
            {
                this.theme = value;
                switch (value)
                {
                    case Core.Enums.Appearance.Themes.Auto:
                        break;
                    case Core.Enums.Appearance.Themes.Light:
                        break;
                    case Core.Enums.Appearance.Themes.Dark:
                        break;
                }
            }
        }

        public Agrine.UI.Controls.Core.Enums.Appearance.Styles Style
        {
            get { return this.style; }
            set
            {
                this.style = value;
                switch (value)
                {
                    case Core.Enums.Appearance.Styles.Office2007:
                        this.MainStyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
                        break;
                    case Core.Enums.Appearance.Styles.Office2010:
                        this.MainStyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
                        break;
                }
            }
        }

        public Agrine.UI.Controls.Core.Enums.Appearance.Palettes Palette
        {
            get { return this.palette; }
            set
            {
                this.palette = value;
                switch (value)
                {
                    case Core.Enums.Appearance.Palettes.White:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.White;
                        break;
                    case Core.Enums.Appearance.Palettes.Black:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Black;
                        break;
                    case Core.Enums.Appearance.Palettes.Gray:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Gray;
                        break;
                    case Core.Enums.Appearance.Palettes.Red:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Crimson;
                        break;
                    case Core.Enums.Appearance.Palettes.Blue:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.RoyalBlue;
                        break;
                    case Core.Enums.Appearance.Palettes.Green:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Green;
                        break;
                    case Core.Enums.Appearance.Palettes.Magenta:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.SlateBlue;
                        break;
                    case Core.Enums.Appearance.Palettes.Gold:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Gold;
                        break;
                    case Core.Enums.Appearance.Palettes.Orange:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Coral;
                        break;
                    case Core.Enums.Appearance.Palettes.Teal:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Teal;
                        break;
                    case Core.Enums.Appearance.Palettes.Pink:
                        this.MainStyleManager.ManagerColorTint = System.Drawing.Color.DeepPink;
                        break;
                }
            }
        }




        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainStyleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // MainStyleManager
            // 
            this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Gray;
            this.MainStyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.MainStyleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42))))));
            // 
            // AGForm
            // 
            this.CaptionFont = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(590, 360);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AGForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنجره";
            this.TitleText = "پنجره";
            this.ResumeLayout(false);

        }
    }
}
