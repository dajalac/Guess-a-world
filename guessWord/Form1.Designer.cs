namespace guessWord
{
    partial class Form1
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
            this.picBoxHangMan = new System.Windows.Forms.PictureBox();
            this.lblGuessedWord = new System.Windows.Forms.Label();
            this.txtLetterInput = new System.Windows.Forms.TextBox();
            this.txtSentenceInput = new System.Windows.Forms.TextBox();
            this.btnSubmiteLetter = new System.Windows.Forms.Button();
            this.btnSubmiteWord = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtMissedWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHangMan)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHangMan
            // 
            this.picBoxHangMan.Location = new System.Drawing.Point(474, 12);
            this.picBoxHangMan.Name = "picBoxHangMan";
            this.picBoxHangMan.Size = new System.Drawing.Size(212, 355);
            this.picBoxHangMan.TabIndex = 0;
            this.picBoxHangMan.TabStop = false;
            // 
            // lblGuessedWord
            // 
            this.lblGuessedWord.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessedWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuessedWord.Location = new System.Drawing.Point(23, 63);
            this.lblGuessedWord.Name = "lblGuessedWord";
            this.lblGuessedWord.Size = new System.Drawing.Size(420, 101);
            this.lblGuessedWord.TabIndex = 1;
            this.lblGuessedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetterInput
            // 
            this.txtLetterInput.Enabled = false;
            this.txtLetterInput.Location = new System.Drawing.Point(111, 295);
            this.txtLetterInput.Multiline = true;
            this.txtLetterInput.Name = "txtLetterInput";
            this.txtLetterInput.Size = new System.Drawing.Size(64, 32);
            this.txtLetterInput.TabIndex = 2;
            this.txtLetterInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSentenceInput
            // 
            this.txtSentenceInput.Enabled = false;
            this.txtSentenceInput.Location = new System.Drawing.Point(320, 295);
            this.txtSentenceInput.Multiline = true;
            this.txtSentenceInput.Name = "txtSentenceInput";
            this.txtSentenceInput.Size = new System.Drawing.Size(146, 32);
            this.txtSentenceInput.TabIndex = 3;
            // 
            // btnSubmiteLetter
            // 
            this.btnSubmiteLetter.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmiteLetter.Enabled = false;
            this.btnSubmiteLetter.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmiteLetter.Location = new System.Drawing.Point(9, 295);
            this.btnSubmiteLetter.Name = "btnSubmiteLetter";
            this.btnSubmiteLetter.Size = new System.Drawing.Size(107, 32);
            this.btnSubmiteLetter.TabIndex = 4;
            this.btnSubmiteLetter.Text = "Submit Letter";
            this.btnSubmiteLetter.UseVisualStyleBackColor = false;
            this.btnSubmiteLetter.Click += new System.EventHandler(this.btnSubmiteLetter_Click);
            // 
            // btnSubmiteWord
            // 
            this.btnSubmiteWord.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmiteWord.Enabled = false;
            this.btnSubmiteWord.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmiteWord.Location = new System.Drawing.Point(201, 295);
            this.btnSubmiteWord.Name = "btnSubmiteWord";
            this.btnSubmiteWord.Size = new System.Drawing.Size(122, 32);
            this.btnSubmiteWord.TabIndex = 5;
            this.btnSubmiteWord.Text = "Submit Word";
            this.btnSubmiteWord.UseVisualStyleBackColor = false;
            this.btnSubmiteWord.Click += new System.EventHandler(this.btnSubmiteWord_Click);
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLength.Location = new System.Drawing.Point(339, 210);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(113, 49);
            this.lblLength.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(474, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(339, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.LightGray;
            this.btnShow.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(176, 394);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(95, 32);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show Word";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightGray;
            this.btnPlay.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(21, 394);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 32);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtMissedWord
            // 
            this.txtMissedWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMissedWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMissedWord.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissedWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMissedWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMissedWord.Location = new System.Drawing.Point(21, 203);
            this.txtMissedWord.Multiline = true;
            this.txtMissedWord.Name = "txtMissedWord";
            this.txtMissedWord.Size = new System.Drawing.Size(276, 56);
            this.txtMissedWord.TabIndex = 12;
            this.txtMissedWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Missed: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(114, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Can you guess the word?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMissedWord);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnSubmiteWord);
            this.Controls.Add(this.btnSubmiteLetter);
            this.Controls.Add(this.txtSentenceInput);
            this.Controls.Add(this.txtLetterInput);
            this.Controls.Add(this.lblGuessedWord);
            this.Controls.Add(this.picBoxHangMan);
            this.Name = "Form1";
            this.Text = "guessWord";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHangMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHangMan;
        private System.Windows.Forms.Label lblGuessedWord;
        private System.Windows.Forms.TextBox txtLetterInput;
        private System.Windows.Forms.TextBox txtSentenceInput;
        private System.Windows.Forms.Button btnSubmiteLetter;
        private System.Windows.Forms.Button btnSubmiteWord;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtMissedWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

