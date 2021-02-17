using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Enigma2._0.Components
{
    public class Alphabet
    {
        public string AlphabetEnglish()
        {
            return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public string AlphabetGerman()
        {
            return "abcdefghijklmnopqrstuvwxyzäöüß<ABCDEFGHIJKLMNOPQRSTUVWXYZÄÖÜß>";
        }

        public string LettersForButtons(string alphabet)
        {
            return alphabet.Substring(alphabet.Length / 2, alphabet.Length / 2);
        }
    }
}