using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rouelette
{
    public partial class russian : Form
    { // these are the variables
        public int loadvalue, Count1 = 0,Spinvalue ;
        
        public russian()
        {
            InitializeComponent();
        }


        public int Spin_chamber(int Spin_value1)
        {
            if (Spin_value1 == 6)
            {
                Spin_value1 = 1;
            }
            else
            {
                Spin_value1 = Spin_value1 + 1;
            }

            return Spin_value1;
        }
        private void russian_Load(object sender, EventArgs e)
        {
            Name_lbl.Text = roulette.name;
            Image img = Image.FromFile(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\real me.jpg");
            BackgroundImage = img;
            //below code is for hiding the image(picbox) 
            Shoot_picbox.Visible = false;
            btnspin.Enabled = false;
            shot_btn.Enabled = false;
        }

       
        private void btnload_Click(object sender, EventArgs e)
        {   // below code helps to show the picbox
            Shoot_picbox.Visible = true;
            Image img = Image.FromFile(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\load.gif");
            Shoot_picbox.Image = img;

            // below code is helps to load only 1 bullet.
            Play load_value = new Play();
            load_value.Load_sound();

            loadvalue = 1;

            btnspin.Enabled = true;
            btnload.Enabled = false;
        }

        private void textloadvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void picbox_Click(object sender, EventArgs e)
        {

        }

        private void shootaway_btn_Click(object sender, EventArgs e)
        {
            // below code is for clearing all the data for opening new game.
            russian rus = new russian();
            rus.Show();
            this.Close();
            // below code helps to show the image
            Shoot_picbox.Visible = true;
            Image img = Image.FromFile(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\try.jpg");
            Shoot_picbox.Image = img;
            Play tryObj = new Play();
            tryObj.Tryagain();
        }

        private void shot_btn_Click(object sender, EventArgs e)
        {

            // below code helps to show the picbox

            Shoot_picbox.Visible = true;
            //below code is for uploading the image
            Image img = Image.FromFile(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\shots.gif");
            Shoot_picbox.Image = img;
            Play ShotObj = new Play();

            int score1 = ShotObj.Shotbullet(loadvalue, Spinvalue);

            if (score1 != 0 && Count1 < 2)
            {
                if (score1 == 10)
                {
                    MessageBox.Show("you won and your score is 10");
                    shot_btn.Enabled = false;
                }

                else if (score1 == 5)
                {
                    MessageBox.Show("you won and your score is 5");
                    shot_btn.Enabled = false;
                }
            }

            else
            {
                Count1++;
                Spinvalue = Spin_chamber(Spinvalue);
            }

            if (Count1 == 2 && score1 == 0)
            {
                MessageBox.Show("you loss and your score is 0");
                shot_btn.Enabled = false;
            }
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Below code is for exit the game.
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            // below code helps to show the image
            Shoot_picbox.Visible = true;
            Image img = Image.FromFile(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\spinnn.gif");
            Shoot_picbox.Image = img;
            //below code is call the spin function from play class to set the spin value
            Play SpinObj = new Play();
            SpinObj.Spin_sound();

            //below code for spining the chamber and it will pick bullet randomly
            Random rnd = new Random();
            //below code helps to pick random number between 1-7.
            Spinvalue = rnd.Next(1, 7);

            shot_btn.Enabled = true;
            btnspin.Enabled = false;
        }

       
    }
}
