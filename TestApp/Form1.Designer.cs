namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX1.Location = new System.Drawing.Point(248, 139);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(75, 23);
            this.checkBoxX1.TabIndex = 0;
            this.checkBoxX1.Text = "checkBoxX1";
            this.checkBoxX1.CheckedChanged += new System.EventHandler(this.checkBoxX1_CheckedChanged);
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX2.Location = new System.Drawing.Point(389, 139);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(75, 23);
            this.checkBoxX2.TabIndex = 0;
            this.checkBoxX2.Text = "checkBoxX1";
            this.checkBoxX2.CheckedChanged += new System.EventHandler(this.checkBoxX2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 364);
            this.Controls.Add(this.checkBoxX2);
            this.Controls.Add(this.checkBoxX1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Palette = Agrine.UI.Controls.Core.Enums.Appearance.Palettes.Black;
            this.SoundTypes = Agrine.UI.Sounds.Core.Enums.StartupSoundTypes.SSoundSix;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
    }
}

