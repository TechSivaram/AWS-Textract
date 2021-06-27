namespace TechSivaram.DocScan
{
    partial class ScannerForm
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
            this.lstScanners = new System.Windows.Forms.ComboBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.pb_ScannedDoc = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScannedDoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstScanners
            // 
            this.lstScanners.FormattingEnabled = true;
            this.lstScanners.Location = new System.Drawing.Point(8, 29);
            this.lstScanners.Name = "lstScanners";
            this.lstScanners.Size = new System.Drawing.Size(186, 21);
            this.lstScanners.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(8, 73);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(186, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pb_ScannedDoc
            // 
            this.pb_ScannedDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_ScannedDoc.Location = new System.Drawing.Point(3, 16);
            this.pb_ScannedDoc.Name = "pb_ScannedDoc";
            this.pb_ScannedDoc.Size = new System.Drawing.Size(594, 431);
            this.pb_ScannedDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ScannedDoc.TabIndex = 2;
            this.pb_ScannedDoc.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.lstScanners);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(6, 114);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(188, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.pb_ScannedDoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(200, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 450);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(7, 155);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(187, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Device";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScannerForm";
            this.Text = "Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScannerForm_FormClosing);
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScannedDoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstScanners;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pb_ScannedDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnStop;
    }
}

