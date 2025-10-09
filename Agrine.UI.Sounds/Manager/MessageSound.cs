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
    public class MessageSound
    {
        private Form form;
        private SoundPlayer soundPlayer;
        private Agrine.UI.Sounds.Core.Enums.MessageSoundTypes type = Core.Enums.MessageSoundTypes.MSoundOne;
        private readonly Stream MSoundOne = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Message.BSound.wav");
        private readonly Stream MSoundTwo = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Message.CSound.wav");
        private readonly Stream MSoundThree = Assembly.GetExecutingAssembly().GetManifestResourceStream("Agrine.UI.Sounds.Resources.Message.GSound.wav");

        public MessageSound()
        {
            this.form = new Form();
            this.form.Load += new EventHandler(this.Message_Loaded);
            this.soundPlayer = new SoundPlayer();
        }

        public bool Enable { get; set; } = true;



        public Agrine.UI.Sounds.Core.Enums.MessageSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.MessageSoundTypes.MSoundOne:
                        this.soundPlayer.Stream = MSoundOne;
                        break;
                    case Core.Enums.MessageSoundTypes.MSoundTwo:
                        this.soundPlayer.Stream = MSoundTwo;
                        break;
                    case Core.Enums.MessageSoundTypes.MSoundThree:
                        this.soundPlayer.Stream = MSoundThree;
                        break;
                }
            }
        }

        private void Message_Loaded(object sender, EventArgs e)
        {
            if (this.Enable)
                this.soundPlayer.Play();
        }
    }
}
