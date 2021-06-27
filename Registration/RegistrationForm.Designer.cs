using System.Windows.Forms;

namespace TechSivaram.DocScan.Registration
{
    partial class RegistrationForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsuranceName = new System.Windows.Forms.TextBox();
            this.txtPolicyNo = new System.Windows.Forms.TextBox();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.txtInsured = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSymtoms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPLastName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNPI = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(191, 34);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "MM/dd/yyyy";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(357, 33);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(162, 20);
            this.dtDOB.TabIndex = 2;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.cbGender.Location = new System.Drawing.Point(544, 32);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 21);
            this.cbGender.TabIndex = 3;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(12, 90);
            this.txtAddress1.Multiline = true;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(304, 91);
            this.txtAddress1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address1";
            // 
            // txtInsuranceName
            // 
            this.txtInsuranceName.Location = new System.Drawing.Point(12, 227);
            this.txtInsuranceName.Name = "txtInsuranceName";
            this.txtInsuranceName.Size = new System.Drawing.Size(160, 20);
            this.txtInsuranceName.TabIndex = 13;
            // 
            // txtPolicyNo
            // 
            this.txtPolicyNo.Location = new System.Drawing.Point(178, 226);
            this.txtPolicyNo.Name = "txtPolicyNo";
            this.txtPolicyNo.Size = new System.Drawing.Size(151, 20);
            this.txtPolicyNo.TabIndex = 14;
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.Location = new System.Drawing.Point(335, 226);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(184, 20);
            this.txtGroupNumber.TabIndex = 15;
            // 
            // txtInsured
            // 
            this.txtInsured.Location = new System.Drawing.Point(527, 225);
            this.txtInsured.Name = "txtInsured";
            this.txtInsured.Size = new System.Drawing.Size(193, 20);
            this.txtInsured.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Group #";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Policy ID / Policy #";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Insurance Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Name Of Insured";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(357, 129);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(162, 20);
            this.txtSSN.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "SSN #";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(585, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 52);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(357, 90);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(162, 20);
            this.txtPhone.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phone";
            // 
            // txtSymtoms
            // 
            this.txtSymtoms.Location = new System.Drawing.Point(12, 279);
            this.txtSymtoms.Multiline = true;
            this.txtSymtoms.Name = "txtSymtoms";
            this.txtSymtoms.Size = new System.Drawing.Size(507, 68);
            this.txtSymtoms.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "ICD Codes";
            // 
            // txtPFirstName
            // 
            this.txtPFirstName.Location = new System.Drawing.Point(527, 90);
            this.txtPFirstName.Name = "txtPFirstName";
            this.txtPFirstName.Size = new System.Drawing.Size(193, 20);
            this.txtPFirstName.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(524, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Provider First Name";
            // 
            // txtPLastName
            // 
            this.txtPLastName.Location = new System.Drawing.Point(527, 128);
            this.txtPLastName.Name = "txtPLastName";
            this.txtPLastName.Size = new System.Drawing.Size(193, 20);
            this.txtPLastName.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(524, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Provider Last Name";
            // 
            // txtNPI
            // 
            this.txtNPI.Location = new System.Drawing.Point(527, 167);
            this.txtNPI.Name = "txtNPI";
            this.txtNPI.Size = new System.Drawing.Size(193, 20);
            this.txtNPI.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(524, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Provider NPI";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 359);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNPI);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPLastName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSymtoms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInsured);
            this.Controls.Add(this.txtGroupNumber);
            this.Controls.Add(this.txtPolicyNo);
            this.Controls.Add(this.txtInsuranceName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInsuranceName;
        private System.Windows.Forms.TextBox txtPolicyNo;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.TextBox txtInsured;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSymtoms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPLastName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNPI;
        private System.Windows.Forms.Label label15;
    }
}