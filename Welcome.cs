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
    public partial class roulette : Form
    {
        public static string name;
        public roulette()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        { //Below code is for hiding form 1 and open form 2
            name = textname.Text;
            (new russian()).Show();
            this.Hide();
        }

        private void roulette_Load(object sender, EventArgs e)
        {
            // Below code is uploading the image
            Image img = Image.FromFile(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\aa.png");
            BackgroundImage = img;
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrules_Click(object sender, EventArgs e)
        {// Below code is for hiding form 1 and open form 3
            (new rules ()).Show();
            this.Hide();
        }

        private void to_Click(object sender, EventArgs e)
        {

        }

        private void game_Click(object sender, EventArgs e)
        {

        }

        private void entername_click(object sender, EventArgs e)
        {

        }
    }
}
