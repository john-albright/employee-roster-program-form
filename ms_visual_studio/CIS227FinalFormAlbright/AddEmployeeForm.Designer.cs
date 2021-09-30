
namespace CIS227FinalFormAlbright
{
    partial class AddEmployeeForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.listBoxGender = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBoxHireDate = new System.Windows.Forms.GroupBox();
            this.comboBoxHireDateYear = new System.Windows.Forms.ComboBox();
            this.lblHireDateYear = new System.Windows.Forms.Label();
            this.comboBoxHireDateDay = new System.Windows.Forms.ComboBox();
            this.lblHireDateDay = new System.Windows.Forms.Label();
            this.lblHireDateMonth = new System.Windows.Forms.Label();
            this.comboBoxHireDateMonth = new System.Windows.Forms.ComboBox();
            this.groupBoxBirthDate = new System.Windows.Forms.GroupBox();
            this.comboBoxBirthDateYear = new System.Windows.Forms.ComboBox();
            this.lblBirthDateYear = new System.Windows.Forms.Label();
            this.comboBoxBirthDateDay = new System.Windows.Forms.ComboBox();
            this.lblBirthDateDay = new System.Windows.Forms.Label();
            this.lblBirthDateMonth = new System.Windows.Forms.Label();
            this.comboBoxBirthDateMonth = new System.Windows.Forms.ComboBox();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxJobs = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxHireDate.SuspendLayout();
            this.groupBoxBirthDate.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 21);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(24, 82);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 21);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(49, 140);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 21);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // listBoxGender
            // 
            this.listBoxGender.FormattingEnabled = true;
            this.listBoxGender.ItemHeight = 21;
            this.listBoxGender.Location = new System.Drawing.Point(117, 137);
            this.listBoxGender.Name = "listBoxGender";
            this.listBoxGender.Size = new System.Drawing.Size(50, 46);
            this.listBoxGender.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(117, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(119, 29);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(117, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 29);
            this.txtLastName.TabIndex = 5;
            // 
            // groupBoxHireDate
            // 
            this.groupBoxHireDate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBoxHireDate.Controls.Add(this.comboBoxHireDateYear);
            this.groupBoxHireDate.Controls.Add(this.lblHireDateYear);
            this.groupBoxHireDate.Controls.Add(this.comboBoxHireDateDay);
            this.groupBoxHireDate.Controls.Add(this.lblHireDateDay);
            this.groupBoxHireDate.Controls.Add(this.lblHireDateMonth);
            this.groupBoxHireDate.Controls.Add(this.comboBoxHireDateMonth);
            this.groupBoxHireDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxHireDate.Location = new System.Drawing.Point(386, 70);
            this.groupBoxHireDate.Name = "groupBoxHireDate";
            this.groupBoxHireDate.Size = new System.Drawing.Size(380, 127);
            this.groupBoxHireDate.TabIndex = 6;
            this.groupBoxHireDate.TabStop = false;
            this.groupBoxHireDate.Text = "Hire Date";
            // 
            // comboBoxHireDateYear
            // 
            this.comboBoxHireDateYear.FormattingEnabled = true;
            this.comboBoxHireDateYear.Location = new System.Drawing.Point(283, 26);
            this.comboBoxHireDateYear.Name = "comboBoxHireDateYear";
            this.comboBoxHireDateYear.Size = new System.Drawing.Size(79, 29);
            this.comboBoxHireDateYear.TabIndex = 5;
            // 
            // lblHireDateYear
            // 
            this.lblHireDateYear.AutoSize = true;
            this.lblHireDateYear.Location = new System.Drawing.Point(239, 29);
            this.lblHireDateYear.Name = "lblHireDateYear";
            this.lblHireDateYear.Size = new System.Drawing.Size(43, 21);
            this.lblHireDateYear.TabIndex = 4;
            this.lblHireDateYear.Text = "Year:";
            // 
            // comboBoxHireDateDay
            // 
            this.comboBoxHireDateDay.FormattingEnabled = true;
            this.comboBoxHireDateDay.Location = new System.Drawing.Point(181, 26);
            this.comboBoxHireDateDay.Name = "comboBoxHireDateDay";
            this.comboBoxHireDateDay.Size = new System.Drawing.Size(46, 29);
            this.comboBoxHireDateDay.TabIndex = 3;
            // 
            // lblHireDateDay
            // 
            this.lblHireDateDay.AutoSize = true;
            this.lblHireDateDay.Location = new System.Drawing.Point(141, 29);
            this.lblHireDateDay.Name = "lblHireDateDay";
            this.lblHireDateDay.Size = new System.Drawing.Size(40, 21);
            this.lblHireDateDay.TabIndex = 2;
            this.lblHireDateDay.Text = "Day:";
            // 
            // lblHireDateMonth
            // 
            this.lblHireDateMonth.AutoSize = true;
            this.lblHireDateMonth.Location = new System.Drawing.Point(18, 29);
            this.lblHireDateMonth.Name = "lblHireDateMonth";
            this.lblHireDateMonth.Size = new System.Drawing.Size(59, 21);
            this.lblHireDateMonth.TabIndex = 1;
            this.lblHireDateMonth.Text = "Month:";
            // 
            // comboBoxHireDateMonth
            // 
            this.comboBoxHireDateMonth.FormattingEnabled = true;
            this.comboBoxHireDateMonth.Location = new System.Drawing.Point(82, 26);
            this.comboBoxHireDateMonth.Name = "comboBoxHireDateMonth";
            this.comboBoxHireDateMonth.Size = new System.Drawing.Size(44, 29);
            this.comboBoxHireDateMonth.TabIndex = 0;
            // 
            // groupBoxBirthDate
            // 
            this.groupBoxBirthDate.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBoxBirthDate.Controls.Add(this.comboBoxBirthDateYear);
            this.groupBoxBirthDate.Controls.Add(this.lblBirthDateYear);
            this.groupBoxBirthDate.Controls.Add(this.comboBoxBirthDateDay);
            this.groupBoxBirthDate.Controls.Add(this.lblBirthDateDay);
            this.groupBoxBirthDate.Controls.Add(this.lblBirthDateMonth);
            this.groupBoxBirthDate.Controls.Add(this.comboBoxBirthDateMonth);
            this.groupBoxBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBirthDate.Location = new System.Drawing.Point(386, 227);
            this.groupBoxBirthDate.Name = "groupBoxBirthDate";
            this.groupBoxBirthDate.Size = new System.Drawing.Size(380, 123);
            this.groupBoxBirthDate.TabIndex = 7;
            this.groupBoxBirthDate.TabStop = false;
            this.groupBoxBirthDate.Text = "Birth Date";
            // 
            // comboBoxBirthDateYear
            // 
            this.comboBoxBirthDateYear.FormattingEnabled = true;
            this.comboBoxBirthDateYear.Location = new System.Drawing.Point(284, 29);
            this.comboBoxBirthDateYear.Name = "comboBoxBirthDateYear";
            this.comboBoxBirthDateYear.Size = new System.Drawing.Size(78, 29);
            this.comboBoxBirthDateYear.TabIndex = 11;
            // 
            // lblBirthDateYear
            // 
            this.lblBirthDateYear.AutoSize = true;
            this.lblBirthDateYear.Location = new System.Drawing.Point(240, 32);
            this.lblBirthDateYear.Name = "lblBirthDateYear";
            this.lblBirthDateYear.Size = new System.Drawing.Size(43, 21);
            this.lblBirthDateYear.TabIndex = 10;
            this.lblBirthDateYear.Text = "Year:";
            // 
            // comboBoxBirthDateDay
            // 
            this.comboBoxBirthDateDay.FormattingEnabled = true;
            this.comboBoxBirthDateDay.Location = new System.Drawing.Point(182, 29);
            this.comboBoxBirthDateDay.Name = "comboBoxBirthDateDay";
            this.comboBoxBirthDateDay.Size = new System.Drawing.Size(46, 29);
            this.comboBoxBirthDateDay.TabIndex = 9;
            // 
            // lblBirthDateDay
            // 
            this.lblBirthDateDay.AutoSize = true;
            this.lblBirthDateDay.Location = new System.Drawing.Point(142, 32);
            this.lblBirthDateDay.Name = "lblBirthDateDay";
            this.lblBirthDateDay.Size = new System.Drawing.Size(40, 21);
            this.lblBirthDateDay.TabIndex = 8;
            this.lblBirthDateDay.Text = "Day:";
            // 
            // lblBirthDateMonth
            // 
            this.lblBirthDateMonth.AutoSize = true;
            this.lblBirthDateMonth.Location = new System.Drawing.Point(19, 32);
            this.lblBirthDateMonth.Name = "lblBirthDateMonth";
            this.lblBirthDateMonth.Size = new System.Drawing.Size(59, 21);
            this.lblBirthDateMonth.TabIndex = 7;
            this.lblBirthDateMonth.Text = "Month:";
            // 
            // comboBoxBirthDateMonth
            // 
            this.comboBoxBirthDateMonth.FormattingEnabled = true;
            this.comboBoxBirthDateMonth.Location = new System.Drawing.Point(83, 29);
            this.comboBoxBirthDateMonth.Name = "comboBoxBirthDateMonth";
            this.comboBoxBirthDateMonth.Size = new System.Drawing.Size(44, 29);
            this.comboBoxBirthDateMonth.TabIndex = 6;
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBoxGeneral.Controls.Add(this.txtHourlyRate);
            this.groupBoxGeneral.Controls.Add(this.label1);
            this.groupBoxGeneral.Controls.Add(this.comboBoxJobs);
            this.groupBoxGeneral.Controls.Add(this.lblJob);
            this.groupBoxGeneral.Controls.Add(this.lblFirstName);
            this.groupBoxGeneral.Controls.Add(this.lblLastName);
            this.groupBoxGeneral.Controls.Add(this.lblGender);
            this.groupBoxGeneral.Controls.Add(this.txtLastName);
            this.groupBoxGeneral.Controls.Add(this.listBoxGender);
            this.groupBoxGeneral.Controls.Add(this.txtFirstName);
            this.groupBoxGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxGeneral.Location = new System.Drawing.Point(85, 70);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(273, 338);
            this.groupBoxGeneral.TabIndex = 8;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(117, 263);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(119, 29);
            this.txtHourlyRate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hourly Rate: ";
            // 
            // comboBoxJobs
            // 
            this.comboBoxJobs.FormattingEnabled = true;
            this.comboBoxJobs.Location = new System.Drawing.Point(117, 210);
            this.comboBoxJobs.Name = "comboBoxJobs";
            this.comboBoxJobs.Size = new System.Drawing.Size(119, 29);
            this.comboBoxJobs.TabIndex = 7;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(74, 210);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(37, 21);
            this.lblJob.TabIndex = 6;
            this.lblJob.Text = "Job:";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Olive;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddEmployee.Location = new System.Drawing.Point(582, 370);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(184, 38);
            this.btnAddEmployee.TabIndex = 9;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.Location = new System.Drawing.Point(279, 18);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(276, 30);
            this.lblTitle2.TabIndex = 10;
            this.lblTitle2.Text = "New Employee Information";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Olive;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(392, 370);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupBoxBirthDate);
            this.Controls.Add(this.groupBoxHireDate);
            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee Form - Programmer: John Albright";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.groupBoxHireDate.ResumeLayout(false);
            this.groupBoxHireDate.PerformLayout();
            this.groupBoxBirthDate.ResumeLayout(false);
            this.groupBoxBirthDate.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ListBox listBoxGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBoxHireDate;
        private System.Windows.Forms.ComboBox comboBoxHireDateYear;
        private System.Windows.Forms.Label lblHireDateYear;
        private System.Windows.Forms.ComboBox comboBoxHireDateDay;
        private System.Windows.Forms.Label lblHireDateDay;
        private System.Windows.Forms.Label lblHireDateMonth;
        private System.Windows.Forms.ComboBox comboBoxHireDateMonth;
        private System.Windows.Forms.GroupBox groupBoxBirthDate;
        private System.Windows.Forms.ComboBox comboBoxBirthDateYear;
        private System.Windows.Forms.Label lblBirthDateYear;
        private System.Windows.Forms.ComboBox comboBoxBirthDateDay;
        private System.Windows.Forms.Label lblBirthDateDay;
        private System.Windows.Forms.Label lblBirthDateMonth;
        private System.Windows.Forms.ComboBox comboBoxBirthDateMonth;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox comboBoxJobs;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Button btnReset;
    }
}