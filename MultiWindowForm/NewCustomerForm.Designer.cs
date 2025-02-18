namespace MultiWindowForm
{
    partial class NewCustomerForm
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
            gbCustomer = new GroupBox();
            btnSave = new Button();
            txtPhoneNumber = new TextBox();
            lblPhoneHeading = new Label();
            textBox1 = new TextBox();
            lblEmailHeading = new Label();
            txtName = new TextBox();
            lblNameHeading = new Label();
            gbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // gbCustomer
            // 
            gbCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbCustomer.Controls.Add(btnSave);
            gbCustomer.Controls.Add(txtPhoneNumber);
            gbCustomer.Controls.Add(lblPhoneHeading);
            gbCustomer.Controls.Add(textBox1);
            gbCustomer.Controls.Add(lblEmailHeading);
            gbCustomer.Controls.Add(txtName);
            gbCustomer.Controls.Add(lblNameHeading);
            gbCustomer.Location = new Point(12, 12);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Size = new Size(454, 177);
            gbCustomer.TabIndex = 0;
            gbCustomer.TabStop = false;
            gbCustomer.Text = "New Customer";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(35, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(116, 108);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(294, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneHeading
            // 
            lblPhoneHeading.AutoSize = true;
            lblPhoneHeading.Location = new Point(22, 116);
            lblPhoneHeading.Name = "lblPhoneHeading";
            lblPhoneHeading.Size = new Size(88, 15);
            lblPhoneHeading.TabIndex = 4;
            lblPhoneHeading.Text = "Phone Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 3;
            // 
            // lblEmailHeading
            // 
            lblEmailHeading.AutoSize = true;
            lblEmailHeading.Location = new Point(22, 78);
            lblEmailHeading.Name = "lblEmailHeading";
            lblEmailHeading.Size = new Size(36, 15);
            lblEmailHeading.TabIndex = 2;
            lblEmailHeading.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 23);
            txtName.TabIndex = 1;
            // 
            // lblNameHeading
            // 
            lblNameHeading.AutoSize = true;
            lblNameHeading.Location = new Point(22, 45);
            lblNameHeading.Name = "lblNameHeading";
            lblNameHeading.Size = new Size(39, 15);
            lblNameHeading.TabIndex = 0;
            lblNameHeading.Text = "Name";
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 201);
            Controls.Add(gbCustomer);
            Name = "NewCustomerForm";
            Text = "New Customer Form";
            gbCustomer.ResumeLayout(false);
            gbCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCustomer;
        private TextBox txtName;
        private Label lblNameHeading;
        private Button btnSave;
        private TextBox txtPhoneNumber;
        private Label lblPhoneHeading;
        private TextBox textBox1;
        private Label lblEmailHeading;
    }
}