namespace GuessingGame
{
    partial class TheGame
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
            this.Result = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.GuessValue = new System.Windows.Forms.TextBox();
            this.AcceptGuess = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.retryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(56, 229);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 28);
            this.Result.TabIndex = 5;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("JMH Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(170, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(203, 41);
            this.Title.TabIndex = 0;
            this.Title.Text = "Guess Game";
            // 
            // GuessValue
            // 
            this.GuessValue.BackColor = System.Drawing.SystemColors.Window;
            this.GuessValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GuessValue.CausesValidation = false;
            this.GuessValue.Font = new System.Drawing.Font("JMH Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuessValue.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.GuessValue.Location = new System.Drawing.Point(56, 153);
            this.GuessValue.MaxLength = 2;
            this.GuessValue.Name = "GuessValue";
            this.GuessValue.PlaceholderText = "Enter your Guess here!";
            this.GuessValue.Size = new System.Drawing.Size(266, 25);
            this.GuessValue.TabIndex = 1;
            // 
            // AcceptGuess
            // 
            this.AcceptGuess.BackColor = System.Drawing.Color.White;
            this.AcceptGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptGuess.Font = new System.Drawing.Font("JMH Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AcceptGuess.Location = new System.Drawing.Point(351, 149);
            this.AcceptGuess.Name = "AcceptGuess";
            this.AcceptGuess.Size = new System.Drawing.Size(150, 34);
            this.AcceptGuess.TabIndex = 2;
            this.AcceptGuess.Text = "Enter Guess";
            this.AcceptGuess.UseVisualStyleBackColor = false;
            this.AcceptGuess.Click += new System.EventHandler(this.AcceptGuess_Click);
            this.AcceptGuess.Paint += new System.Windows.Forms.PaintEventHandler(this.AcceptGuess_Paint);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(528, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 32);
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            this.Exit.Paint += new System.Windows.Forms.PaintEventHandler(this.Exit_Paint);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // retryBtn
            // 
            this.retryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retryBtn.Font = new System.Drawing.Font("JMH Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.retryBtn.Location = new System.Drawing.Point(351, 229);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(150, 34);
            this.retryBtn.TabIndex = 6;
            this.retryBtn.Text = "Retry";
            this.retryBtn.UseVisualStyleBackColor = true;
            this.retryBtn.Visible = false;
            this.retryBtn.Click += new System.EventHandler(this.retryBtn_Click_1);
            this.retryBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.AcceptGuess_Paint);
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(571, 320);
            this.Controls.Add(this.retryBtn);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AcceptGuess);
            this.Controls.Add(this.GuessValue);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("JMH Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 533);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "TheGame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Game";
            this.Load += new System.EventHandler(this.TheGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private TextBox GuessValue;
        private Button AcceptGuess;
        private Button Exit;
        private Label Result;
        private Button retryBtn;
    }
}