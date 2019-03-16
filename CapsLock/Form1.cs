using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapsLock
{
    public partial class Form1 : Form
    {
        Image[] Num = { Properties.Resources.Num_Lock_Off, Properties.Resources.Num_Lock_On };
        Image[] Caps ={ Properties.Resources.Caps_Lock_Off, Properties.Resources.Caps_Lock_On };
        Image[] Sch = { Properties.Resources.Scroll_Lock_Off, Properties.Resources.Scroll_Lock_On };
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            pictureBox1.BackgroundImage = Caps[0];
            pictureBox2.BackgroundImage = Num[0];
            pictureBox3.BackgroundImage = Sch[0];
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            this.TopMost=true;
            this.ShowInTaskbar = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (pictureBox1.BackgroundImage == Caps[0])
                    pictureBox1.BackgroundImage = Caps[1];
            }
            else
            {
                if (pictureBox1.BackgroundImage == Caps[1])
                    pictureBox1.BackgroundImage = Caps[0];
            }
            if (Control.IsKeyLocked(Keys.NumLock))
            {
                if (pictureBox2.BackgroundImage == Num[0])
                    pictureBox2.BackgroundImage = Num[1];
            }
            else
            {
                if (pictureBox2.BackgroundImage == Num[1])
                    pictureBox2.BackgroundImage = Num[0];
            }
            if (Control.IsKeyLocked(Keys.Scroll))
            {
                if (pictureBox3.BackgroundImage == Sch[0])
                    pictureBox3.BackgroundImage = Sch[1];
            }
            else
            {
                label3.Text = "Scroll false";
                if (pictureBox3.BackgroundImage == Sch[1])
                    pictureBox3.BackgroundImage = Sch[0];
            }
        }
    }
}
