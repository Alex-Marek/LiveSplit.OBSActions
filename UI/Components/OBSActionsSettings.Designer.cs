
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
            this.grpbRecording = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkStopRecording = new System.Windows.Forms.CheckBox();
            this.chkStartRecording = new System.Windows.Forms.CheckBox();
            this.grpbReplay = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkGoldReplay = new System.Windows.Forms.CheckBox();
            this.chkReplayStart = new System.Windows.Forms.CheckBox();
            this.chkReplayResetSplit = new System.Windows.Forms.CheckBox();
            this.grpbConnection = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWSPS = new System.Windows.Forms.Label();
            this.lblWSIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkDeleteRecording = new System.Windows.Forms.CheckBox();
            this.grpbRecording.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpbReplay.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpbConnection.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbRecording
            // 
            this.grpbRecording.Controls.Add(this.tableLayoutPanel1);
            this.grpbRecording.Location = new System.Drawing.Point(3, 3);
            this.grpbRecording.Name = "grpbRecording";
            this.grpbRecording.Size = new System.Drawing.Size(197, 124);
            this.grpbRecording.TabIndex = 1;
            this.grpbRecording.TabStop = false;
            this.grpbRecording.Text = "Recording";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chkStopRecording, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkStartRecording, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkDeleteRecording, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkStopRecording
            // 
            this.chkStopRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStopRecording.AutoSize = true;
            this.chkStopRecording.Location = new System.Drawing.Point(3, 38);
            this.chkStopRecording.Name = "chkStopRecording";
            this.chkStopRecording.Size = new System.Drawing.Size(172, 17);
            this.chkStopRecording.TabIndex = 2;
            this.chkStopRecording.Text = "Stop Recording on run end";
            this.chkStopRecording.UseVisualStyleBackColor = true;
            // 
            // chkStartRecording
            // 
            this.chkStartRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStartRecording.AutoSize = true;
            this.chkStartRecording.Location = new System.Drawing.Point(3, 7);
            this.chkStartRecording.Name = "chkStartRecording";
            this.chkStartRecording.Size = new System.Drawing.Size(172, 17);
            this.chkStartRecording.TabIndex = 1;
            this.chkStartRecording.Text = "Start Recording on run start";
            this.chkStartRecording.UseVisualStyleBackColor = true;
            // 
            // grpbReplay
            // 
            this.grpbReplay.Controls.Add(this.tableLayoutPanel2);
            this.grpbReplay.Location = new System.Drawing.Point(3, 133);
            this.grpbReplay.Name = "grpbReplay";
            this.grpbReplay.Size = new System.Drawing.Size(197, 127);
            this.grpbReplay.TabIndex = 2;
            this.grpbReplay.TabStop = false;
            this.grpbReplay.Text = "Replay Buffer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.chkGoldReplay, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkReplayStart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkReplayResetSplit, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(178, 105);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chkGoldReplay
            // 
            this.chkGoldReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGoldReplay.AutoSize = true;
            this.chkGoldReplay.Location = new System.Drawing.Point(3, 78);
            this.chkGoldReplay.Name = "chkGoldReplay";
            this.chkGoldReplay.Size = new System.Drawing.Size(172, 17);
            this.chkGoldReplay.TabIndex = 3;
            this.chkGoldReplay.Text = "Save Replay Buffer on gold";
            this.chkGoldReplay.UseVisualStyleBackColor = true;
            // 
            // chkReplayStart
            // 
            this.chkReplayStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReplayStart.AutoSize = true;
            this.chkReplayStart.Location = new System.Drawing.Point(3, 8);
            this.chkReplayStart.Name = "chkReplayStart";
            this.chkReplayStart.Size = new System.Drawing.Size(172, 17);
            this.chkReplayStart.TabIndex = 0;
            this.chkReplayStart.Text = "Start Replay Buffer on run start";
            this.chkReplayStart.UseVisualStyleBackColor = true;
            // 
            // chkReplayResetSplit
            // 
            this.chkReplayResetSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReplayResetSplit.AutoSize = true;
            this.chkReplayResetSplit.Location = new System.Drawing.Point(3, 42);
            this.chkReplayResetSplit.Name = "chkReplayResetSplit";
            this.chkReplayResetSplit.Size = new System.Drawing.Size(172, 17);
            this.chkReplayResetSplit.TabIndex = 1;
            this.chkReplayResetSplit.Text = "Reset Replay Buffer every split";
            this.chkReplayResetSplit.UseVisualStyleBackColor = true;
            // 
            // grpbConnection
            // 
            this.grpbConnection.Controls.Add(this.tableLayoutPanel3);
            this.grpbConnection.Location = new System.Drawing.Point(3, 260);
            this.grpbConnection.Name = "grpbConnection";
            this.grpbConnection.Size = new System.Drawing.Size(294, 136);
            this.grpbConnection.TabIndex = 3;
            this.grpbConnection.TabStop = false;
            this.grpbConnection.Text = "Connection";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.97163F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.02837F));
            this.tableLayoutPanel3.Controls.Add(this.lblWSPS, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblWSIP, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtIP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(282, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblWSPS
            // 
            this.lblWSPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWSPS.AutoSize = true;
            this.lblWSPS.Location = new System.Drawing.Point(3, 68);
            this.lblWSPS.Name = "lblWSPS";
            this.lblWSPS.Size = new System.Drawing.Size(116, 13);
            this.lblWSPS.TabIndex = 7;
            this.lblWSPS.Text = "WebSocket Password:";
            // 
            // lblWSIP
            // 
            this.lblWSIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWSIP.AutoSize = true;
            this.lblWSIP.Location = new System.Drawing.Point(3, 18);
            this.lblWSIP.Name = "lblWSIP";
            this.lblWSIP.Size = new System.Drawing.Size(80, 13);
            this.lblWSIP.TabIndex = 5;
            this.lblWSIP.Text = "WebSocket IP:";
            // 
            // txtIP
            // 
            this.txtIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIP.Location = new System.Drawing.Point(126, 15);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(153, 20);
            this.txtIP.TabIndex = 8;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(126, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // chkDeleteRecording
            // 
            this.chkDeleteRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDeleteRecording.AutoSize = true;
            this.chkDeleteRecording.Location = new System.Drawing.Point(3, 71);
            this.chkDeleteRecording.Name = "chkDeleteRecording";
            this.chkDeleteRecording.Size = new System.Drawing.Size(172, 17);
            this.chkDeleteRecording.TabIndex = 3;
            this.chkDeleteRecording.Text = "Delete non-pb Recordings";
            this.chkDeleteRecording.UseVisualStyleBackColor = true;
            // 
            // OBSActionsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpbConnection);
            this.Controls.Add(this.grpbReplay);
            this.Controls.Add(this.grpbRecording);
            this.Name = "OBSActionsSettings";
            this.Size = new System.Drawing.Size(300, 399);
            this.Load += new System.EventHandler(this.OBSActionsSettings_Load);
            this.grpbRecording.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpbReplay.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpbConnection.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbRecording;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkStopRecording;
        private System.Windows.Forms.CheckBox chkStartRecording;
        private System.Windows.Forms.GroupBox grpbReplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkGoldReplay;
        private System.Windows.Forms.CheckBox chkReplayStart;
        private System.Windows.Forms.CheckBox chkReplayResetSplit;
        private System.Windows.Forms.GroupBox grpbConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblWSPS;
        private System.Windows.Forms.Label lblWSIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkDeleteRecording;
    }
}
