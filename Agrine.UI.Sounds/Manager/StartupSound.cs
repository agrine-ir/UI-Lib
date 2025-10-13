using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrine.UI.Sounds.Manager
{
    public class StartupSound : Core.Interfaces.ISoundManager
    {
        private SoundPlayer soundPlayer;
        private string soundLocation = "Agrine.UI.Sounds.Resources.Startup.SplashScreenSound.wav";
        private Agrine.UI.Sounds.Core.Enums.StartupSoundTypes type = Core.Enums.StartupSoundTypes.SSoundOne;

        public StartupSound()
        {
            if (this.Enable && this.Window != null)
                this.Window.Load += new EventHandler(this.Window_Loaded);
        }

        public StartupSound(Form window, Agrine.UI.Sounds.Core.Enums.StartupSoundTypes type = Core.Enums.StartupSoundTypes.SSoundOne, bool enable = true)
        {
            this.Enable = enable;
            this.Window = window;
            this.Type = type;

            if (this.Enable && this.Window != null)
                this.Window.Load += new EventHandler(this.Window_Loaded);

        }

        public bool Enable { get; set; } = true;

        public Form Window { get; set; } = null;



        public Agrine.UI.Sounds.Core.Enums.StartupSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.StartupSoundTypes.SSoundOne:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Startup.SplashScreenSound.wav";
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundTwo:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Startup.BSSound.wav";
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundThree:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Startup.CSSound.wav";
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundFour:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Startup.DSSound.wav";
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundFive:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Startup.FSSound.wav";
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundSix:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Startup.ASSound.wav";
                        break;
                }
            }
        }

        private void Window_Loaded(object sender, EventArgs e)
        {

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;



            if (this.Enable)
            {
                System.Reflection.Assembly asm = Assembly.Load("Agrine.UI.Sounds");

                using (Stream stream = asm.GetManifestResourceStream(this.soundLocation))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("مشکلی در پخش صدای نمایش پنجره به وجود آمده است ! " + this.soundLocation);
                        return;
                    }

                    using (this.soundPlayer = new SoundPlayer(stream))
                    {
                        this.soundPlayer.Play();
                    }
                }
            }

        }

    }
}
