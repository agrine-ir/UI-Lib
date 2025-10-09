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
    public class AlertSound
    {
        private SoundPlayer soundPlayer;
        private string soundLocation = "Agrine.UI.Sounds.Resources.Alert.DSound.wav";
        private Agrine.UI.Sounds.Core.Enums.AlertSoundTypes type = Core.Enums.AlertSoundTypes.ASoundOne;

        public AlertSound()
        {
            if (this.Enable && this.Alert != null)
                this.Alert.Load += new EventHandler(this.Alert_Loaded);
        }

        public AlertSound(Form alert, Agrine.UI.Sounds.Core.Enums.AlertSoundTypes type = Core.Enums.AlertSoundTypes.ASoundOne, bool enable = true)
        {
            this.Enable = enable;
            this.Alert = alert;
            this.Type = type;

            if (this.Enable && this.Alert != null)
                this.Alert.Load += new EventHandler(this.Alert_Loaded);

        }

        public bool Enable { get; set; } = true;

        public Form Alert { get; set; } = null;



        public Agrine.UI.Sounds.Core.Enums.AlertSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.AlertSoundTypes.ASoundOne:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Alert.DSound.wav";
                        break;
                    case Core.Enums.AlertSoundTypes.ASoundTwo:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Alert.DSound.wav";
                        break;
                }
            }
        }

        private void Alert_Loaded(object sender, EventArgs e)
        {
            if (this.Enable)
            {
                System.Reflection.Assembly asm = Assembly.Load("Agrine.UI.Sounds");

                using (Stream stream = asm.GetManifestResourceStream(this.soundLocation))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("مشکلی در پخش صدای نمایش اعلان به وجود آمده است ! " + this.soundLocation);
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
