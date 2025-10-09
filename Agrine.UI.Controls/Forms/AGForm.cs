using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrine.UI.Controls.Forms
{
    public class AGForm : DevComponents.DotNetBar.OfficeForm
    {
        private DevComponents.DotNetBar.StyleManager MainStyleManager;
        private System.ComponentModel.IContainer components;
        private Agrine.UI.Controls.Core.Enums.Appearance.Themes theme = Core.Enums.Appearance.Themes.Auto;
        private Agrine.UI.Controls.Core.Enums.Appearance.Styles style = Core.Enums.Appearance.Styles.Office2007;
        private Agrine.UI.Controls.Core.Enums.Appearance.Palettes palette = Core.Enums.Appearance.Palettes.Gray;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;


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


        public AGForm()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainStyleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStyleManager
            // 
            this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Gray;
            this.MainStyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.MainStyleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42))))));
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(83, 114);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(121, 55);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "buttonX1";
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(205)))), ((int)(((byte)(238)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Location = new System.Drawing.Point(247, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(278, 194);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 32);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(278, 162);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "tabItem1";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 32);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(278, 162);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 5;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "tabItem2";
            // 
            // AGForm
            // 
            this.CaptionFont = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(590, 360);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AGForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنجره";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
