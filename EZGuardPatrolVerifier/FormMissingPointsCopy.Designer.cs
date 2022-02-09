
namespace EZGuardPatrolVerifier
{
    partial class FormMissingPointsCopy
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
            this.listBoxMissingPoints = new System.Windows.Forms.ListBox();
            this.buttonCopyMissingPointsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMissingPoints
            // 
            this.listBoxMissingPoints.FormattingEnabled = true;
            this.listBoxMissingPoints.ItemHeight = 16;
            this.listBoxMissingPoints.Location = new System.Drawing.Point(12, 12);
            this.listBoxMissingPoints.Name = "listBoxMissingPoints";
            this.listBoxMissingPoints.Size = new System.Drawing.Size(348, 228);
            this.listBoxMissingPoints.TabIndex = 2;
            // 
            // buttonCopyMissingPointsList
            // 
            this.buttonCopyMissingPointsList.Location = new System.Drawing.Point(72, 245);
            this.buttonCopyMissingPointsList.Name = "buttonCopyMissingPointsList";
            this.buttonCopyMissingPointsList.Size = new System.Drawing.Size(222, 30);
            this.buttonCopyMissingPointsList.TabIndex = 3;
            this.buttonCopyMissingPointsList.Text = "Copy";
            this.buttonCopyMissingPointsList.UseVisualStyleBackColor = true;
            this.buttonCopyMissingPointsList.Click += new System.EventHandler(this.buttonCopyMissingPointsList_Click);
            // 
            // FormMissingPointsCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 280);
            this.Controls.Add(this.buttonCopyMissingPointsList);
            this.Controls.Add(this.listBoxMissingPoints);
            this.MaximizeBox = false;
            this.Name = "FormMissingPointsCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EZGuard Humiliator - M.Points";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMissingPoints;
        private System.Windows.Forms.Button buttonCopyMissingPointsList;
    }
}