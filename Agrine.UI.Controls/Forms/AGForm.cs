using Agrine.UI.Sounds.Manager;
using DevComponents.DotNetBar;
using System.ComponentModel;


namespace Agrine.UI.Controls.Forms
{
    /// <summary>
    /// Represents a custom base form with built-in theme, style, palette, and startup sound control.
    /// </summary>
    public class AGForm : DevComponents.DotNetBar.OfficeForm
    {
        #region Fields

        private StartupSound startupSound;
        private System.ComponentModel.IContainer components;
        private DevComponents.DotNetBar.StyleManager MainStyleManager;

        private Agrine.UI.Controls.Core.Enums.Appearance.Themes theme = Core.Enums.Appearance.Themes.Auto;
        private Agrine.UI.Controls.Core.Enums.Appearance.Styles style = Core.Enums.Appearance.Styles.Office2007;
        private Agrine.UI.Controls.Core.Enums.Appearance.Palettes palette = Core.Enums.Appearance.Palettes.Gray;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AGForm"/> class and configures default appearance settings.
        /// </summary>
        public AGForm()
        {
            InitializeComponent();
            this.startupSound = new StartupSound(this);
        }

        #endregion

        #region Sound Settings

        [Category("Sound")]
        /// <summary>
        /// Gets or sets a value indicating whether the form's startup sound is enabled.
        /// </summary>
        public bool EnableSound
        {
            get => this.startupSound.Enable;
            set => this.startupSound.Enable = value;
        }

        [Category("Sound")]
        /// <summary>
        /// Gets or sets the type of sound played when the form starts.
        /// </summary>
        public Agrine.UI.Sounds.Core.Enums.StartupSoundTypes SoundTypes
        {
            get => this.startupSound.Type;
            set => this.startupSound.Type = value;
        }

        #endregion

        #region Appearance Settings

        [Category("Appearance Pro")]
        /// <summary>
        /// Gets or sets the overall theme of the form (Auto, Light, Dark).
        /// </summary>
        public Agrine.UI.Controls.Core.Enums.Appearance.Themes Theme
        {
            get => this.theme;
            set
            {
                this.theme = value;

                // TODO: Implement theme switching logic if needed.
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

        [Category("Appearance Pro")]
        /// <summary>
        /// Gets or sets the visual style (e.g., Office2007, Office2010).
        /// </summary>
        public Agrine.UI.Controls.Core.Enums.Appearance.Styles Style
        {
            get => this.style;
            set
            {
                this.style = value;

                // Apply the selected style to the main style manager.
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

        [Category("Appearance Pro")]
        /// <summary>
        /// Gets or sets the color palette of the form.
        /// </summary>
        public Agrine.UI.Controls.Core.Enums.Appearance.Palettes Palette
        {
            get => this.palette;
            set
            {
                this.palette = value;

                // Apply a color tint based on the selected palette.
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

        #endregion

        #region Initialization

        /// <summary>
        /// Initializes the form components and sets default style parameters.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainStyleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();

            // MainStyleManager configuration
            this.MainStyleManager.ManagerColorTint = System.Drawing.Color.Gray;
            this.MainStyleManager.ManagerStyle = eStyle.Office2007VistaGlass;
            this.MainStyleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(
                System.Drawing.Color.White,
                System.Drawing.Color.FromArgb(183, 71, 42)
            );

            // AGForm configuration
            this.CaptionFont = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(590, 360);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular);
            this.Name = "AGForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنجره";
            this.TitleText = "پنجره";

            this.ResumeLayout(false);
        }

        #endregion
    }
}
