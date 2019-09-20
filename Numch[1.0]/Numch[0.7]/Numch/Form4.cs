using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numch
{
    public partial class GameMode : Form
    {
        GameNum gameNumber = new GameNum();
        GameLetters gamelt = new GameLetters();

        public GameMode()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to main menu
            Sound.PlaySound("Back1");
            this.Hide();

        }

        private void gmNum1_Click(object sender, EventArgs e)
        {
            //Load Game Scene
            gameNumber.Show();
            //this.sqNum();
            Sound.PlaySound("Play2");
        }

        private void gmLetters_Click(object sender, EventArgs e)
        {
            //load game scene with letters
            gamelt.Show();
            // This is the sound of button
            Sound.PlaySound("Play2");
        }
    }
}
