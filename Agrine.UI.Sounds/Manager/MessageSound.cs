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
    public class MessageSound : Core.Interfaces.ISoundManager
    {
        private SoundPlayer soundPlayer;
        private string soundLocation = "Agrine.UI.Sounds.Resources.Message.BSound.wav";
        private Agrine.UI.Sounds.Core.Enums.MessageSoundTypes type = Core.Enums.MessageSoundTypes.MSoundOne;

        public MessageSound()
        {
            if (this.Enable && this.Message != null)
                this.Message.Load += new EventHandler(this.Message_Loaded);
        }

        public MessageSound(Form message, Agrine.UI.Sounds.Core.Enums.MessageSoundTypes type = Core.Enums.MessageSoundTypes.MSoundOne, bool enable = true)
        {
            this.Enable = enable;
            this.Message = message;
            this.Type = type;

            if (this.Enable && this.Message != null)
                this.Message.Load += new EventHandler(this.Message_Loaded);

        }

        public bool Enable { get; set; } = true;

        public Form Message { get; set; } = null;



        public Agrine.UI.Sounds.Core.Enums.MessageSoundTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (value)
                {
                    case Core.Enums.MessageSoundTypes.MSoundOne:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Message.BSound.wav";
                        break;
                    case Core.Enums.MessageSoundTypes.MSoundTwo:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Message.CSound.wav";
                        break;
                    case Core.Enums.MessageSoundTypes.MSoundThree:
                        this.soundLocation = "Agrine.UI.Sounds.Resources.Message.GSound.wav";
                        break;
                }
            }
        }

        private void Message_Loaded(object sender, EventArgs e)
        {
            if (this.Enable)
            {
                System.Reflection.Assembly asm = Assembly.Load("Agrine.UI.Sounds");

                using (Stream stream = asm.GetManifestResourceStream(this.soundLocation))
                {
                    if (stream == null)
                    {
                        MessageBox.Show("مشکلی در پخش صدای نمایش پنجره پیام به وجود آمده است ! " + this.soundLocation);
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
