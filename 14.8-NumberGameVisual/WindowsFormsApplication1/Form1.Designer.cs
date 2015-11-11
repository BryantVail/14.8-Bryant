namespace GuessNumberGame
{
    partial class frmGuessNumber
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblHeadingGuessNumber = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuessStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(419, 58);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "&Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblHeadingGuessNumber
            // 
            this.lblHeadingGuessNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblHeadingGuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingGuessNumber.Location = new System.Drawing.Point(43, 32);
            this.lblHeadingGuessNumber.Name = "lblHeadingGuessNumber";
            this.lblHeadingGuessNumber.Size = new System.Drawing.Size(319, 49);
            this.lblHeadingGuessNumber.TabIndex = 1;
            this.lblHeadingGuessNumber.Text = "I have a number between 1 && 1000 \\n Can you guess my number? Enter your first gu" +
    "ess!";
            this.lblHeadingGuessNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(406, 32);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // lblGuessStatus
            // 
            this.lblGuessStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(243)))));
            this.lblGuessStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessStatus.Location = new System.Drawing.Point(529, 32);
            this.lblGuessStatus.Name = "lblGuessStatus";
            this.lblGuessStatus.Size = new System.Drawing.Size(178, 49);
            this.lblGuessStatus.TabIndex = 3;
            this.lblGuessStatus.Text = "Try to Guess!`";
            this.lblGuessStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGuessNumber
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(172)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(757, 490);
            this.Controls.Add(this.lblGuessStatus);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblHeadingGuessNumber);
            this.Controls.Add(this.btnGuess);
            this.Name = "frmGuessNumber";
            this.Text = "Guess That Number!";
            this.Load += new System.EventHandler(this.frmGuessNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblHeadingGuessNumber;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuessStatus;
    }
}

