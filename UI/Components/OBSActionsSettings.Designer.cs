
namespace LiveSplit.UI.Components
{
    partial class OBSActionsSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLevelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkStartRecording = new System.Windows.Forms.CheckBox();
            this.chkStopRecording = new System.Windows.Forms.CheckBox();
            this.chkGoldReplay = new System.Windows.Forms.CheckBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblWSIP = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblWSPS = new System.Windows.Forms.Label();
            this.topLevelLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSize = true;
            this.topLevelLayoutPanel.ColumnCount = 2;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.Controls.Add(this.chkStartRecording, 0, 0);
            this.topLevelLayoutPanel.Controls.Add(this.chkStopRecording, 0, 1);
            this.topLevelLayoutPanel.Controls.Add(this.chkGoldReplay, 0, 2);
            this.topLevelLayoutPanel.Controls.Add(this.txtIP, 1, 3);
            this.topLevelLayoutPanel.Controls.Add(this.lblWSIP, 0, 3);
            this.topLevelLayoutPanel.Controls.Add(this.txtPassword, 1, 4);
            this.topLevelLayoutPanel.Controls.Add(this.lblWSPS, 0, 4);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 5;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(320, 210);
            this.topLevelLayoutPanel.TabIndex = 0;
            this.topLevelLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topLevelLayoutPanel_Paint);
            // 
            // chkStartRecording
            // 
            this.chkStartRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStartRecording.AutoSize = true;
            this.chkStartRecording.Location = new System.Drawing.Point(3, 9);
            this.chkStartRecording.Name = "chkStartRecording";
            this.chkStartRecording.Size = new System.Drawing.Size(154, 17);
            this.chkStartRecording.TabIndex = 0;
            this.chkStartRecording.Text = "Start recording on run start";
            this.chkStartRecording.UseVisualStyleBackColor = true;
            // 
            // chkStopRecording
            // 
            this.chkStopRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStopRecording.AutoSize = true;
            this.chkStopRecording.Location = new System.Drawing.Point(3, 44);
            this.chkStopRecording.Name = "chkStopRecording";
            this.chkStopRecording.Size = new System.Drawing.Size(154, 17);
            this.chkStopRecording.TabIndex = 1;
            this.chkStopRecording.Text = "Stop recording on run reset";
            this.chkStopRecording.UseVisualStyleBackColor = true;
            // 
            // chkGoldReplay
            // 
            this.chkGoldReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGoldReplay.AutoSize = true;
            this.chkGoldReplay.Location = new System.Drawing.Point(3, 81);
            this.chkGoldReplay.Name = "chkGoldReplay";
            this.chkGoldReplay.Size = new System.Drawing.Size(154, 17);
            this.chkGoldReplay.TabIndex = 2;
            this.chkGoldReplay.Text = "Save golds as replays";
            this.chkGoldReplay.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIP.Location = new System.Drawing.Point(164, 113);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(153, 20);
            this.txtIP.TabIndex = 3;
            // 
            // lblWSIP
            // 
            this.lblWSIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWSIP.AutoSize = true;
            this.lblWSIP.Location = new System.Drawing.Point(77, 110);
            this.lblWSIP.Name = "lblWSIP";
            this.lblWSIP.Size = new System.Drawing.Size(80, 13);
            this.lblWSIP.TabIndex = 4;
            this.lblWSIP.Text = "WebSocket IP:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(164, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblWSPS
            // 
            this.lblWSPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWSPS.AutoSize = true;
            this.lblWSPS.Location = new System.Drawing.Point(41, 159);
            this.lblWSPS.Name = "lblWSPS";
            this.lblWSPS.Size = new System.Drawing.Size(116, 13);
            this.lblWSPS.TabIndex = 6;
            this.lblWSPS.Text = "WebSocket Password:";
            // 
            // OBSActionsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Name = "OBSActionsSettings";
            this.Size = new System.Drawing.Size(329, 219);
            this.Load += new System.EventHandler(this.OBSActionsSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topLevelLayoutPanel;
        private System.Windows.Forms.CheckBox chkStartRecording;
        private System.Windows.Forms.CheckBox chkStopRecording;
        private System.Windows.Forms.CheckBox chkGoldReplay;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblWSIP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblWSPS;
    }
}
