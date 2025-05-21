namespace TestGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            FlappyBird = new PictureBox();
            Ground = new PictureBox();
            PipeBottom = new PictureBox();
            PipeTop = new PictureBox();
            Score = new Label();
            Gametimer = new System.Windows.Forms.Timer(components);
            RestartButton = new PictureBox();
            StartButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestartButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartButton).BeginInit();
            SuspendLayout();
            // 
            // FlappyBird
            // 
            FlappyBird.Image = Properties.Resources.bird;
            FlappyBird.Location = new Point(113, 402);
            FlappyBird.Name = "FlappyBird";
            FlappyBird.Size = new Size(67, 51);
            FlappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            FlappyBird.TabIndex = 0;
            FlappyBird.TabStop = false;
            // 
            // Ground
            // 
            Ground.BackColor = Color.Transparent;
            Ground.BackgroundImage = Properties.Resources.ground;
            Ground.Location = new Point(0, 982);
            Ground.Name = "Ground";
            Ground.Size = new Size(1970, 243);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 1;
            Ground.TabStop = false;
            // 
            // PipeBottom
            // 
            PipeBottom.Image = Properties.Resources.pipe;
            PipeBottom.Location = new Point(748, 646);
            PipeBottom.Name = "PipeBottom";
            PipeBottom.Size = new Size(69, 339);
            PipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeBottom.TabIndex = 2;
            PipeBottom.TabStop = false;
            // 
            // PipeTop
            // 
            PipeTop.Image = Properties.Resources.pipedown;
            PipeTop.Location = new Point(680, -5);
            PipeTop.Name = "PipeTop";
            PipeTop.Size = new Size(69, 413);
            PipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeTop.TabIndex = 3;
            PipeTop.TabStop = false;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Score.Location = new Point(12, 1018);
            Score.Name = "Score";
            Score.Size = new Size(112, 32);
            Score.TabIndex = 4;
            Score.Text = " Score: 0";
            // 
            // Gametimer
            // 
            Gametimer.Enabled = true;
            Gametimer.Interval = 20;
            Gametimer.Tick += GameTimerEvent;
            // 
            // RestartButton
            // 
            RestartButton.Image = Properties.Resources.restart;
            RestartButton.Location = new Point(900, 450);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(101, 93);
            RestartButton.SizeMode = PictureBoxSizeMode.StretchImage;
            RestartButton.TabIndex = 5;
            RestartButton.TabStop = false;
            RestartButton.Click += ReStartClickEvent;
            // 
            // StartButton
            // 
            StartButton.Image = Properties.Resources.Start;
            StartButton.Location = new Point(900, 450);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(101, 93);
            StartButton.SizeMode = PictureBoxSizeMode.StretchImage;
            StartButton.TabIndex = 6;
            StartButton.TabStop = false;
            StartButton.Visible = false;
            StartButton.Click += StartGame;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1914, 1061);
            Controls.Add(StartButton);
            Controls.Add(RestartButton);
            Controls.Add(Score);
            Controls.Add(PipeTop);
            Controls.Add(FlappyBird);
            Controls.Add(Ground);
            Controls.Add(PipeBottom);
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += gameKeysisDown;
            KeyUp += gameKeyisUp;
            ((System.ComponentModel.ISupportInitialize)FlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestartButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FlappyBird;
        private PictureBox Ground;
        private PictureBox PipeBottom;
        private PictureBox PipeTop;
        private Label Score;
        private System.Windows.Forms.Timer Gametimer;
        private PictureBox RestartButton;
        private PictureBox StartButton;
    }
}
