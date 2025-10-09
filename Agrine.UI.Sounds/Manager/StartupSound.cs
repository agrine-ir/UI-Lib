using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrine.UI.Sounds.Manager
{
    public class StartupSound : Core.Interfaces.ISoundManager
    {
        private Form form;
        private SoundPlayer soundPlayer;
        private Agrine.UI.Sounds.Core.Enums.StartupSoundTypes type = Core.Enums.StartupSoundTypes.SSoundOne;
        private readonly Stream SSoundOne = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Startup.SplashScreenSound.wav");
        private readonly Stream SSoundTwo = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Startup.ASSound.wav");
        private readonly Stream SSoundThree = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Startup.BSSound.wav");
        private readonly Stream SSoundFour = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Startup.CSSound.wav");
        private readonly Stream SSoundFive = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Startup.DSSound.wav");
        private readonly Stream SSoundSix = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Startup.FSSound.wav");

        public StartupSound()
        {
            this.form = new Form();
            this.form.Load += new EventHandler(this.Form_Loaded);
            this.soundPlayer = new SoundPlayer();
        }

        public bool Enable { get; set; } = true;



        public Agrine.UI.Sounds.Core.Enums.StartupSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.StartupSoundTypes.SSoundOne:
                        this.soundPlayer.Stream = SSoundOne;
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundTwo:
                        this.soundPlayer.Stream = SSoundTwo;
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundThree:
                        this.soundPlayer.Stream = SSoundThree;
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundFour:
                        this.soundPlayer.Stream = SSoundFour;
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundFive:
                        this.soundPlayer.Stream = SSoundFive;
                        break;
                    case Core.Enums.StartupSoundTypes.SSoundSix:
                        this.soundPlayer.Stream = SSoundSix;
                        break;
                }
            }
        }

        private void Form_Loaded(object sender, EventArgs e)
        {
            if (this.Enable)
                this.soundPlayer.Play();
        }

    }
}
