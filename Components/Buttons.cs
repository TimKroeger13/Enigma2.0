using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Enigma2._0.Components
{
    public class Buttons
    {
        public Button KeyboardButtons(int x, int y, char Buttonname)
        {
            var button = new Button();
            button.Location = new System.Drawing.Point(x, y);
            button.Size = new System.Drawing.Size(57, 67);
            //button.TabIndex = 0;
            button.Text = char.ToString(Buttonname);
            button.Click += (sender, e) => Debug.WriteLine(button.Text);
            button.UseVisualStyleBackColor = true;
            return button;
        }
    }
}