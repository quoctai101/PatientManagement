namespace PatientManagement
{
    partial class FrmResearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResearch));
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbRecord = new System.Windows.Forms.RadioButton();
            this.rbAddress = new System.Windows.Forms.RadioButton();
            this.rbTelephone = new System.Windows.Forms.RadioButton();
            this.rbDOB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(13, 34);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(53, 17);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbRecord
            // 
            this.rbRecord.AutoSize = true;
            this.rbRecord.Location = new System.Drawing.Point(72, 34);
            this.rbRecord.Name = "rbRecord";
            this.rbRecord.Size = new System.Drawing.Size(60, 17);
            this.rbRecord.TabIndex = 1;
            this.rbRecord.TabStop = true;
            this.rbRecord.Text = "Record";
            this.rbRecord.UseVisualStyleBackColor = true;
            // 
            // rbAddress
            // 
            this.rbAddress.AutoSize = true;
            this.rbAddress.Location = new System.Drawing.Point(138, 34);
            this.rbAddress.Name = "rbAddress";
            this.rbAddress.Size = new System.Drawing.Size(63, 17);
            this.rbAddress.TabIndex = 2;
            this.rbAddress.TabStop = true;
            this.rbAddress.Text = "Address";
            this.rbAddress.UseVisualStyleBackColor = true;
            // 
            // rbTelephone
            // 
            this.rbTelephone.AutoSize = true;
            this.rbTelephone.Location = new System.Drawing.Point(207, 34);
            this.rbTelephone.Name = "rbTelephone";
            this.rbTelephone.Size = new System.Drawing.Size(76, 17);
            this.rbTelephone.TabIndex = 3;
            this.rbTelephone.TabStop = true;
            this.rbTelephone.Text = "Telephone";
            this.rbTelephone.UseVisualStyleBackColor = true;
            // 
            // rbDOB
            // 
            this.rbDOB.AutoSize = true;
            this.rbDOB.Location = new System.Drawing.Point(289, 34);
            this.rbDOB.Name = "rbDOB";
            this.rbDOB.Size = new System.Drawing.Size(83, 17);
            this.rbDOB.TabIndex = 4;
            this.rbDOB.TabStop = true;
            this.rbDOB.Text = "Date of birth";
            this.rbDOB.UseVisualStyleBackColor = true;
            this.rbDOB.CheckedChanged += new System.EventHandler(this.rbDOB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Research by: ";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(114, 57);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(169, 20);
            this.txtValue.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(143, 83);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(108, 20);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.Visible = false;
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(114, 121);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(75, 23);
            this.btnResearch.TabIndex = 8;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDOB);
            this.Controls.Add(this.rbTelephone);
            this.Controls.Add(this.rbAddress);
            this.Controls.Add(this.rbRecord);
            this.Controls.Add(this.rbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmResearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Research for patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbRecord;
        private System.Windows.Forms.RadioButton rbAddress;
        private System.Windows.Forms.RadioButton rbTelephone;
        private System.Windows.Forms.RadioButton rbDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnCancel;
    }
}