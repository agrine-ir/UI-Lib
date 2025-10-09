using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Agrine.UI.Sounds.Manager
{
    public class ClickSound : Core.Interfaces.ISoundManager
    {
        private SoundPlayer soundPlayer;
        private string soundLocation = "Agrine.UI.Sounds.Resources.Click.ASound.wav";
        private Agrine.UI.Sounds.Core.Enums.ClickSoundTypes type = Core.Enums.ClickSoundTypes.CSoundOne;

        public ClickSound()
        {
            if (this.Enable && this.Button != null)
                this.Button.Click += new EventHandler(this.Button_Clicked);
        }

        public ClickSound(System.Windows.Forms.Button button, Agrine.UI.Sounds.Core.Enums.ClickSoundTypes type = Core.Enums.ClickSoundTypes.CSoundOne, bool enable = true)
        {
            this.Enable = enable;
            this.Button = button;
            this.Type = type;

            if (this.Enable && this.Button != null)
                this.Button.Click += new EventHandler(this.Button_Clicked);

        }

        public bool Enable { get; set; } = true;

        public System.Windows.Forms.Button Button { get; set; } = null;



        public Agrine.UI.Sounds.Core.Enums.ClickSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.ClickSoundTypes.CSoundOne:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Click.ASound.wav";
                        break;
                    case Core.Enums.ClickSoundTypes.CSoundTwo:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Click.HSound.wav";
                        break;
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (this.Enable)
            {
                System.Reflection.Assembly asm = Assembly.Load("Agrine.UI.Sounds");

                using (Stream stream = asm.GetManifestResourceStream(this.soundLocation))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("مشکلی در پخش صدای کلیک به وجود آمده است ! " + this.soundLocation);
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
