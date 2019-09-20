/*
Known Issues :
Sometimes, when answering correctly, user gets prompt with wrong answer.
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Numch
{
    public partial class GameLetters : Form
    {
        //Global Variables/Objects
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        private int score = 0;  // Initialize the score to 0 value
        string letter;          // Declare string named letter
        string ans = "";        // String ans initiallize with an empty space we do this in order to add 3 charachters in the string
        string show;            // Declare show string
        string randomstring;    // Declare randomstring
        int high;
        char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); //Initiallize a char array with all the english alphabet letters
        public static int rnd_s(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
        public GameLetters()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Sound.PlaySound("Back2");       //Play sound Back2
            this.Hide();                    //Hide the from
        }

        private void GameLetters_Load(object sender, EventArgs e)
        {
            showLett.Start();               //Start timer showLett
            letter = sqLett();              // Adding to the string letter the function sqLett which is the sequence of the characters
            lblDisp.Text = letter;          // Display the letters
            lblScore.Text = "Score : 0";    // Display the score as zero to begin
            high = int.Parse(File.ReadAllText(@"C:\\Users\\eftap\\Downloads\\Numch[1.0]\\Numch[0.7]\\Numch\\bin\\Debug\\Usage Logs\\highLet.txt"));     //Load highscore
            lblhi.Text = "Hi-Score : " + high;            //Set highscore to high
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string answer = txtAnswr.Text;  // With this line of code we take the answer from the textbox
            checklett(answer, ans);         // Check answer function call
            ans = "";                       // In this step we clear the string in order to check the three new letters
            txtAnswr.Text = String.Empty;   // Empty answer text box
            showLett.Start();               // We start the timer in order to blink tha characters in the screen
            File.WriteAllText(@"C:\\Users\\eftap\\Downloads\\Numch[1.0]\\Numch[0.7]\\Numch\\bin\\Debug\\Usage Logs\\highNum.txt", String.Empty);    //Clear File Contents
            File.WriteAllText(@"C:\\Users\\eftap\\Downloads\\Numch[1.0]\\Numch[0.7]\\Numch\\bin\\Debug\\Usage Logs\\highNum.txt", high.ToString()); //Write To File

        }
        private string sqLett()
        {
            lblDisp.Visible = true;                             //Set label to visible
            randomstring = letters[rnd_s(0, 51)].ToString();    // Adding to the randomstring from the letter array random letters from min=0 , max = 51
            ans += randomstring;                                // Adding the randostring to a variable ans in order to check with the answer from the textbox
            // time.Start();     
            return randomstring;
        }
        private void checklett(string answer, string letter)
        {
            wait.Stop();            // Stop the wait timer in order to wait from the user the answer
            if (answer != letter)   // Check the answer with the random letters from this line untill line 91 
            {
                Sound.PlaySound("Lose");                //Play the sound
                MessageBox.Show("Wrong Answer");        //Prompt the user
                score = 0;                              //Set score to 0
                lblScore.Text = "score : " + score;     //Display the new score

            }
            else
            {
                Sound.PlaySound("Win");                 //Play sound
                score += 10;                            //Increase score
                lblScore.Text = "Score : " + score;     //Display the new score
            }
            //Check Score 
            if (score > high)
            {
                high = score;
                lblhi.Text = "Hi-Score : " + high;
            }
            showLett.Start();       // Once checked, show letters again
        }

        private void time_Tick(object sender, EventArgs e)      //showLett_Tick
        {
            show = sqLett();        //Save the squence on show
            lblDisp.Text = show;    //Show it on the lable
            letter += show;         //Increase the overall variable
            wait.Start();           //Start wait timer

        }

        private void wait_Tick(object sender, EventArgs e)
        {
            showLett.Stop();            //Stop showing letters
            lblDisp.Visible = false;    //Blakc out
        }

        private void txtAnswr_KeyDown(object sender, KeyEventArgs e)
        {   //When pressing enter run btnCheck_Click
            if (e.KeyCode == Keys.Return)
                btnCheck_Click(sender, e);
        }
    }
}
