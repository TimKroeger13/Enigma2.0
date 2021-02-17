using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Enigma2._0.Components
{
    public class FromCreater
    {
        public void InitializeForm(Form form, int higth, int width)
        {
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(width, higth);
        }
    }
}