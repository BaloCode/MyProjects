/*
Known Issues :
Numbers don't blink when they are more than one.
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Numch
{
    public partial class GameNum : Form
    {
        //Global Variables/Objects
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        private int score = 0;
        static int number;
        int prev = 0;
        int high;
        bool flag = false;
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize with clock
                return random.Next(min, max);// set random from clock
            }
        }
        public GameNum()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Sound.PlaySound("Back2");                   //Play sound back 2
            this.Hide();                                //Close the form
            score = 0;                                  //Set score to 0
            File.WriteAllText(@"C:\\Users\\eftap\\Downloads\\Numch[1.0]\\Numch[0.7]\\Numch\\bin\\Debug\\Usage Logs\\highNum.txt", String.Empty);    //Clear File Contents
            File.WriteAllText(@"C:\\Users\\eftap\\Downloads\\Numch[1.0]\\Numch[0.7]\\Numch\\bin\\Debug\\Usage Logs\\highNum.txt", high.ToString()); //Write To File
        }
        private void GameNum_Load(object sender, EventArgs e)
        {
            showNum.Start();                        //Start to blink numbers
            //lblDisp.Text = number.ToString();       //Set number var to what is shown
            lblScore.Text = "Score : 0";            //Set score label to 0
            high = int.Parse(File.ReadAllText(@"C:\\Users\\eftap\\Downloads\\Numch[1.0]\\Numch[0.7]\\Numch\\bin\\Debug\\Usage Logs\\highLet.txt"));     //Load highscore
            lblhi.Text = "Hi-Score : " + high;            //Set highscore to high
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            wait.Stop();                                //Stop black out
            int answer = int.Parse(txtAnswr.Text);      //Parse the answer from strng to int
            checkNum(answer, number);                   //Check the answer
            txtAnswr.Text = String.Empty;               //Set textbox text to null
            prev = 0;
            showNum.Start();                            //Blink numbers
        }
        private int sqNum()
        {
            //Variables
            lblDisp.Visible = true;
            int num = 0;
            int temp = RandomNumber(1, 9);
            num = prev * 10 + temp;   //Calculation to set the order of numbers
            prev = num;                             //Save the random number to the prev
            //showNum.Start();
            lblDisp.Text = temp.ToString();
            return num;
        }
        private void checkNum(int ans, int num)             //Function to check the answer and random number
        {
            wait.Stop();
            if (ans == num)                             //If the answer is equal to the displayed number
            {
                Sound.PlaySound("Win");                 //Play sound win
                score += 10;                            //Add 10 to score
                lblScore.Text = "Score : " + score;     //Display it
            }
            else
            {
                Sound.PlaySound("Lose");                //Play sound lose
                MessageBox.Show("Wrong Answer! Try Again");     //Prompt the user
                score = 0;                              //Set score to 0
                lblScore.Text = "Score : 0";            //Change the displayed score
            }
            //Check Score 
            if (score > high)
            {
                high = score;
                lblhi.Text = "Hi-Score : " + high;
            }
            showNum.Start();                               //Black out
            //showNum.Start();  Delete
        }
        private void wait_Tick(object sender, EventArgs e)  //Black out
        {
            prev = 0;                       //Set prev to 0
            showNum.Stop();                 //Stop showing numbers
            lblDisp.Visible = false;        //Make label invisible
        }

        private void showNum_Tick(object sender, EventArgs e)
        {
            number = sqNum();                   //Set number to random squence of numbers
            prev = number;                      //Save number to prev
            //lblDisp.Text = number.ToString();   //Display the number
            wait.Start();                       //Black out
        }

        private void txtAnswr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnCheck_Click(sender, e);
        }
    }
}