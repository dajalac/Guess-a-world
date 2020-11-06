using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessWord
{
    class Word
    {
        private String selectedWord;
        private String guessedWord;
        private int trys;
        private char missingLetter;



/** constructor method
 * get the randon word and put * on letter
 */

    public Word ()
        {
            string[] words = { "apricot", "elephant", "tigress", "fortunate", "impossible",
                           "historical", "colorful", "science" };

            // get a random word
            Random rdom = new Random();
            int i = rdom.Next(0, 8);
            selectedWord = words[i]; // select a word

            // to put * in the word letters
            for (int index = 0; index < selectedWord.Length; ++index)
            {
                guessedWord += "*";
            }
        }

    
        /** setDisplay method
         * check if the input letter macthes the selected word
         * @param le  the letter imput
         */

      public void setDisplay(char le)
        {
            if (!Char.IsLetter(le))
            {
                throw new NonLetterException (le);
            }
            else
            {
                bool flag = false;  // the flag variable to check if the input matchs the letter of the selected word
                char[] selectedWordArray = selectedWord.ToCharArray(); // transfor the selected word in array


                for (int i = 0; i < selectedWordArray.Length; i++) // to ckeck if there is a match
                {
                    if (selectedWordArray[i].Equals(le))
                    {
                        flag = true;
                        i = selectedWordArray.Length; // to end the loop
                        missingLetter = '*'; // to set missingletter to * (pt - de outra maneira no output a letra errada se repetiria)


                        //searching trought the selected letter
                        for (int index = 0; index < selectedWord.Length; ++index)
                        {
                            char tempChar = Convert.ToChar(selectedWord.Substring(index, 1));


                            if (tempChar.Equals(le))
                            {
                                guessedWord = guessedWord.Substring(0, index) + le +
                                           guessedWord.Substring(index + 1, (guessedWord.Length - 1 - index));
                            }

                        }

                    }
                }
                // if there is not the letter input in the selected word. 
                if (flag.Equals(false))
                {
                    missingLetter = le;
                    ++trys;
                }

            }

        }
    
    public void  setSelectedWord(string selectedWordReset)
        {
            selectedWord = selectedWordReset;
        }
    

    public void setGuessedWord(string guessedWordReset)
        {
            guessedWord = guessedWordReset;
        }

    public int getTrys()
        {
            return trys; 
        }
     public char getMissedLetter()
        {
            return missingLetter;
        }

    public string getSelectedWord ()
        {
            return selectedWord;
        }

    public string getGuessedWord()
        {
            return guessedWord;
        }

    }
}

// NonLetterException class
class NonLetterException : Exception
{
    public NonLetterException(char c) : base(" Error input " + c + " is not of the alpahbet")
    {
    }
}