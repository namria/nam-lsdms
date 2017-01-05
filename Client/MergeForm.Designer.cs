namespace LSDMS
{
    partial class MergeForm
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
            this.btnMerge = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbxCodes = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btnCancel);
            this.kryptonPanel.Controls.Add(this.btnMerge);
            this.kryptonPanel.Controls.Add(this.lbxCodes);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(255, 214);
            this.kryptonPanel.TabIndex = 1;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(69, 177);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(68, 25);
            this.btnMerge.TabIndex = 1;
            this.btnMerge.Text = "&Merge";
            this.btnMerge.Values.ExtraText = "";
            this.btnMerge.Values.Image = null;
            this.btnMerge.Values.ImageStates.ImageCheckedNormal = null;
            this.btnMerge.Values.ImageStates.ImageCheckedPressed = null;
            this.btnMerge.Values.ImageStates.ImageCheckedTracking = null;
            this.btnMerge.Values.Text = "&Merge";
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lbxCodes
            // 
            this.lbxCodes.Location = new System.Drawing.Point(12, 12);
            this.lbxCodes.Name = "lbxCodes";
            this.lbxCodes.Size = new System.Drawing.Size(231, 157);
            this.lbxCodes.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.btnCancel.Location = new System.Drawing.Point(143, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 19);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Values.ExtraText = "";
            this.btnCancel.Values.Image = null;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.LinkClicked += new System.EventHandler(this.btnCancel_LinkClicked);
            // 
            // MergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 214);
            this.Controls.Add(this.kryptonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MergeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge with another record";
            this.Load += new System.EventHandler(this.MergeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxCodes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMerge;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel btnCancel;
    }
}

