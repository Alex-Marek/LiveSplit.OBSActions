
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
            this.topLevelLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSize = true;
            this.topLevelLayoutPanel.ColumnCount = 1;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.Controls.Add(this.chkStartRecording, 0, 0);
            this.topLevelLayoutPanel.Controls.Add(this.chkStopRecording, 0, 1);
            this.topLevelLayoutPanel.Controls.Add(this.chkGoldReplay, 0, 2);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 3;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(200, 144);
            this.topLevelLayoutPanel.TabIndex = 0;
            // 
            // chkStartRecording
            // 
            this.chkStartRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStartRecording.AutoSize = true;
            this.chkStartRecording.Location = new System.Drawing.Point(3, 16);
            this.chkStartRecording.Name = "chkStartRecording";
            this.chkStartRecording.Size = new System.Drawing.Size(194, 17);
            this.chkStartRecording.TabIndex = 0;
            this.chkStartRecording.Text = "Start recording on run start";
            this.chkStartRecording.UseVisualStyleBackColor = true;
            // 
            // chkStopRecording
            // 
            this.chkStopRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStopRecording.AutoSize = true;
            this.chkStopRecording.Location = new System.Drawing.Point(3, 65);
            this.chkStopRecording.Name = "chkStopRecording";
            this.chkStopRecording.Size = new System.Drawing.Size(194, 17);
            this.chkStopRecording.TabIndex = 1;
            this.chkStopRecording.Text = "Stop recording on run reset";
            this.chkStopRecording.UseVisualStyleBackColor = true;
            // 
            // chkGoldReplay
            // 
            this.chkGoldReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGoldReplay.AutoSize = true;
            this.chkGoldReplay.Location = new System.Drawing.Point(3, 112);
            this.chkGoldReplay.Name = "chkGoldReplay";
            this.chkGoldReplay.Size = new System.Drawing.Size(194, 17);
            this.chkGoldReplay.TabIndex = 2;
            this.chkGoldReplay.Text = "Save golds as replays";
            this.chkGoldReplay.UseVisualStyleBackColor = true;
            // 
            // OBSActionsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Name = "OBSActionsSettings";
            this.Size = new System.Drawing.Size(203, 150);
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
    }
}
