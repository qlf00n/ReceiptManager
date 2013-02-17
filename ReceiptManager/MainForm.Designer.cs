namespace ReceiptManager
{
    partial class FormMain
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
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.listBoxDataItems = new System.Windows.Forms.ListBox();
            this.buttonChooseDataFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPhoto
            // 
            this.panelPhoto.Location = new System.Drawing.Point(312, 12);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(300, 417);
            this.panelPhoto.TabIndex = 0;
            // 
            // listBoxDataItems
            // 
            this.listBoxDataItems.FormattingEnabled = true;
            this.listBoxDataItems.Location = new System.Drawing.Point(12, 12);
            this.listBoxDataItems.Name = "listBoxDataItems";
            this.listBoxDataItems.Size = new System.Drawing.Size(160, 420);
            this.listBoxDataItems.TabIndex = 1;
            // 
            // buttonChooseDataFile
            // 
            this.buttonChooseDataFile.Location = new System.Drawing.Point(178, 12);
            this.buttonChooseDataFile.Name = "buttonChooseDataFile";
            this.buttonChooseDataFile.Size = new System.Drawing.Size(128, 23);
            this.buttonChooseDataFile.TabIndex = 2;
            this.buttonChooseDataFile.Text = "Choose data file";
            this.buttonChooseDataFile.UseVisualStyleBackColor = true;
            this.buttonChooseDataFile.Click += new System.EventHandler(this.buttonChooseDataFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonChooseDataFile);
            this.Controls.Add(this.listBoxDataItems);
            this.Controls.Add(this.panelPhoto);
            this.Name = "FormMain";
            this.Text = "Receipt Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.ListBox listBoxDataItems;
        private System.Windows.Forms.Button buttonChooseDataFile;
    }
}

