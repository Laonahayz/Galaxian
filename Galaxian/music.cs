using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxian
{
    public partial class music : Form
    {
        public music()
        {
            InitializeComponent();
        }

        private void music_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == 10)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 100;
            }
            if (trackBar1.Value == 9)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 90;
            }
            if (trackBar1.Value == 8)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 80;
            }
            if (trackBar1.Value == 7)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 70;
            }
            if (trackBar1.Value == 6)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 60;
            }
            if (trackBar1.Value == 5)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 50;
            }
            if (trackBar1.Value == 4)
            {
                
                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 40;
            }
            if (trackBar1.Value == 3)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 30;
            }
            if (trackBar1.Value == 2)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 20;
            }
            if (trackBar1.Value == 1)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 10;
            }
            if (trackBar1.Value == 0)
            {

                Main_Form Owner = (Main_Form)this.Owner;
                Owner.musicPlay.settings.volume = 0;
            }
        }
    }
}
