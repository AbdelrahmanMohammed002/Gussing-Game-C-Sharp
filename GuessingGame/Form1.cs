namespace GuessingGame
{
    public partial class TheGame : Form
    {
        public TheGame()
        {
            InitializeComponent();

            //the main form's colors
            this.BackColor = Color.FromArgb(220, 53, 53);
            this.ForeColor = Color.FromArgb(255, 225, 93);
        }

        public int winVal = new int();

        //generate the random number when the form is loading.
        private void TheGame_Load(object sender, EventArgs e)
        {
            Random R = new Random();
            winVal = R.Next(1, 100);

        }

        private void AcceptGuess_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(GuessValue.Text) > winVal)
                {
                    Result.ForeColor = Color.FromArgb(255, 247, 233);
                    Result.Text = "you are too high";

                }
                else if (Convert.ToInt16(GuessValue.Text) < winVal)
                {
                    Result.ForeColor = Color.FromArgb(255, 247, 233);
                    Result.Text = "you are too low";

                }
                else if (Convert.ToInt16(GuessValue.Text) == winVal)
                {
                    Result.ForeColor = Color.FromArgb(255, 247, 233);
                    Result.Text = "YOU GUESSED IT RIGHT";
                    retryBtn.Visible = true;
                }
            }
            catch
            {
                
                Result.Text = "Must enter a number!";
            }
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Paint(object sender, PaintEventArgs e)
        {
            Exit.FlatAppearance.BorderSize = 0;
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.BackColor = Color.FromArgb(255, 225, 93);
        }

        private void AcceptGuess_Paint(object sender, PaintEventArgs e)
        {
            AcceptGuess.BackColor = Color.FromArgb(244, 157, 26);
            AcceptGuess.ForeColor = Color.FromArgb(255, 225, 93);
            AcceptGuess.FlatAppearance.BorderSize = 0;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.FromArgb(0,255, 225, 93);
        }


        private void retryBtn_Click_1(object sender, EventArgs e)
        {
            //recreate the random number
            Random R = new Random();
            winVal = R.Next(1, 100);

            //clear the result text
            Result.Text = "";
            GuessValue.Text = "";

            //hide the retry btn
            retryBtn.Visible = false;
        }
    }


}