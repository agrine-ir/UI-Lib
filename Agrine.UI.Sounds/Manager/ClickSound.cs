using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Agrine.UI.Sounds.Manager
{
    public class ClickSound : Core.Interfaces.ISoundManager
    {
        private Button button;
        private SoundPlayer soundPlayer;
        private Agrine.UI.Sounds.Core.Enums.ClickSoundTypes type = Core.Enums.ClickSoundTypes.CSoundOne;
        private readonly Stream CSoundOne = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Click.ASound.wav");
        private readonly Stream CSoundTwo = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Click.HSound.wav");

        public ClickSound()
        {
            this.button = new Button();
            this.button.Click += new EventHandler(this.Button_Clicked);
            this.soundPlayer = new SoundPlayer();
        }

        public bool Enable { get; set; } = true;



        public Agrine.UI.Sounds.Core.Enums.ClickSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.ClickSoundTypes.CSoundOne:
                        this.soundPlayer.Stream = CSoundOne;
                        break;
                    case Core.Enums.ClickSoundTypes.CSoundTwo:
                        this.soundPlayer.Stream = CSoundTwo;
                        break;
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (this.Enable)
                this.soundPlayer.Play();
        }


    }
}
