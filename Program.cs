using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enigma2._0.Components;
using System.Diagnostics;

namespace Enigma2._0
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using var form = new Form();
            var fromCreater = new FromCreater();
            var alphabet = new Alphabet();
            var buttonPostition = new ButtonPostition();
            var buttons = new Buttons();
            var generateButtons = new GenerateButtons();
            var panelcreater = new PanelCreater();
            fromCreater.InitializeForm(form, 800, 740);

            using var KeyboardPanel = panelcreater.KeyboardPanel(buttonPostition.RowsNeededForKeyboard(alphabet.AlphabetGerman()));
            form.Controls.Add(KeyboardPanel);

            for (int i = 0; i < alphabet.LettersForButtons(alphabet.AlphabetGerman()).Length; i++)
            {
                using var KeyboardButton = buttons.KeyboardButtons(buttonPostition.row, buttonPostition.col,
                    alphabet.LettersForButtons(alphabet.AlphabetGerman())[i]);
                generateButtons.GenerateButton(KeyboardPanel, KeyboardButton);
                buttonPostition.NewButtonPosition();
            }

            Application.Run(form);
        }
    }
}