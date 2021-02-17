using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Enigma2._0.Components;

namespace Enigma2._0.Components
{
    public class GenerateButtons
    {
        public void GenerateButton(Panel Panel, Button Button)
        {
            Panel.Controls.Add(Button);
        }
    }
}