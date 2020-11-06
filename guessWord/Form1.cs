using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        Word gameWord = new Word();

        private void btnSubmiteLetter_Click(object sender, EventArgs e)
        {
            try
            {
                // desable the play button
                btnPlay.Enabled = false;

                // convert the letter input to char
                char letter = Convert.ToChar(txtLetterInput.Text.Substring(0, 1));
                txtLetterInput.Clear(); // the text input 

                // check if the letter is a match
                gameWord.setDisplay(letter);
            }
            catch (NonLetterException a)
            {
                MessageBox.Show(a.Message);
            }
            // print the letter input in the guessed word * 
            lblGuessedWord.Text = gameWord.getGuessedWord();

            // print congrats if the user guessd right.
            if (gameWord.getSelectedWord().Equals (gameWord.getGuessedWord()))
            {
                txtMissedWord.BackColor = Color.Blue;
                txtMissedWord.Text = ("Congrats! you guessed right");
                
            }

            // if the letter does not match 
            // show missed letter
            if (!gameWord.getMissedLetter().Equals('*'))
            {
                txtMissedWord.AppendText(gameWord.getMissedLetter() + ",");
                
            }
 
            // show the hangman
            Graphics g = picBoxHangMan.CreateGraphics(); // to cread the graphic object
            Pen p = new Pen(Color.Brown, 10); // pen to draw the wood
            Pen pb = new Pen(Color.Blue, 3); // pen to draw the body
           
                if (gameWord.getTrys() == 1)
                {
                    g.DrawLine(p, new Point(212, 355), new Point(212, 5)); // vertical wood
                }
                else if (gameWord.getTrys() == 2)
                {
                    g.DrawLine(p, new Point(207, 5), new Point(105, 5)); // horizontal wood
                }
                else if (gameWord.getTrys() == 3)
                {
                    g.DrawLine(p, new Point(105, 10), new Point(105, 50)); // the wood next to the head
                }
                else if (gameWord.getTrys() == 4)
                {
                    g.DrawEllipse(pb, 60, 50, 80, 80); // head
                }
                else if (gameWord.getTrys() == 5)
                {
                    g.DrawLine(pb, new Point(105, 130), new Point(105, 230)); // body
                }
                else if (gameWord.getTrys() == 6)
                {
                    g.DrawLine(pb, new Point(105, 130), new Point(80, 215)); // left arm
                }
                else if (gameWord.getTrys() == 7)
                {
                    g.DrawLine(pb, new Point(105, 130), new Point(130, 215)); // right arm
                }
                else if (gameWord.getTrys() == 8)
                {
                    g.DrawLine(pb, new Point(105, 230), new Point(80, 300)); // left leg
                }
                else if (gameWord.getTrys() == 9)
                {
                    g.DrawLine(pb, new Point(105, 230), new Point(130, 298)); // right leg 
                    label1.Visible = false;
                    txtMissedWord.BackColor = Color.Red;
                    txtMissedWord.Text = "Game over!";
            }

        }


               private void btnPlay_Click(object sender, EventArgs e)
            {
               // habilitate the buttons
               btnSubmiteLetter.Enabled = true;
               txtLetterInput.Enabled = true;

               btnSubmiteWord.Enabled = true;
               txtSentenceInput.Enabled = true;

                label1.Visible = true;

            // to display the word to be guessed 

            lblGuessedWord.Text = gameWord.getGuessedWord();

                // to display the word lenght

                lblLength.Text =("Length: " + gameWord.getSelectedWord().Length.ToString());

            }

        private void btnSubmiteWord_Click(object sender, EventArgs e)
        {
            btnSubmiteLetter.Enabled = false;

            string subWord = txtSentenceInput.Text; // to get the word

            // to check if the word is right
            if (subWord.Equals(gameWord.getSelectedWord())) 
            {
                label1.Visible = false;
                txtMissedWord.BackColor = Color.Blue;
                txtMissedWord.Text = ("Congrats! you guessed right");
            }

            else if (!subWord.Equals(gameWord.getSelectedWord()))
            {
                label1.Visible = false;
                txtMissedWord.BackColor = Color.Red;
                txtMissedWord.Text= ("You are wrong!\n" +
                                          " Game over!");
            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            // show the guesses word
            lblLength.Text = gameWord.getSelectedWord();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            // reset the aplication 
            Application.Restart();

          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit
            this.Close();

        }

       
    }

    }   


     
     
   
