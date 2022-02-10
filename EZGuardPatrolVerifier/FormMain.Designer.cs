
namespace EZGuardPatrolVerifier
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFileLoad = new System.Windows.Forms.TextBox();
            this.comboBoxPatrolType = new System.Windows.Forms.ComboBox();
            this.buttonGenerateScan = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelPatrol = new System.Windows.Forms.Label();
            this.labelPatrolHours = new System.Windows.Forms.Label();
            this.comboBoxPatrol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxFileLoad
            // 
            this.textBoxFileLoad.AllowDrop = true;
            this.textBoxFileLoad.Location = new System.Drawing.Point(12, 10);
            this.textBoxFileLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFileLoad.Name = "textBoxFileLoad";
            this.textBoxFileLoad.Size = new System.Drawing.Size(526, 22);
            this.textBoxFileLoad.TabIndex = 0;
            this.textBoxFileLoad.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileLoad_DragDrop);
            this.textBoxFileLoad.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFileLoad_DragEnter);
            // 
            // comboBoxPatrolType
            // 
            this.comboBoxPatrolType.FormattingEnabled = true;
            this.comboBoxPatrolType.Items.AddRange(new object[] {
            "Full Patrol",
            "Part-time Patrol"});
            this.comboBoxPatrolType.Location = new System.Drawing.Point(331, 41);
            this.comboBoxPatrolType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPatrolType.Name = "comboBoxPatrolType";
            this.comboBoxPatrolType.Size = new System.Drawing.Size(207, 24);
            this.comboBoxPatrolType.TabIndex = 1;
            // 
            // buttonGenerateScan
            // 
            this.buttonGenerateScan.Location = new System.Drawing.Point(650, 8);
            this.buttonGenerateScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerateScan.Name = "buttonGenerateScan";
            this.buttonGenerateScan.Size = new System.Drawing.Size(99, 60);
            this.buttonGenerateScan.TabIndex = 2;
            this.buttonGenerateScan.Text = "Generate";
            this.buttonGenerateScan.UseVisualStyleBackColor = true;
            this.buttonGenerateScan.Click += new System.EventHandler(this.buttonGenerateScan_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(561, 8);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(83, 60);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Open FIle";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // labelPatrol
            // 
            this.labelPatrol.AutoSize = true;
            this.labelPatrol.Location = new System.Drawing.Point(12, 43);
            this.labelPatrol.Name = "labelPatrol";
            this.labelPatrol.Size = new System.Drawing.Size(49, 17);
            this.labelPatrol.TabIndex = 4;
            this.labelPatrol.Text = "Patrol:";
            // 
            // labelPatrolHours
            // 
            this.labelPatrolHours.AutoSize = true;
            this.labelPatrolHours.Location = new System.Drawing.Point(274, 43);
            this.labelPatrolHours.Name = "labelPatrolHours";
            this.labelPatrolHours.Size = new System.Drawing.Size(50, 17);
            this.labelPatrolHours.TabIndex = 5;
            this.labelPatrolHours.Text = "Hours:";
            // 
            // comboBoxPatrol
            // 
            this.comboBoxPatrol.FormattingEnabled = true;
            this.comboBoxPatrol.Items.AddRange(new object[] {
            "TLV Rothchild",
            "Sarona (33-37)",
            "JOH",
            "Novi (31-32)",
            "46-50",
            "Savyon",
            "31-37 T",
            "46-50 T"});
            this.comboBoxPatrol.Location = new System.Drawing.Point(68, 41);
            this.comboBoxPatrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPatrol.Name = "comboBoxPatrol";
            this.comboBoxPatrol.Size = new System.Drawing.Size(188, 24);
            this.comboBoxPatrol.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 79);
            this.Controls.Add(this.comboBoxPatrol);
            this.Controls.Add(this.labelPatrolHours);
            this.Controls.Add(this.labelPatrol);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonGenerateScan);
            this.Controls.Add(this.comboBoxPatrolType);
            this.Controls.Add(this.textBoxFileLoad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZGuard Humiliator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileLoad;
        private System.Windows.Forms.ComboBox comboBoxPatrolType;
        private System.Windows.Forms.Button buttonGenerateScan;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelPatrol;
        private System.Windows.Forms.Label labelPatrolHours;
        private System.Windows.Forms.ComboBox comboBoxPatrol;
    }
}

