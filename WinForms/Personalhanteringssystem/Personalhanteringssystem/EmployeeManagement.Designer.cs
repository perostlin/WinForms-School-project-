namespace Personalhanteringssystem
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.tcEmployeesystem = new System.Windows.Forms.TabControl();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.lbErrSaveBirthDate = new System.Windows.Forms.Label();
            this.lbErrSaveEmail = new System.Windows.Forms.Label();
            this.lbErrSaveFname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEID = new System.Windows.Forms.Label();
            this.cboxEmpDepartment = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.btnSaveEmp = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cboxOnParentalLeave = new System.Windows.Forms.CheckBox();
            this.lbEmpDepartment = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbChooseEmployee = new System.Windows.Forms.Label();
            this.lboxEmployees = new System.Windows.Forms.ListBox();
            this.tpDepartments = new System.Windows.Forms.TabPage();
            this.lbMembers = new System.Windows.Forms.Label();
            this.lboxDepEmployees = new System.Windows.Forms.ListBox();
            this.lboxDepartments = new System.Windows.Forms.ListBox();
            this.lbChooseDepartment = new System.Windows.Forms.Label();
            this.tcEmployeesystem.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            this.tpDepartments.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personalhantering";
            // 
            // tcEmployeesystem
            // 
            this.tcEmployeesystem.Controls.Add(this.tpEmployees);
            this.tcEmployeesystem.Controls.Add(this.tpDepartments);
            this.tcEmployeesystem.Location = new System.Drawing.Point(13, 79);
            this.tcEmployeesystem.Name = "tcEmployeesystem";
            this.tcEmployeesystem.SelectedIndex = 0;
            this.tcEmployeesystem.Size = new System.Drawing.Size(559, 412);
            this.tcEmployeesystem.TabIndex = 1;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Controls.Add(this.lbErrSaveBirthDate);
            this.tpEmployees.Controls.Add(this.lbErrSaveEmail);
            this.tpEmployees.Controls.Add(this.lbErrSaveFname);
            this.tpEmployees.Controls.Add(this.label2);
            this.tpEmployees.Controls.Add(this.lbEID);
            this.tpEmployees.Controls.Add(this.cboxEmpDepartment);
            this.tpEmployees.Controls.Add(this.dtpBirthDate);
            this.tpEmployees.Controls.Add(this.btnRemoveEmp);
            this.tpEmployees.Controls.Add(this.btnSaveEmp);
            this.tpEmployees.Controls.Add(this.btnAddEmployee);
            this.tpEmployees.Controls.Add(this.tbEmail);
            this.tpEmployees.Controls.Add(this.tbName);
            this.tpEmployees.Controls.Add(this.cboxOnParentalLeave);
            this.tpEmployees.Controls.Add(this.lbEmpDepartment);
            this.tpEmployees.Controls.Add(this.lbBirthDate);
            this.tpEmployees.Controls.Add(this.lbEmail);
            this.tpEmployees.Controls.Add(this.lbName);
            this.tpEmployees.Controls.Add(this.lbChooseEmployee);
            this.tpEmployees.Controls.Add(this.lboxEmployees);
            this.tpEmployees.Location = new System.Drawing.Point(4, 25);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(551, 383);
            this.tpEmployees.TabIndex = 0;
            this.tpEmployees.Text = "Anställda";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // lbErrSaveBirthDate
            // 
            this.lbErrSaveBirthDate.AutoSize = true;
            this.lbErrSaveBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrSaveBirthDate.ForeColor = System.Drawing.Color.Red;
            this.lbErrSaveBirthDate.Location = new System.Drawing.Point(252, 235);
            this.lbErrSaveBirthDate.Name = "lbErrSaveBirthDate";
            this.lbErrSaveBirthDate.Size = new System.Drawing.Size(213, 15);
            this.lbErrSaveBirthDate.TabIndex = 21;
            this.lbErrSaveBirthDate.Text = "* Anställd måste vara 1996 eller äldre!";
            this.lbErrSaveBirthDate.Visible = false;
            // 
            // lbErrSaveEmail
            // 
            this.lbErrSaveEmail.AutoSize = true;
            this.lbErrSaveEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrSaveEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrSaveEmail.Location = new System.Drawing.Point(252, 165);
            this.lbErrSaveEmail.Name = "lbErrSaveEmail";
            this.lbErrSaveEmail.Size = new System.Drawing.Size(125, 15);
            this.lbErrSaveEmail.TabIndex = 19;
            this.lbErrSaveEmail.Text = "* Något måste anges!";
            this.lbErrSaveEmail.Visible = false;
            // 
            // lbErrSaveFname
            // 
            this.lbErrSaveFname.AutoSize = true;
            this.lbErrSaveFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbErrSaveFname.ForeColor = System.Drawing.Color.Red;
            this.lbErrSaveFname.Location = new System.Drawing.Point(252, 99);
            this.lbErrSaveFname.Name = "lbErrSaveFname";
            this.lbErrSaveFname.Size = new System.Drawing.Size(125, 15);
            this.lbErrSaveFname.TabIndex = 18;
            this.lbErrSaveFname.Text = "* Något måste anges!";
            this.lbErrSaveFname.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Anställnings id:";
            // 
            // lbEID
            // 
            this.lbEID.AutoSize = true;
            this.lbEID.Location = new System.Drawing.Point(352, 27);
            this.lbEID.Name = "lbEID";
            this.lbEID.Size = new System.Drawing.Size(0, 17);
            this.lbEID.TabIndex = 16;
            // 
            // cboxEmpDepartment
            // 
            this.cboxEmpDepartment.FormattingEnabled = true;
            this.cboxEmpDepartment.Location = new System.Drawing.Point(252, 284);
            this.cboxEmpDepartment.Name = "cboxEmpDepartment";
            this.cboxEmpDepartment.Size = new System.Drawing.Size(140, 24);
            this.cboxEmpDepartment.TabIndex = 4;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(252, 210);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(280, 22);
            this.dtpBirthDate.TabIndex = 3;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveEmp.Location = new System.Drawing.Point(423, 347);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(122, 30);
            this.btnRemoveEmp.TabIndex = 7;
            this.btnRemoveEmp.Text = "Ta bort";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEmp.Location = new System.Drawing.Point(295, 347);
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.Size = new System.Drawing.Size(122, 30);
            this.btnSaveEmp.TabIndex = 6;
            this.btnSaveEmp.Text = "Spara";
            this.btnSaveEmp.UseVisualStyleBackColor = true;
            this.btnSaveEmp.Click += new System.EventHandler(this.btnSaveEmp_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 347);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(227, 30);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Skapa anställd";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(252, 140);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(280, 22);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(252, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // cboxOnParentalLeave
            // 
            this.cboxOnParentalLeave.AutoSize = true;
            this.cboxOnParentalLeave.Location = new System.Drawing.Point(415, 286);
            this.cboxOnParentalLeave.Name = "cboxOnParentalLeave";
            this.cboxOnParentalLeave.Size = new System.Drawing.Size(117, 21);
            this.cboxOnParentalLeave.TabIndex = 5;
            this.cboxOnParentalLeave.Text = "Föräldraledigt";
            this.cboxOnParentalLeave.UseVisualStyleBackColor = true;
            // 
            // lbEmpDepartment
            // 
            this.lbEmpDepartment.AutoSize = true;
            this.lbEmpDepartment.Location = new System.Drawing.Point(249, 263);
            this.lbEmpDepartment.Name = "lbEmpDepartment";
            this.lbEmpDepartment.Size = new System.Drawing.Size(74, 17);
            this.lbEmpDepartment.TabIndex = 5;
            this.lbEmpDepartment.Text = "Avdelning:";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(249, 189);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(86, 17);
            this.lbBirthDate.TabIndex = 4;
            this.lbBirthDate.Text = "Födelsedag:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(249, 119);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(249, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Namn:";
            // 
            // lbChooseEmployee
            // 
            this.lbChooseEmployee.AutoSize = true;
            this.lbChooseEmployee.Location = new System.Drawing.Point(3, 7);
            this.lbChooseEmployee.Name = "lbChooseEmployee";
            this.lbChooseEmployee.Size = new System.Drawing.Size(88, 17);
            this.lbChooseEmployee.TabIndex = 1;
            this.lbChooseEmployee.Text = "Välj anställd:";
            // 
            // lboxEmployees
            // 
            this.lboxEmployees.FormattingEnabled = true;
            this.lboxEmployees.ItemHeight = 16;
            this.lboxEmployees.Location = new System.Drawing.Point(6, 27);
            this.lboxEmployees.Name = "lboxEmployees";
            this.lboxEmployees.Size = new System.Drawing.Size(227, 292);
            this.lboxEmployees.TabIndex = 0;
            this.lboxEmployees.SelectedIndexChanged += new System.EventHandler(this.lboxEmployees_SelectedIndexChanged);
            // 
            // tpDepartments
            // 
            this.tpDepartments.Controls.Add(this.lbMembers);
            this.tpDepartments.Controls.Add(this.lboxDepEmployees);
            this.tpDepartments.Controls.Add(this.lboxDepartments);
            this.tpDepartments.Controls.Add(this.lbChooseDepartment);
            this.tpDepartments.Location = new System.Drawing.Point(4, 25);
            this.tpDepartments.Name = "tpDepartments";
            this.tpDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepartments.Size = new System.Drawing.Size(551, 383);
            this.tpDepartments.TabIndex = 1;
            this.tpDepartments.Text = "Avdelningar";
            this.tpDepartments.UseVisualStyleBackColor = true;
            // 
            // lbMembers
            // 
            this.lbMembers.AutoSize = true;
            this.lbMembers.Location = new System.Drawing.Point(247, 7);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(85, 17);
            this.lbMembers.TabIndex = 3;
            this.lbMembers.Text = "Medlemmar:";
            // 
            // lboxDepEmployees
            // 
            this.lboxDepEmployees.FormattingEnabled = true;
            this.lboxDepEmployees.ItemHeight = 16;
            this.lboxDepEmployees.Location = new System.Drawing.Point(250, 27);
            this.lboxDepEmployees.Name = "lboxDepEmployees";
            this.lboxDepEmployees.Size = new System.Drawing.Size(278, 308);
            this.lboxDepEmployees.TabIndex = 2;
            // 
            // lboxDepartments
            // 
            this.lboxDepartments.FormattingEnabled = true;
            this.lboxDepartments.ItemHeight = 16;
            this.lboxDepartments.Location = new System.Drawing.Point(6, 28);
            this.lboxDepartments.Name = "lboxDepartments";
            this.lboxDepartments.Size = new System.Drawing.Size(227, 164);
            this.lboxDepartments.TabIndex = 1;
            this.lboxDepartments.SelectedIndexChanged += new System.EventHandler(this.lboxDepartments_SelectedIndexChanged);
            // 
            // lbChooseDepartment
            // 
            this.lbChooseDepartment.AutoSize = true;
            this.lbChooseDepartment.Location = new System.Drawing.Point(3, 7);
            this.lbChooseDepartment.Name = "lbChooseDepartment";
            this.lbChooseDepartment.Size = new System.Drawing.Size(100, 17);
            this.lbChooseDepartment.TabIndex = 0;
            this.lbChooseDepartment.Text = "Välj avdelning:";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 503);
            this.Controls.Add(this.tcEmployeesystem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagement";
            this.Text = "Personalhantering 1.03";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.tcEmployeesystem.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.tpEmployees.PerformLayout();
            this.tpDepartments.ResumeLayout(false);
            this.tpDepartments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcEmployeesystem;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpDepartments;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.Button btnSaveEmp;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cboxOnParentalLeave;
        private System.Windows.Forms.Label lbEmpDepartment;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbChooseEmployee;
        private System.Windows.Forms.ListBox lboxEmployees;
        private System.Windows.Forms.Label lbMembers;
        private System.Windows.Forms.ListBox lboxDepEmployees;
        private System.Windows.Forms.ListBox lboxDepartments;
        private System.Windows.Forms.Label lbChooseDepartment;
        private System.Windows.Forms.ComboBox cboxEmpDepartment;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEID;
        private System.Windows.Forms.Label lbErrSaveFname;
        private System.Windows.Forms.Label lbErrSaveBirthDate;
        private System.Windows.Forms.Label lbErrSaveEmail;
    }
}

