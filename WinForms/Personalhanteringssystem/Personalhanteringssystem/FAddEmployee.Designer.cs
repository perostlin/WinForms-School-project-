namespace Personalhanteringssystem
{
    partial class FAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddEmployee));
            this.lbNewEmpFName = new System.Windows.Forms.Label();
            this.lbNewEmpLName = new System.Windows.Forms.Label();
            this.lbNewEmpEmail = new System.Windows.Forms.Label();
            this.lbNewEmpBirtdate = new System.Windows.Forms.Label();
            this.lbNewEmpDepartment = new System.Windows.Forms.Label();
            this.cboxNewEmpOnParentalLeave = new System.Windows.Forms.CheckBox();
            this.tbNewEmpFName = new System.Windows.Forms.TextBox();
            this.tbNewEmpLName = new System.Windows.Forms.TextBox();
            this.tbNewEmpEmail = new System.Windows.Forms.TextBox();
            this.dtpNewEmpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cboxNewEmpDepartment = new System.Windows.Forms.ComboBox();
            this.btnSaveNewEmp = new System.Windows.Forms.Button();
            this.btnCancelNewEmp = new System.Windows.Forms.Button();
            this.lbErrFname = new System.Windows.Forms.Label();
            this.lbErrLname = new System.Windows.Forms.Label();
            this.lbErrEmail = new System.Windows.Forms.Label();
            this.lbErrDepartment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErrNewEmpDateOfBirth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNewEmpFName
            // 
            this.lbNewEmpFName.AutoSize = true;
            this.lbNewEmpFName.Location = new System.Drawing.Point(12, 9);
            this.lbNewEmpFName.Name = "lbNewEmpFName";
            this.lbNewEmpFName.Size = new System.Drawing.Size(68, 17);
            this.lbNewEmpFName.TabIndex = 0;
            this.lbNewEmpFName.Text = "Förnamn:";
            // 
            // lbNewEmpLName
            // 
            this.lbNewEmpLName.AutoSize = true;
            this.lbNewEmpLName.Location = new System.Drawing.Point(12, 88);
            this.lbNewEmpLName.Name = "lbNewEmpLName";
            this.lbNewEmpLName.Size = new System.Drawing.Size(77, 17);
            this.lbNewEmpLName.TabIndex = 1;
            this.lbNewEmpLName.Text = "Efternamn:";
            // 
            // lbNewEmpEmail
            // 
            this.lbNewEmpEmail.AutoSize = true;
            this.lbNewEmpEmail.Location = new System.Drawing.Point(12, 166);
            this.lbNewEmpEmail.Name = "lbNewEmpEmail";
            this.lbNewEmpEmail.Size = new System.Drawing.Size(46, 17);
            this.lbNewEmpEmail.TabIndex = 2;
            this.lbNewEmpEmail.Text = "Email:";
            // 
            // lbNewEmpBirtdate
            // 
            this.lbNewEmpBirtdate.AutoSize = true;
            this.lbNewEmpBirtdate.Location = new System.Drawing.Point(12, 245);
            this.lbNewEmpBirtdate.Name = "lbNewEmpBirtdate";
            this.lbNewEmpBirtdate.Size = new System.Drawing.Size(86, 17);
            this.lbNewEmpBirtdate.TabIndex = 3;
            this.lbNewEmpBirtdate.Text = "Födelsedag:";
            // 
            // lbNewEmpDepartment
            // 
            this.lbNewEmpDepartment.AutoSize = true;
            this.lbNewEmpDepartment.Location = new System.Drawing.Point(11, 319);
            this.lbNewEmpDepartment.Name = "lbNewEmpDepartment";
            this.lbNewEmpDepartment.Size = new System.Drawing.Size(74, 17);
            this.lbNewEmpDepartment.TabIndex = 4;
            this.lbNewEmpDepartment.Text = "Avdelning:";
            // 
            // cboxNewEmpOnParentalLeave
            // 
            this.cboxNewEmpOnParentalLeave.AutoSize = true;
            this.cboxNewEmpOnParentalLeave.Location = new System.Drawing.Point(12, 404);
            this.cboxNewEmpOnParentalLeave.Name = "cboxNewEmpOnParentalLeave";
            this.cboxNewEmpOnParentalLeave.Size = new System.Drawing.Size(113, 21);
            this.cboxNewEmpOnParentalLeave.TabIndex = 6;
            this.cboxNewEmpOnParentalLeave.Text = "Föräldraledig";
            this.cboxNewEmpOnParentalLeave.UseVisualStyleBackColor = true;
            // 
            // tbNewEmpFName
            // 
            this.tbNewEmpFName.Location = new System.Drawing.Point(15, 29);
            this.tbNewEmpFName.Name = "tbNewEmpFName";
            this.tbNewEmpFName.Size = new System.Drawing.Size(100, 22);
            this.tbNewEmpFName.TabIndex = 1;
            this.tbNewEmpFName.TextChanged += new System.EventHandler(this.tbNewEmpFName_TextChanged);
            // 
            // tbNewEmpLName
            // 
            this.tbNewEmpLName.Location = new System.Drawing.Point(15, 108);
            this.tbNewEmpLName.Name = "tbNewEmpLName";
            this.tbNewEmpLName.Size = new System.Drawing.Size(100, 22);
            this.tbNewEmpLName.TabIndex = 2;
            this.tbNewEmpLName.TextChanged += new System.EventHandler(this.tbNewEmpLName_TextChanged);
            // 
            // tbNewEmpEmail
            // 
            this.tbNewEmpEmail.Location = new System.Drawing.Point(15, 186);
            this.tbNewEmpEmail.Name = "tbNewEmpEmail";
            this.tbNewEmpEmail.Size = new System.Drawing.Size(100, 22);
            this.tbNewEmpEmail.TabIndex = 3;
            this.tbNewEmpEmail.TextChanged += new System.EventHandler(this.tbNewEmpEmail_TextChanged);
            // 
            // dtpNewEmpBirthdate
            // 
            this.dtpNewEmpBirthdate.Location = new System.Drawing.Point(15, 265);
            this.dtpNewEmpBirthdate.Name = "dtpNewEmpBirthdate";
            this.dtpNewEmpBirthdate.Size = new System.Drawing.Size(200, 22);
            this.dtpNewEmpBirthdate.TabIndex = 4;
            this.dtpNewEmpBirthdate.ValueChanged += new System.EventHandler(this.dtpNewEmpBirthdate_ValueChanged);
            // 
            // cboxNewEmpDepartment
            // 
            this.cboxNewEmpDepartment.FormattingEnabled = true;
            this.cboxNewEmpDepartment.Location = new System.Drawing.Point(12, 339);
            this.cboxNewEmpDepartment.Name = "cboxNewEmpDepartment";
            this.cboxNewEmpDepartment.Size = new System.Drawing.Size(121, 24);
            this.cboxNewEmpDepartment.TabIndex = 5;
            this.cboxNewEmpDepartment.Text = "Välj avdelning";
            this.cboxNewEmpDepartment.SelectedIndexChanged += new System.EventHandler(this.cboxNewEmpDepartment_SelectedIndexChanged);
            // 
            // btnSaveNewEmp
            // 
            this.btnSaveNewEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNewEmp.Location = new System.Drawing.Point(107, 468);
            this.btnSaveNewEmp.Name = "btnSaveNewEmp";
            this.btnSaveNewEmp.Size = new System.Drawing.Size(75, 40);
            this.btnSaveNewEmp.TabIndex = 7;
            this.btnSaveNewEmp.Text = "OK";
            this.btnSaveNewEmp.UseVisualStyleBackColor = true;
            this.btnSaveNewEmp.Click += new System.EventHandler(this.btnSaveNewEmp_Click);
            // 
            // btnCancelNewEmp
            // 
            this.btnCancelNewEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelNewEmp.Location = new System.Drawing.Point(188, 468);
            this.btnCancelNewEmp.Name = "btnCancelNewEmp";
            this.btnCancelNewEmp.Size = new System.Drawing.Size(75, 40);
            this.btnCancelNewEmp.TabIndex = 8;
            this.btnCancelNewEmp.Text = "Avbryt";
            this.btnCancelNewEmp.UseVisualStyleBackColor = true;
            this.btnCancelNewEmp.Click += new System.EventHandler(this.btnCancelNewEmp_Click);
            // 
            // lbErrFname
            // 
            this.lbErrFname.AutoSize = true;
            this.lbErrFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrFname.ForeColor = System.Drawing.Color.Red;
            this.lbErrFname.Location = new System.Drawing.Point(12, 54);
            this.lbErrFname.Name = "lbErrFname";
            this.lbErrFname.Size = new System.Drawing.Size(97, 15);
            this.lbErrFname.TabIndex = 13;
            this.lbErrFname.Text = "Måste vara ifylld!";
            this.lbErrFname.Visible = false;
            // 
            // lbErrLname
            // 
            this.lbErrLname.AutoSize = true;
            this.lbErrLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrLname.ForeColor = System.Drawing.Color.Red;
            this.lbErrLname.Location = new System.Drawing.Point(12, 133);
            this.lbErrLname.Name = "lbErrLname";
            this.lbErrLname.Size = new System.Drawing.Size(97, 15);
            this.lbErrLname.TabIndex = 14;
            this.lbErrLname.Text = "Måste vara ifylld!";
            this.lbErrLname.Visible = false;
            // 
            // lbErrEmail
            // 
            this.lbErrEmail.AutoSize = true;
            this.lbErrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrEmail.Location = new System.Drawing.Point(12, 211);
            this.lbErrEmail.Name = "lbErrEmail";
            this.lbErrEmail.Size = new System.Drawing.Size(97, 15);
            this.lbErrEmail.TabIndex = 15;
            this.lbErrEmail.Text = "Måste vara ifylld!";
            this.lbErrEmail.Visible = false;
            // 
            // lbErrDepartment
            // 
            this.lbErrDepartment.AutoSize = true;
            this.lbErrDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrDepartment.ForeColor = System.Drawing.Color.Red;
            this.lbErrDepartment.Location = new System.Drawing.Point(12, 366);
            this.lbErrDepartment.Name = "lbErrDepartment";
            this.lbErrDepartment.Size = new System.Drawing.Size(145, 15);
            this.lbErrDepartment.TabIndex = 16;
            this.lbErrDepartment.Text = "Måste välja en avdelning!";
            this.lbErrDepartment.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(116, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(116, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(116, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(134, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // lbErrNewEmpDateOfBirth
            // 
            this.lbErrNewEmpDateOfBirth.AutoSize = true;
            this.lbErrNewEmpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrNewEmpDateOfBirth.ForeColor = System.Drawing.Color.Red;
            this.lbErrNewEmpDateOfBirth.Location = new System.Drawing.Point(12, 290);
            this.lbErrNewEmpDateOfBirth.Name = "lbErrNewEmpDateOfBirth";
            this.lbErrNewEmpDateOfBirth.Size = new System.Drawing.Size(200, 15);
            this.lbErrNewEmpDateOfBirth.TabIndex = 22;
            this.lbErrNewEmpDateOfBirth.Text = "Måste vara mellan 1996 eller 1949!";
            this.lbErrNewEmpDateOfBirth.Visible = false;
            // 
            // FAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 520);
            this.Controls.Add(this.lbErrNewEmpDateOfBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbErrDepartment);
            this.Controls.Add(this.lbErrEmail);
            this.Controls.Add(this.lbErrLname);
            this.Controls.Add(this.lbErrFname);
            this.Controls.Add(this.btnCancelNewEmp);
            this.Controls.Add(this.btnSaveNewEmp);
            this.Controls.Add(this.cboxNewEmpDepartment);
            this.Controls.Add(this.dtpNewEmpBirthdate);
            this.Controls.Add(this.tbNewEmpEmail);
            this.Controls.Add(this.tbNewEmpLName);
            this.Controls.Add(this.tbNewEmpFName);
            this.Controls.Add(this.cboxNewEmpOnParentalLeave);
            this.Controls.Add(this.lbNewEmpDepartment);
            this.Controls.Add(this.lbNewEmpBirtdate);
            this.Controls.Add(this.lbNewEmpEmail);
            this.Controls.Add(this.lbNewEmpLName);
            this.Controls.Add(this.lbNewEmpFName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAddEmployee";
            this.Text = "Ny anställd";
            this.Load += new System.EventHandler(this.FAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNewEmpFName;
        private System.Windows.Forms.Label lbNewEmpLName;
        private System.Windows.Forms.Label lbNewEmpEmail;
        private System.Windows.Forms.Label lbNewEmpBirtdate;
        private System.Windows.Forms.Label lbNewEmpDepartment;
        private System.Windows.Forms.CheckBox cboxNewEmpOnParentalLeave;
        private System.Windows.Forms.TextBox tbNewEmpFName;
        private System.Windows.Forms.TextBox tbNewEmpLName;
        private System.Windows.Forms.TextBox tbNewEmpEmail;
        private System.Windows.Forms.DateTimePicker dtpNewEmpBirthdate;
        private System.Windows.Forms.ComboBox cboxNewEmpDepartment;
        private System.Windows.Forms.Button btnSaveNewEmp;
        private System.Windows.Forms.Button btnCancelNewEmp;
        private System.Windows.Forms.Label lbErrFname;
        private System.Windows.Forms.Label lbErrLname;
        private System.Windows.Forms.Label lbErrEmail;
        private System.Windows.Forms.Label lbErrDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbErrNewEmpDateOfBirth;
    }
}