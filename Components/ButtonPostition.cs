using System;
using System.Collections.Generic;
using System.Text;
using Enigma2._0.Components;

namespace Enigma2._0.Components
{
    public class ButtonPostition
    {
        public int row = 0;
        public int col = 0;

        public void RestButtonPostition()
        {
            row = 0;
            col = 0;
        }

        public int RowsNeededForKeyboard(string alphabet)
        {
            var FuncAlphabet = new Alphabet();
            var RowCounter = 1;
            var LengthOfAlphabet = FuncAlphabet.LettersForButtons(alphabet).Length;
            while (LengthOfAlphabet > 10)
            {
                RowCounter += 1;
                LengthOfAlphabet -= 10;
            }
            return RowCounter;
        }

        public void NewButtonPosition()
        {
            if (col > 576)
            {
                col = 0;
                row += 75;
            }
            col += 64;
        }
    }
}