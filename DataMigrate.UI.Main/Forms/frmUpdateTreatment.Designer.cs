namespace DataMigrate.UI.Main.Forms
{
    partial class frmUpdateTreatment
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
            label7 = new Label();
            txtSurface = new TextBox();
            label6 = new Label();
            txtItemCode = new TextBox();
            label4 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            txtTooth = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            label5 = new Label();
            numPrice = new NumericUpDown();
            numFee = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFee).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 165);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 40;
            label7.Text = "Price:";
            // 
            // txtSurface
            // 
            txtSurface.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSurface.Location = new Point(101, 128);
            txtSurface.Name = "txtSurface";
            txtSurface.Size = new Size(267, 23);
            txtSurface.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 136);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 38;
            label6.Text = "Surface:";
            // 
            // txtItemCode
            // 
            txtItemCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItemCode.Location = new Point(101, 70);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(267, 23);
            txtItemCode.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 78);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 34;
            label4.Text = "Item Code:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(293, 218);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.Location = new Point(212, 218);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 32;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.Location = new Point(101, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(267, 23);
            dtpDate.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 30;
            label3.Text = "Date:";
            // 
            // txtTooth
            // 
            txtTooth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTooth.Location = new Point(101, 99);
            txtTooth.Name = "txtTooth";
            txtTooth.Size = new Size(267, 23);
            txtTooth.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 28;
            label2.Text = "Tooth:";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(101, 41);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(267, 23);
            txtDescription.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 26;
            label1.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 42;
            label5.Text = "Free:";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 4;
            numPrice.Location = new Point(101, 157);
            numPrice.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(267, 23);
            numPrice.TabIndex = 45;
            // 
            // numFee
            // 
            numFee.DecimalPlaces = 4;
            numFee.Location = new Point(101, 186);
            numFee.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numFee.Name = "numFee";
            numFee.Size = new Size(267, 23);
            numFee.TabIndex = 46;
            // 
            // frmUpdateTreatment
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(380, 253);
            Controls.Add(numFee);
            Controls.Add(numPrice);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(txtSurface);
            Controls.Add(label6);
            Controls.Add(txtItemCode);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(txtTooth);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateTreatment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Treatment";
            Load += frmUpdateTreatment_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox txtSurface;
        private Label label6;
        private TextBox txtItemCode;
        private Label label4;
        private Button btnCancel;
        private Button btnConfirm;
        private DateTimePicker dtpDate;
        private Label label3;
        private TextBox txtTooth;
        private Label label2;
        private TextBox txtDescription;
        private Label label1;
        private Label label5;
        private NumericUpDown numPrice;
        private NumericUpDown numFee;
    }
}