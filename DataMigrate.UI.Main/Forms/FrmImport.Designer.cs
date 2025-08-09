namespace DataMigrate
{
    partial class frmImport
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
            dgvRecord = new DataGridView();
            btnImport = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnSave = new Button();
            dgvTreatment = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            cmbFilterPatient = new ComboBox();
            cmbFilterTreatment = new ComboBox();
            lblPatientInvalid = new Label();
            lblPatientTotal = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTreatmentTotal = new Label();
            lblTreatmentInvalid = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTreatment).BeginInit();
            SuspendLayout();
            // 
            // dgvRecord
            // 
            dgvRecord.AllowUserToAddRows = false;
            dgvRecord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(12, 52);
            dgvRecord.Name = "dgvRecord";
            dgvRecord.ReadOnly = true;
            dgvRecord.Size = new Size(837, 41);
            dgvRecord.TabIndex = 0;
            dgvRecord.CellDoubleClick += dgvRecord_CellDoubleClick;
            dgvRecord.DataBindingComplete += dgvRecord_DataBindingComplete;
            dgvRecord.RowPrePaint += dgvRecord_RowPrePaint;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(753, 11);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(96, 34);
            btnImport.TabIndex = 1;
            btnImport.Text = "Select CSV";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(753, 402);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Import";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvTreatment
            // 
            dgvTreatment.AllowUserToAddRows = false;
            dgvTreatment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTreatment.Location = new Point(12, 136);
            dgvTreatment.Name = "dgvTreatment";
            dgvTreatment.ReadOnly = true;
            dgvTreatment.Size = new Size(837, 260);
            dgvTreatment.TabIndex = 3;
            dgvTreatment.CellDoubleClick += dgvTreatment_CellDoubleClick;
            dgvTreatment.DataBindingComplete += dgvTreatment_DataBindingComplete;
            dgvTreatment.RowPrePaint += dgvTreatment_RowPrePaint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(110, 37);
            label2.TabIndex = 5;
            label2.Text = "Patients";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 402);
            label3.Name = "label3";
            label3.Size = new Size(272, 17);
            label3.TabIndex = 6;
            label3.Text = "Note: Double click the row to edit the record.";
            // 
            // cmbFilterPatient
            // 
            cmbFilterPatient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilterPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterPatient.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterPatient.FormattingEnabled = true;
            cmbFilterPatient.Location = new Point(613, 11);
            cmbFilterPatient.Name = "cmbFilterPatient";
            cmbFilterPatient.Size = new Size(134, 33);
            cmbFilterPatient.TabIndex = 12;
            cmbFilterPatient.Visible = false;
            cmbFilterPatient.SelectedIndexChanged += cmbFilterPatient_SelectedIndexChanged;
            // 
            // cmbFilterTreatment
            // 
            cmbFilterTreatment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbFilterTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterTreatment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterTreatment.FormattingEnabled = true;
            cmbFilterTreatment.Location = new Point(715, 97);
            cmbFilterTreatment.Name = "cmbFilterTreatment";
            cmbFilterTreatment.Size = new Size(134, 33);
            cmbFilterTreatment.TabIndex = 13;
            cmbFilterTreatment.Visible = false;
            cmbFilterTreatment.SelectedIndexChanged += cmbFilterTreatment_SelectedIndexChanged;
            // 
            // lblPatientInvalid
            // 
            lblPatientInvalid.AutoSize = true;
            lblPatientInvalid.ForeColor = Color.Red;
            lblPatientInvalid.Location = new Point(319, 27);
            lblPatientInvalid.Name = "lblPatientInvalid";
            lblPatientInvalid.Size = new Size(13, 15);
            lblPatientInvalid.TabIndex = 15;
            lblPatientInvalid.Text = "0";
            // 
            // lblPatientTotal
            // 
            lblPatientTotal.AutoSize = true;
            lblPatientTotal.Location = new Point(206, 27);
            lblPatientTotal.Name = "lblPatientTotal";
            lblPatientTotal.Size = new Size(13, 15);
            lblPatientTotal.TabIndex = 17;
            lblPatientTotal.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 4;
            label1.Text = "Treatments";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 27);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 20;
            label4.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(268, 27);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 21;
            label5.Text = "Invalid:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(268, 114);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 25;
            label6.Text = "Invalid:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(165, 114);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 24;
            label7.Text = "Total:";
            // 
            // lblTreatmentTotal
            // 
            lblTreatmentTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTreatmentTotal.AutoSize = true;
            lblTreatmentTotal.Location = new Point(206, 114);
            lblTreatmentTotal.Name = "lblTreatmentTotal";
            lblTreatmentTotal.Size = new Size(13, 15);
            lblTreatmentTotal.TabIndex = 23;
            lblTreatmentTotal.Text = "0";
            // 
            // lblTreatmentInvalid
            // 
            lblTreatmentInvalid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTreatmentInvalid.AutoSize = true;
            lblTreatmentInvalid.ForeColor = Color.Red;
            lblTreatmentInvalid.Location = new Point(319, 114);
            lblTreatmentInvalid.Name = "lblTreatmentInvalid";
            lblTreatmentInvalid.Size = new Size(13, 15);
            lblTreatmentInvalid.TabIndex = 22;
            lblTreatmentInvalid.Text = "0";
            // 
            // frmImport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 448);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lblTreatmentTotal);
            Controls.Add(lblTreatmentInvalid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPatientTotal);
            Controls.Add(lblPatientInvalid);
            Controls.Add(cmbFilterTreatment);
            Controls.Add(cmbFilterPatient);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(dgvTreatment);
            Controls.Add(dgvRecord);
            Controls.Add(btnImport);
            Name = "frmImport";
            Text = "Import";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTreatment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRecord;
        private Button btnImport;
        private OpenFileDialog openFileDialog1;
        private Button btnSave;
        private DataGridView dgvTreatment;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbFilterPatient;
        private ComboBox cmbFilterTreatment;
        private Label lblPatientTotal;
        private Label lblPatientInvalid;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblTreatmentTotal;
        private Label lblTreatmentInvalid;
    }
}
