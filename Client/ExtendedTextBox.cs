using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LSDMS
{
    partial class ExtendedTextBox : TextBox
    {
        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("x");
        }

    }
}
