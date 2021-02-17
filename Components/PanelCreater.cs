using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Enigma2._0.Components;

namespace Enigma2._0.Components
{
    public class PanelCreater
    {
        public Panel KeyboardPanel(int Keyboardrows)
        {
            Panel Keyboard = new Panel
            {
                Size = new System.Drawing.Size(640, 75 * Keyboardrows),
                Location = new System.Drawing.Point(400, 50),
                AutoScroll = true,
            };
            return Keyboard;
        }
    }
}