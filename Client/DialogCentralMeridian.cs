using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace LSDMS
{
    public partial class DialogCentralMeridian : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public int CentralMeridian = 0;
        public DialogCentralMeridian()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radZoneI.Checked)
                this.CentralMeridian = 117;
            if (radZoneII.Checked)
                this.CentralMeridian = 119;
            if (radZoneIII.Checked)
                this.CentralMeridian = 121;
            if (radZoneIV.Checked)
                this.CentralMeridian = 123;
            if (radZoneV.Checked)
                this.CentralMeridian = 125;

            this.Close();
        }

        
       
    }
}