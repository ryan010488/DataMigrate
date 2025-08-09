namespace DataMigrate.UI.Main.Forms
{
    partial class frmUpdatePatient
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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            btnConfirm = new Button();
            btnCancel = new Button();
            txtMiddleName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbGender = new ComboBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtMobile = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            txtState = new TextBox();
            label9 = new Label();
            txtSuburb = new TextBox();
            label10 = new Label();
            txtStreet = new TextBox();
            label11 = new Label();
            txtPostCode = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(101, 12);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(267, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(101, 70);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(267, 23);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateOfBirth.Checked = false;
            dtpDateOfBirth.Location = new Point(101, 99);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.ShowCheckBox = true;
            dtpDateOfBirth.Size = new Size(267, 23);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.Location = new Point(212, 365);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(293, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMiddleName.Location = new Point(101, 41);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(267, 23);
            txtMiddleName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 49);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "Middle Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "F", "M" });
            cmbGender.Location = new Point(101, 128);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(267, 23);
            cmbGender.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(101, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 23);
            txtEmail.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 165);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 12;
            label6.Text = "EMail:";
            // 
            // txtMobile
            // 
            txtMobile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMobile.Location = new Point(101, 186);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(267, 23);
            txtMobile.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 194);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 14;
            label7.Text = "Mobile No.:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(101, 215);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(267, 23);
            txtPhone.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 223);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 16;
            label8.Text = "Phone No.:";
            // 
            // txtState
            // 
            txtState.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtState.Location = new Point(101, 302);
            txtState.Name = "txtState";
            txtState.Size = new Size(267, 23);
            txtState.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 310);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 22;
            label9.Text = "State:";
            // 
            // txtSuburb
            // 
            txtSuburb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSuburb.Location = new Point(101, 273);
            txtSuburb.Name = "txtSuburb";
            txtSuburb.Size = new Size(267, 23);
            txtSuburb.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 281);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 20;
            label10.Text = "Suburb:";
            // 
            // txtStreet
            // 
            txtStreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStreet.Location = new Point(101, 244);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(267, 23);
            txtStreet.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 252);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 18;
            label11.Text = "Street:";
            // 
            // txtPostCode
            // 
            txtPostCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPostCode.Location = new Point(101, 331);
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(267, 23);
            txtPostCode.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 339);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 24;
            label12.Text = "Post Code:";
            // 
            // frmUpdatePatient
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(380, 400);
            Controls.Add(txtPostCode);
            Controls.Add(label12);
            Controls.Add(txtState);
            Controls.Add(label9);
            Controls.Add(txtSuburb);
            Controls.Add(label10);
            Controls.Add(txtStreet);
            Controls.Add(label11);
            Controls.Add(txtPhone);
            Controls.Add(label8);
            Controls.Add(txtMobile);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(txtMiddleName);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdatePatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Patient";
            Load += frmUpdatePatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDateOfBirth;
        private Button btnConfirm;
        private Button btnCancel;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtMiddleName;
        private Label label5;
        private ComboBox cmbGender;
        private Label label6;
        private TextBox txtMobile;
        private Label label7;
        private TextBox txtPhone;
        private Label label8;
        private TextBox txtState;
        private Label label9;
        private TextBox txtSuburb;
        private Label label10;
        private TextBox txtStreet;
        private Label label11;
        private TextBox txtPostCode;
        private Label label12;
    }
}