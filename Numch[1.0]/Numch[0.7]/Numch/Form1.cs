/*
Name:                       ID
Dimitris Balokas           08495


TODO:  
-Main Menu-     √   (Completed)
-Numbers-       √   (Completed)
-Letters-       √   (Completed)
-High Score-    √   (Completed)
-Help/Info-     √   (Completed)
-Audio-         √   (Completed)
-Graphics-      √   (Completed)
*/
using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace Numch
{
    public partial class MainMenu : Form
    {
        //<Fomrs>
        GameNum gameFrm = new GameNum();
        GameMode gameMD = new GameMode();
        Help _Help = new Help();
        //</Forms>
        //<Manage mute unmute>
        bool unmuteS = false;
        bool unmuteM = false;
        //</Manage mute unmute>
        //<To Loop Music>
        static WaveFileReader wfrMusic = new WaveFileReader("Sounds\\Main1.wav");
        static WaveChannel32 wcMusic = new WaveChannel32(wfrMusic);
        static WaveOut waveOut = new WaveOut();
        static Sound loop = new Sound(wfrMusic);    //Create the loopSource
        //</To Loop Music>
        public MainMenu()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Sound.PlaySound("Exit");                //Play sound
            //Message Box
            DialogResult result = MessageBox.Show("Do you want to exit?", "You are about to exit!!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)         //Check the answer
            {
                this.Close();                       //Exit
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            waveOut.Init(loop);                     //Initialise the loop
            waveOut.Volume = 1.0f;
            wcMusic.Volume = 0.0f;                 //Set volume
            waveOut.Play();                         //Play it
            //CallInLoad();
            //Particle.CreateMany(20, 0, this.ClientSize.Width, 5, 0);//Calling Create Particles
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Load Game Scene
            gameMD.Show();
            //Play sound
            Sound.PlaySound("Play");
        }
        private void btnMuteS_Click(object sender, EventArgs e)
        {
            if (Sound.mute)                         //If the mute var is true
            {                                       //Restore volume
                unmuteS = true;                      //Set the unmute to true
                Sound.mute = false;                 //set it to false
                btnMuteS.Text = "Mute Sounds";      //Chenge button text
            }
            else                                    //Otherwise
            {                                       //Set Volume to 0
                unmuteS = false;                     //Set unmute to false
                Sound.mute = true;                  //Set mute to true
                btnMuteS.Text = "Unmute Sounds";    //Change button text
            }
                
        }
        private void btnMuteM_Click(object sender, EventArgs e)
        {
            if (!unmuteM)                           //If the sound is muted
            {                                       //Pause music
                unmuteM = true;                     //Unmute music to true
                btnMuteM.Text = "Unmute Music";     //Change button text
                waveOut.Pause();                    //Pause
            }
            else                                    //Otherwise
            {
                unmuteM = false;                    //Unmute music to false
                btnMuteM.Text = "Mute Music";       //Change the button text
                waveOut.Play();                     //Play
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Sound.PlaySound("Click");   //Play sound
            _Help.Show();               //Load game scene
        }
    }
}
