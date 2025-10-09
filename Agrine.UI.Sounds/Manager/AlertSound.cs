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
        private Form form;
        private SoundPlayer soundPlayer;
        private Agrine.UI.Sounds.Core.Enums.AlertSoundTypes type = Core.Enums.AlertSoundTypes.ASoundOne;
        private readonly Stream ASoundOne = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Alert.DSound.wav");

        public AlertSound()
        {
            this.form = new Form();
            this.form.Load += new EventHandler(this.Alert_Loaded);
            this.soundPlayer = new SoundPlayer();
        }

        public bool Enable { get; set; } = true;



        public Agrine.UI.Sounds.Core.Enums.AlertSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.AlertSoundTypes.ASoundOne:
                        this.soundPlayer.Stream = ASoundOne;
                        break;
                    case Core.Enums.AlertSoundTypes.ASoundTwo:
                        this.soundPlayer.Stream = ASoundOne;
                        break;
                }
            }
        }

        private void Alert_Loaded(object sender, EventArgs e)
        {
            if (this.Enable)
                this.soundPlayer.Play();
        }
    }
}
