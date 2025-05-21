namespace TestGame
{
    public partial class Form1 : Form
    {



        int pipeSpeed = 8; // default pipe speed defined with an integer
        int gravity = 15; // default gravity speed defined with an integer
        int score = 0;  // default score integer set to 0

        bool gameOver = false;
        bool ispaused = false;
        Random rnd = new Random();



        public Form1()
        {
            InitializeComponent();

            Ground.Controls.Add(Score);
            Score.Left = 20;
            Score.Top = 25;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {


            FlappyBird.Top += gravity; // link the flappy bird picture box to the gravity, += means it will add the speed of gravity to the picture boxes top location so it will move down
            PipeBottom.Left -= pipeSpeed; // link the bottom pipes left position to the pipe speed integer, it will reduce the pipe speed value from the left position of the pipe picture box so it will move left with each tick
            PipeTop.Left -= pipeSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign
            Score.Text = "Score: " + score; // show the current score on the score text label

            // below we are checking if any of the pipes have left the screen
            if (PipeBottom.Left < -150)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                PipeBottom.Left = rnd.Next(750, 1300);
                score++;
            }
            if (PipeTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                PipeTop.Left = rnd.Next(850, 1500);
                score++;
            }
            // the if statement below is checking if the pipe hit the ground, pipes or if the player has left the screen from the top
            // the two pipe symbols stand for OR inside of an if statement so we can have multiple conditions inside of this if statement because its all going to do the same thing

            if (FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }
            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void gameKeysisDown(object sender, KeyEventArgs e)
        {

            // this is the game key is down event thats linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -15;
            }
            if (e.KeyCode == Keys.P)
            {
                Gametimer.Stop();
                ispaused = true;
                StartButton.Visible = true;
               
            }
            if (e.KeyCode == Keys.Escape) 
            {
                Close();
            }
        }

        private void gameKeyisUp(object sender, KeyEventArgs e)
        {

            // this is the game key is up event thats linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released then gravity is set back to 15
                gravity = 15;
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                //run the Restart function
                RestartGame();
            }
        }

        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            Gametimer.Stop(); // stop the main timer
            Score.Text += "    Game over!!! Press R to Retry"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it

            gameOver = true;
            RestartButton.Enabled = true;
            RestartButton.Visible = true;
        }

        private void RestartGame()
        {
            gameOver = false;

            FlappyBird.Location = new Point(107, 244);
            PipeTop.Left = 800;
            PipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            Score.Text = "Score: 0";
            RestartButton.Enabled = false;
            RestartButton.Visible = false;

            Gametimer.Start();

        }

        private void ReStartClickEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void StartGame(object sender, EventArgs e)
        {
        if (ispaused == true) 
            {
                Gametimer.Start();   
                ispaused = false;
                StartButton.Visible = false;
            }
            
        }
    }
}
