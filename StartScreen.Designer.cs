namespace TestGame
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Start = new Label();
            StartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bird;
            pictureBox1.Location = new Point(240, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Start
            // 
            Start.AutoSize = true;
            Start.BackColor = Color.Transparent;
            Start.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start.Location = new Point(183, 42);
            Start.Name = "Start";
            Start.Size = new Size(215, 32);
            Start.TabIndex = 1;
            Start.Text = "Flappy Bird Game";
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StartButton.Location = new Point(183, 259);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(215, 99);
            StartButton.TabIndex = 2;
            StartButton.Text = "Play !!!";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += GameLoad;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(585, 443);
            Controls.Add(StartButton);
            Controls.Add(Start);
            Controls.Add(pictureBox1);
            Name = "StartScreen";
            Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Start;
        private Button StartButton;
    }
}