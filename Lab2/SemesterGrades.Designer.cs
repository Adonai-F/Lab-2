
namespace Lab2
{
    partial class SemesterGrades
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
            this.components = new System.ComponentModel.Container();
            this.labelCourse1 = new System.Windows.Forms.Label();
            this.labelCourse2 = new System.Windows.Forms.Label();
            this.labelCourse3 = new System.Windows.Forms.Label();
            this.labelCourse4 = new System.Windows.Forms.Label();
            this.labelCourse5 = new System.Windows.Forms.Label();
            this.labelCourse6 = new System.Windows.Forms.Label();
            this.labelCourse7 = new System.Windows.Forms.Label();
            this.labelSemesterAverage = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxCourse1 = new System.Windows.Forms.TextBox();
            this.textBoxCourse2 = new System.Windows.Forms.TextBox();
            this.textBoxCourse7 = new System.Windows.Forms.TextBox();
            this.textBoxCourse6 = new System.Windows.Forms.TextBox();
            this.textBoxCourse5 = new System.Windows.Forms.TextBox();
            this.textBoxCourse4 = new System.Windows.Forms.TextBox();
            this.textBoxCourse3 = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.labelgrade1 = new System.Windows.Forms.Label();
            this.labelgrade2 = new System.Windows.Forms.Label();
            this.labelgrade3 = new System.Windows.Forms.Label();
            this.labelgrade4 = new System.Windows.Forms.Label();
            this.labelgrade5 = new System.Windows.Forms.Label();
            this.labelgrade6 = new System.Windows.Forms.Label();
            this.labelgrade7 = new System.Windows.Forms.Label();
            this.labelgradeSemester = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTipGrades = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelCourse1
            // 
            this.labelCourse1.AutoSize = true;
            this.labelCourse1.Location = new System.Drawing.Point(56, 49);
            this.labelCourse1.Name = "labelCourse1";
            this.labelCourse1.Size = new System.Drawing.Size(77, 20);
            this.labelCourse1.TabIndex = 1;
            this.labelCourse1.Text = "Course 1:";
            // 
            // labelCourse2
            // 
            this.labelCourse2.AutoSize = true;
            this.labelCourse2.Location = new System.Drawing.Point(56, 89);
            this.labelCourse2.Name = "labelCourse2";
            this.labelCourse2.Size = new System.Drawing.Size(77, 20);
            this.labelCourse2.TabIndex = 3;
            this.labelCourse2.Text = "Course 2:";
            // 
            // labelCourse3
            // 
            this.labelCourse3.AutoSize = true;
            this.labelCourse3.Location = new System.Drawing.Point(56, 132);
            this.labelCourse3.Name = "labelCourse3";
            this.labelCourse3.Size = new System.Drawing.Size(77, 20);
            this.labelCourse3.TabIndex = 6;
            this.labelCourse3.Text = "Course 3:";
            // 
            // labelCourse4
            // 
            this.labelCourse4.AutoSize = true;
            this.labelCourse4.Location = new System.Drawing.Point(56, 173);
            this.labelCourse4.Name = "labelCourse4";
            this.labelCourse4.Size = new System.Drawing.Size(77, 20);
            this.labelCourse4.TabIndex = 9;
            this.labelCourse4.Text = "Course 4:";
            // 
            // labelCourse5
            // 
            this.labelCourse5.AutoSize = true;
            this.labelCourse5.Location = new System.Drawing.Point(56, 217);
            this.labelCourse5.Name = "labelCourse5";
            this.labelCourse5.Size = new System.Drawing.Size(77, 20);
            this.labelCourse5.TabIndex = 12;
            this.labelCourse5.Text = "Course 5:";
            // 
            // labelCourse6
            // 
            this.labelCourse6.AutoSize = true;
            this.labelCourse6.Location = new System.Drawing.Point(56, 261);
            this.labelCourse6.Name = "labelCourse6";
            this.labelCourse6.Size = new System.Drawing.Size(77, 20);
            this.labelCourse6.TabIndex = 15;
            this.labelCourse6.Text = "Course 6:";
            // 
            // labelCourse7
            // 
            this.labelCourse7.AutoSize = true;
            this.labelCourse7.Location = new System.Drawing.Point(56, 307);
            this.labelCourse7.Name = "labelCourse7";
            this.labelCourse7.Size = new System.Drawing.Size(77, 20);
            this.labelCourse7.TabIndex = 18;
            this.labelCourse7.Text = "Course 7:";
            // 
            // labelSemesterAverage
            // 
            this.labelSemesterAverage.AutoSize = true;
            this.labelSemesterAverage.Location = new System.Drawing.Point(56, 356);
            this.labelSemesterAverage.Name = "labelSemesterAverage";
            this.labelSemesterAverage.Size = new System.Drawing.Size(82, 20);
            this.labelSemesterAverage.TabIndex = 21;
            this.labelSemesterAverage.Text = "Semester:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(40, 399);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(574, 113);
            this.textBoxOutput.TabIndex = 24;
            // 
            // textBoxCourse1
            // 
            this.textBoxCourse1.Location = new System.Drawing.Point(169, 43);
            this.textBoxCourse1.Name = "textBoxCourse1";
            this.textBoxCourse1.Size = new System.Drawing.Size(153, 26);
            this.textBoxCourse1.TabIndex = 1;
            this.toolTipGrades.SetToolTip(this.textBoxCourse1, "Enter Grade for the First Course");
            this.textBoxCourse1.Leave += new System.EventHandler(this.LeaveTextbox);
            // 
            // textBoxCourse2
            // 
            this.textBoxCourse2.Location = new System.Drawing.Point(169, 83);
            this.textBoxCourse2.Name = "textBoxCourse2";
            this.textBoxCourse2.Size = new System.Drawing.Size(153, 26);
            this.textBoxCourse2.TabIndex = 4;
            this.toolTipGrades.SetToolTip(this.textBoxCourse2, "Enter Grade for the Second Course");
            this.textBoxCourse2.Leave += new System.EventHandler(this.LeaveTextbox);
            // 
            // textBoxCourse7
            // 
            this.textBoxCourse7.Location = new System.Drawing.Point(169, 301);
            this.textBoxCourse7.Name = "textBoxCourse7";
            this.textBoxCourse7.Size = new System.Drawing.Size(153, 26);
            this.textBoxCourse7.TabIndex = 19;
            this.toolTipGrades.SetToolTip(this.textBoxCourse7, "Enter Grade for the Seventh Course");
            this.textBoxCourse7.Leave += new System.EventHandler(this.LeaveTextbox);
            // 
            // textBoxCourse6
            // 
            this.textBoxCourse6.Location = new System.Drawing.Point(169, 255);
            this.textBoxCourse6.Name = "textBoxCourse6";
            this.textBoxCourse6.Size = new System.Drawing.Size(153, 26);
            this.textBoxCourse6.TabIndex = 16;
            this.toolTipGrades.SetToolTip(this.textBoxCourse6, "Enter Grade for the Sixth Course");
            this.textBoxCourse6.Leave += new System.EventHandler(this.LeaveTextbox);
            // 
            // textBoxCourse5
            // 
            this.textBoxCourse5.Location = new System.Drawing.Point(169, 211);
            this.textBoxCourse5.Name = "textBoxCourse5";
            this.textBoxCourse5.Size = new System.Drawing.Size(153, 26);
            this.textBoxCourse5.TabIndex = 13;
            this.toolTipGrades.SetToolTip(this.textBoxCourse5, "Enter Grade for the Fifth Course");
            this.textBoxCourse5.Leave += new System.EventHandler(this.LeaveTextbox);
            // 
            // textBoxCourse4
            // 
            this.textBoxCourse4.Location = new System.Drawing.Point(169, 167);
            this.textBoxCourse4.Name = "textBoxCourse4";
            this.textBoxCourse4.Size = new System.Drawing.Size(153, 26);
            this.textBoxCourse4.TabIndex = 10;
            this.toolTipGrades.SetToolTip(this.textBoxCourse4, "Enter Grade for the Fourth Course");
            this.textBoxCourse4.Leave += new System.EventHandler(this.LeaveTextbox);
            // 
            // textBoxCourse3
            // 
            this.textBoxCourse3.Location = new System.Drawing.Point(169, 126);
            this.textBoxCourse3.Name = "textBoxCourse3";
            this.textBoxCourse3.Size = new System.Drawing.Size(153, 26);
            this.textBoxCourse3.TabIndex = 7;
            this.toolTipGrades.SetToolTip(this.textBoxCourse3, "Enter Grade for the Third Course");
            this.textBoxCourse3.Leave += new System.EventHandler(this.LeaveTextbox);
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(169, 350);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.ReadOnly = true;
            this.textBoxSemester.Size = new System.Drawing.Size(153, 26);
            this.textBoxSemester.TabIndex = 22;
            this.toolTipGrades.SetToolTip(this.textBoxSemester, "The Average of all grades entered");
            // 
            // labelgrade1
            // 
            this.labelgrade1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgrade1.Location = new System.Drawing.Point(429, 45);
            this.labelgrade1.Name = "labelgrade1";
            this.labelgrade1.Size = new System.Drawing.Size(128, 23);
            this.labelgrade1.TabIndex = 2;
            // 
            // labelgrade2
            // 
            this.labelgrade2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgrade2.Location = new System.Drawing.Point(429, 89);
            this.labelgrade2.Name = "labelgrade2";
            this.labelgrade2.Size = new System.Drawing.Size(128, 20);
            this.labelgrade2.TabIndex = 5;
            // 
            // labelgrade3
            // 
            this.labelgrade3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgrade3.Location = new System.Drawing.Point(429, 132);
            this.labelgrade3.Name = "labelgrade3";
            this.labelgrade3.Size = new System.Drawing.Size(128, 20);
            this.labelgrade3.TabIndex = 8;
            // 
            // labelgrade4
            // 
            this.labelgrade4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgrade4.Location = new System.Drawing.Point(429, 173);
            this.labelgrade4.Name = "labelgrade4";
            this.labelgrade4.Size = new System.Drawing.Size(128, 20);
            this.labelgrade4.TabIndex = 11;
            // 
            // labelgrade5
            // 
            this.labelgrade5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgrade5.Location = new System.Drawing.Point(429, 217);
            this.labelgrade5.Name = "labelgrade5";
            this.labelgrade5.Size = new System.Drawing.Size(128, 20);
            this.labelgrade5.TabIndex = 14;
            // 
            // labelgrade6
            // 
            this.labelgrade6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgrade6.Location = new System.Drawing.Point(429, 261);
            this.labelgrade6.Name = "labelgrade6";
            this.labelgrade6.Size = new System.Drawing.Size(128, 20);
            this.labelgrade6.TabIndex = 17;
            // 
            // labelgrade7
            // 
            this.labelgrade7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgrade7.Location = new System.Drawing.Point(429, 308);
            this.labelgrade7.Name = "labelgrade7";
            this.labelgrade7.Size = new System.Drawing.Size(128, 20);
            this.labelgrade7.TabIndex = 20;
            // 
            // labelgradeSemester
            // 
            this.labelgradeSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelgradeSemester.Location = new System.Drawing.Point(429, 350);
            this.labelgradeSemester.Name = "labelgradeSemester";
            this.labelgradeSemester.Size = new System.Drawing.Size(128, 20);
            this.labelgradeSemester.TabIndex = 23;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(40, 527);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(112, 40);
            this.buttonCalculate.TabIndex = 25;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(262, 527);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 40);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(479, 527);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 40);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // SemesterGrades
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(655, 588);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelgradeSemester);
            this.Controls.Add(this.labelgrade7);
            this.Controls.Add(this.labelgrade6);
            this.Controls.Add(this.labelgrade5);
            this.Controls.Add(this.labelgrade4);
            this.Controls.Add(this.labelgrade3);
            this.Controls.Add(this.labelgrade2);
            this.Controls.Add(this.labelgrade1);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.textBoxCourse3);
            this.Controls.Add(this.textBoxCourse4);
            this.Controls.Add(this.textBoxCourse5);
            this.Controls.Add(this.textBoxCourse6);
            this.Controls.Add(this.textBoxCourse7);
            this.Controls.Add(this.textBoxCourse2);
            this.Controls.Add(this.textBoxCourse1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelSemesterAverage);
            this.Controls.Add(this.labelCourse7);
            this.Controls.Add(this.labelCourse6);
            this.Controls.Add(this.labelCourse5);
            this.Controls.Add(this.labelCourse4);
            this.Controls.Add(this.labelCourse3);
            this.Controls.Add(this.labelCourse2);
            this.Controls.Add(this.labelCourse1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "SemesterGrades";
            this.Text = "Semester Grades";
            this.Load += new System.EventHandler(this.SemesterGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourse1;
        private System.Windows.Forms.Label labelCourse2;
        private System.Windows.Forms.Label labelCourse3;
        private System.Windows.Forms.Label labelCourse4;
        private System.Windows.Forms.Label labelCourse5;
        private System.Windows.Forms.Label labelCourse6;
        private System.Windows.Forms.Label labelCourse7;
        private System.Windows.Forms.Label labelSemesterAverage;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxCourse1;
        private System.Windows.Forms.TextBox textBoxCourse2;
        private System.Windows.Forms.TextBox textBoxCourse7;
        private System.Windows.Forms.TextBox textBoxCourse6;
        private System.Windows.Forms.TextBox textBoxCourse5;
        private System.Windows.Forms.TextBox textBoxCourse4;
        private System.Windows.Forms.TextBox textBoxCourse3;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.Label labelgrade1;
        private System.Windows.Forms.Label labelgrade2;
        private System.Windows.Forms.Label labelgrade3;
        private System.Windows.Forms.Label labelgrade4;
        private System.Windows.Forms.Label labelgrade5;
        private System.Windows.Forms.Label labelgrade6;
        private System.Windows.Forms.Label labelgrade7;
        private System.Windows.Forms.Label labelgradeSemester;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTipGrades;
    }
}

