using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxian
{

    public partial class Main_Form : Form
    {
        int time = 0;


        List<PictureBox> bullets = new List<PictureBox>();

        public Main_Form()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            Click_BTN_Sound();
            timer1.Start();
            btnStart.Enabled = false;
            btnReStart.Enabled = true;
            重玩一次RToolStripMenuItem.Enabled = true;
        }
        public void newBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = pictureBoxBullet.Image;
            bullet.Size = pictureBoxBullet.Size;
            bullet.Left = (Airplane.Left + Airplane.Right - bullet.Size.Width) / 2;
            bullet.Top = Airplane.Top;
            this.Controls.Add(bullet);
            this.Controls.SetChildIndex(bullet, 0);
            bullet.Visible = true;
            bullets.Add(bullet);

        }
        bool isOverlap(Rectangle r1, Rectangle r2)
        {
            if (r1.Left > r2.Left && r1.Left < r2.Right)
                if (r1.Top > r2.Top && r1.Top < r2.Bottom)
                    return true;
            return false;
        }
        public void bulletMove()
        {
            int i;
            for (i = 0; i < bullets.Count; i++)
            {
                PictureBox bullet = bullets[i];
                bullet.Top -= 10;
                if (bullet.Top < pictureBox1.Top + 10)
                {
                    bullet.Visible = false;
                }
            }

            i = 0;
            
            while (i < bullets.Count)
            {
                if (bullets[i].Bottom < 0)
                {
                    bullets.RemoveAt(i);
                }
                else
                    i++;
            }
            for (i = 0; i < bullets.Count; i++)
            {
                if (isOverlap(bullets[i].Bounds, pictureBox4.Bounds))
                {
                    pictureBox4.Visible = false;
                    pictureBox4.Top = 100;
                    bullets[i].Visible = false;

                }
                if (isOverlap(bullets[i].Bounds, pictureBox5.Bounds))
                {
                    pictureBox5.Visible = false;
                    pictureBox5.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox17.Bounds))
                {
                    pictureBox17.Visible = false;
                    pictureBox17.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox16.Bounds))
                {
                    pictureBox16.Visible = false;
                    pictureBox16.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox6.Bounds))
                {
                    pictureBox6.Visible = false;
                    pictureBox6.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox7.Bounds))
                {
                    pictureBox7.Visible = false;
                    pictureBox7.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox8.Bounds))
                {
                    pictureBox8.Visible = false;
                    pictureBox8.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox9.Bounds))
                {
                    pictureBox9.Visible = false;
                    pictureBox9.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox30.Bounds))
                {
                    pictureBox30.Visible = false;
                    pictureBox30.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox10.Bounds))
                {
                    pictureBox10.Visible = false;
                    pictureBox10.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox11.Bounds))
                {
                    pictureBox11.Visible = false;
                    pictureBox11.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox12.Bounds))
                {
                    pictureBox12.Visible = false;
                    pictureBox12.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox28.Bounds))
                {
                    pictureBox28.Visible = false;
                    pictureBox28.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox32.Bounds))
                {
                    pictureBox32.Visible = false;
                    pictureBox32.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox13.Bounds))
                {
                    pictureBox13.Visible = false;
                    pictureBox13.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox14.Bounds))
                {
                    pictureBox14.Visible = false;
                    pictureBox14.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox15.Bounds))
                {
                    pictureBox15.Visible = false;
                    pictureBox15.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox29.Bounds))
                {
                    pictureBox29.Visible = false;
                    pictureBox29.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox33.Bounds))
                {
                    pictureBox33.Visible = false;
                    pictureBox33.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox18.Bounds))
                {
                    pictureBox18.Visible = false;
                    pictureBox18.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox19.Bounds))
                {
                    pictureBox19.Visible = false;
                    pictureBox19.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox20.Bounds))
                {
                    pictureBox20.Visible = false;
                    pictureBox20.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox31.Bounds))
                {
                    pictureBox31.Visible = false;
                    pictureBox31.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox21.Bounds))
                {
                    pictureBox21.Visible = false;
                    pictureBox21.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox22.Bounds))
                {
                    pictureBox22.Visible = false;
                    pictureBox22.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox23.Bounds))
                {
                    pictureBox23.Visible = false;
                    pictureBox23.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox24.Bounds))
                {
                    pictureBox24.Visible = false;
                    pictureBox24.Top = 100;
                }
                if (isOverlap(bullets[i].Bounds, pictureBox25.Bounds))
                {
                    pictureBox25.Visible = false;
                    pictureBox25.Top = 100;
                }
            }

        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "InfectiousNCS.mp3");
            File.WriteAllBytes(tempFile, Properties.Resources.InfectiousNCS);
            musicPlay.URL = tempFile;
            musicPlay.settings.setMode("loop", true); // 重複播放
            musicPlay.Ctlcontrols.play();
            musicPlay.settings.volume = 50;
            重玩一次RToolStripMenuItem.Enabled = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox17.Visible = true;
            pictureBox16.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox30.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox28.Visible = true;
            pictureBox32.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox29.Visible = true;
            pictureBox33.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox31.Visible = true;
            pictureBox21.Visible = true;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            pictureBox25.Visible = true;
            btnReStart.Enabled = false;
        }

        private void Main_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnReStart.Enabled == true)
            { 
            if (e.KeyCode.Equals(Keys.L))
            {
                newBullet();
                
            }
            if (e.KeyCode == Keys.A)
            {
                Airplane.Left -= 10;
                if (Airplane.Left < 25)
                {
                    Airplane.Left = pictureBox1.Size.Width - 50 ;
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if (Airplane.Left > 362)
                {
                    Airplane.Left = pictureBox1.Size.Width - 395;
                }
                Airplane.Left += 10;
            }
            }

        }

        public void restart()
        {
            
            pictureBox4.Visible = true;
            pictureBox4.Top = 87;
            pictureBox5.Visible = true;
            pictureBox5.Top = 120;
            pictureBox17.Visible = true;
            pictureBox17.Top = 87;
            pictureBox16.Visible = true;
            pictureBox16.Top = 120;
            pictureBox6.Visible = true;
            pictureBox6.Top = 152;
            pictureBox7.Visible = true;
            pictureBox7.Top = 87;
            pictureBox8.Visible = true;
            pictureBox8.Top = 120;
            pictureBox9.Visible = true;
            pictureBox9.Top = 152;
            pictureBox30.Visible = true;
            pictureBox30.Top = 190;
            pictureBox10.Visible = true;
            pictureBox10.Top = 87;
            pictureBox11.Visible = true;
            pictureBox11.Top = 120;
            pictureBox12.Visible = true;
            pictureBox12.Top = 152;
            pictureBox28.Visible = true;
            pictureBox28.Top = 190;
            pictureBox32.Visible = true;
            pictureBox32.Top = 225;
            pictureBox13.Visible = true;
            pictureBox13.Top = 87;
            pictureBox14.Visible = true;
            pictureBox14.Top = 120;
            pictureBox15.Visible = true;
            pictureBox15.Top = 152;
            pictureBox29.Visible = true;
            pictureBox29.Top = 190;
            pictureBox33.Visible = true;
            pictureBox33.Top = 225;
            pictureBox18.Visible = true;
            pictureBox18.Top = 87;
            pictureBox19.Visible = true;
            pictureBox19.Top = 120;
            pictureBox20.Visible = true;
            pictureBox20.Top = 152;
            pictureBox31.Visible = true;
            pictureBox31.Top = 190;
            pictureBox21.Visible = true;
            pictureBox21.Top = 87;
            pictureBox22.Visible = true;
            pictureBox22.Top = 120;
            pictureBox23.Visible = true;
            pictureBox23.Top = 152;
            pictureBox24.Visible = true;
            pictureBox24.Top = 120;
            pictureBox25.Visible = true;
            pictureBox25.Top = 87;
            btnReStart.Enabled = true;

            time = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            textBox1.Text = (time/100.0).ToString();
            bulletMove();
            //enemyMove();
            if (pictureBox4.Top == 100 && pictureBox5.Top == 100 && pictureBox17.Top == 100 && pictureBox16.Top == 100 && pictureBox6.Top == 100 && pictureBox7.Top == 100 && pictureBox8.Top == 100 && pictureBox9.Top == 100 && pictureBox30.Top == 100 && pictureBox10.Top == 100 && pictureBox11.Top == 100 && pictureBox12.Top == 100 && pictureBox28.Top == 100 && pictureBox32.Top == 100 && pictureBox13.Top == 100 && pictureBox14.Top == 100 && pictureBox15.Top == 100 && pictureBox29.Top == 100 && pictureBox33.Top == 100 && pictureBox18.Top == 100 && pictureBox19.Top == 100 && pictureBox20.Top == 100 && pictureBox31.Top == 100 && pictureBox21.Top == 100 && pictureBox22.Top == 100 && pictureBox23.Top == 100 && pictureBox24.Top == 100 && pictureBox25.Top == 100)
            {
                timer1.Stop();
                int i;
                for (i = 0; i < bullets.Count; i++)
                {
                    PictureBox bullet = bullets[i];
                    bullet.Visible = false;
                    bullet.Top = Airplane.Top;
                    bullet.Enabled = false;
                }
                MessageBox.Show("恭喜過關~你總共花了" + time / 100.0 + "秒!");
                btnReStart.Enabled = true;
                
            }
            
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            Click_BTN_Sound();
            restart();
        }

        public void 音量SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music Volum = new music();
            Volum.ShowDialog(this);      
            
        }

        public void Click_BTN_Sound()
        {
            string tempFile = Path.Combine(Path.GetTempPath(), $"crush_effect_{Guid.NewGuid()}.mp3"); //避免按鍵音效衝突
            File.WriteAllBytes(tempFile, Properties.Resources.crush_effect);
            SoundPlay.URL = tempFile;
            SoundPlay.settings.setMode("loop", false); // 重複播放
            SoundPlay.Ctlcontrols.play();
            SoundPlay.settings.volume = 50;
        }
    }

}
