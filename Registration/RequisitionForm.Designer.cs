namespace TechSivaram.DocScan.Registration
{
    partial class RequisitionForm
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
            this.brRequisition = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // brRequisition
            // 
            this.brRequisition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brRequisition.Location = new System.Drawing.Point(0, 0);
            this.brRequisition.MinimumSize = new System.Drawing.Size(20, 20);
            this.brRequisition.Name = "brRequisition";
            this.brRequisition.Size = new System.Drawing.Size(800, 450);
            this.brRequisition.TabIndex = 0;
            // 
            // RequisitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brRequisition);
            this.Name = "RequisitionForm";
            this.Text = "RequisitionForm";
            this.Load += new System.EventHandler(this.RequisitionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser brRequisition;
    }
}