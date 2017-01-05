namespace LSDMS
{
    partial class DialogCentralMeridian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.radZoneV = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radZoneIV = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radZoneIII = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radZoneII = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radZoneI = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.radZoneV);
            this.kryptonPanel.Controls.Add(this.radZoneIV);
            this.kryptonPanel.Controls.Add(this.radZoneIII);
            this.kryptonPanel.Controls.Add(this.radZoneII);
            this.kryptonPanel.Controls.Add(this.radZoneI);
            this.kryptonPanel.Controls.Add(this.btnOk);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(218, 190);
            this.kryptonPanel.TabIndex = 0;
            // 
            // radZoneV
            // 
            this.radZoneV.Location = new System.Drawing.Point(62, 112);
            this.radZoneV.Name = "radZoneV";
            this.radZoneV.Size = new System.Drawing.Size(91, 19);
            this.radZoneV.TabIndex = 6;
            this.radZoneV.Text = "Zone V - 125°";
            this.radZoneV.Values.ExtraText = "";
            this.radZoneV.Values.Image = null;
            this.radZoneV.Values.Text = "Zone V - 125°";
            // 
            // radZoneIV
            // 
            this.radZoneIV.Location = new System.Drawing.Point(62, 87);
            this.radZoneIV.Name = "radZoneIV";
            this.radZoneIV.Size = new System.Drawing.Size(94, 19);
            this.radZoneIV.TabIndex = 5;
            this.radZoneIV.Text = "Zone IV - 123°";
            this.radZoneIV.Values.ExtraText = "";
            this.radZoneIV.Values.Image = null;
            this.radZoneIV.Values.Text = "Zone IV - 123°";
            // 
            // radZoneIII
            // 
            this.radZoneIII.Location = new System.Drawing.Point(62, 62);
            this.radZoneIII.Name = "radZoneIII";
            this.radZoneIII.Size = new System.Drawing.Size(93, 19);
            this.radZoneIII.TabIndex = 4;
            this.radZoneIII.Text = "Zone III - 121°";
            this.radZoneIII.Values.ExtraText = "";
            this.radZoneIII.Values.Image = null;
            this.radZoneIII.Values.Text = "Zone III - 121°";
            // 
            // radZoneII
            // 
            this.radZoneII.Location = new System.Drawing.Point(62, 37);
            this.radZoneII.Name = "radZoneII";
            this.radZoneII.Size = new System.Drawing.Size(90, 19);
            this.radZoneII.TabIndex = 3;
            this.radZoneII.Text = "Zone II - 119°";
            this.radZoneII.Values.ExtraText = "";
            this.radZoneII.Values.Image = null;
            this.radZoneII.Values.Text = "Zone II - 119°";
            // 
            // radZoneI
            // 
            this.radZoneI.Checked = true;
            this.radZoneI.Location = new System.Drawing.Point(62, 12);
            this.radZoneI.Name = "radZoneI";
            this.radZoneI.Size = new System.Drawing.Size(87, 19);
            this.radZoneI.TabIndex = 2;
            this.radZoneI.Text = "Zone I - 117°";
            this.radZoneI.Values.ExtraText = "";
            this.radZoneI.Values.Image = null;
            this.radZoneI.Values.Text = "Zone I - 117°";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(65, 153);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 25);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.Values.ExtraText = "";
            this.btnOk.Values.Image = null;
            this.btnOk.Values.ImageStates.ImageCheckedNormal = null;
            this.btnOk.Values.ImageStates.ImageCheckedPressed = null;
            this.btnOk.Values.ImageStates.ImageCheckedTracking = null;
            this.btnOk.Values.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // DialogCentralMeridian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 190);
            this.Controls.Add(this.kryptonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogCentralMeridian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Central Meridian";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radZoneI;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radZoneIII;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radZoneII;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radZoneV;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radZoneIV;
    }
}

