namespace FormQuestions
{
    partial class Form1
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.FirstNameTxtB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaleRBtn = new System.Windows.Forms.RadioButton();
            this.FemaleRBtn = new System.Windows.Forms.RadioButton();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TitleTxtB = new System.Windows.Forms.TextBox();
            this.CompanyNameTxtB = new System.Windows.Forms.TextBox();
            this.CompanyLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FrenchChBox = new System.Windows.Forms.CheckBox();
            this.TurkishChBox = new System.Windows.Forms.CheckBox();
            this.RussianChBox = new System.Windows.Forms.CheckBox();
            this.EnglishChBox = new System.Windows.Forms.CheckBox();
            this.LastNameTxtB = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EmailTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IndustryTxtB = new System.Windows.Forms.TextBox();
            this.IndustryLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.DepartmentTxtB = new System.Windows.Forms.TextBox();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.Savebtn1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.Location = new System.Drawing.Point(34, 43);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 17);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name";
            // 
            // FirstNameTxtB
            // 
            this.FirstNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstNameTxtB.ForeColor = System.Drawing.Color.Gray;
            this.FirstNameTxtB.Location = new System.Drawing.Point(37, 62);
            this.FirstNameTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTxtB.Multiline = true;
            this.FirstNameTxtB.Name = "FirstNameTxtB";
            this.FirstNameTxtB.Size = new System.Drawing.Size(184, 24);
            this.FirstNameTxtB.TabIndex = 5;
            this.FirstNameTxtB.Text = "First Name";
            this.FirstNameTxtB.MouseEnter += new System.EventHandler(this.FirstNameTxtB_MouseEnter);
            this.FirstNameTxtB.MouseLeave += new System.EventHandler(this.FirstNameTxtB_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaleRBtn);
            this.groupBox1.Controls.Add(this.FemaleRBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(37, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 104);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // MaleRBtn
            // 
            this.MaleRBtn.AutoSize = true;
            this.MaleRBtn.Location = new System.Drawing.Point(10, 43);
            this.MaleRBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MaleRBtn.Name = "MaleRBtn";
            this.MaleRBtn.Size = new System.Drawing.Size(56, 21);
            this.MaleRBtn.TabIndex = 19;
            this.MaleRBtn.TabStop = true;
            this.MaleRBtn.Text = "Male";
            this.MaleRBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleRBtn
            // 
            this.FemaleRBtn.AutoSize = true;
            this.FemaleRBtn.Location = new System.Drawing.Point(96, 43);
            this.FemaleRBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleRBtn.Name = "FemaleRBtn";
            this.FemaleRBtn.Size = new System.Drawing.Size(72, 21);
            this.FemaleRBtn.TabIndex = 20;
            this.FemaleRBtn.TabStop = true;
            this.FemaleRBtn.Text = "Female";
            this.FemaleRBtn.UseVisualStyleBackColor = true;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleLbl.Location = new System.Drawing.Point(36, 224);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(76, 17);
            this.TitleLbl.TabIndex = 20;
            this.TitleLbl.Text = "Speaciality";
            // 
            // TitleTxtB
            // 
            this.TitleTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TitleTxtB.Location = new System.Drawing.Point(35, 243);
            this.TitleTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.TitleTxtB.Multiline = true;
            this.TitleTxtB.Name = "TitleTxtB";
            this.TitleTxtB.Size = new System.Drawing.Size(184, 24);
            this.TitleTxtB.TabIndex = 21;
            // 
            // CompanyNameTxtB
            // 
            this.CompanyNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyNameTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CompanyNameTxtB.Location = new System.Drawing.Point(35, 306);
            this.CompanyNameTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyNameTxtB.Multiline = true;
            this.CompanyNameTxtB.Name = "CompanyNameTxtB";
            this.CompanyNameTxtB.Size = new System.Drawing.Size(184, 24);
            this.CompanyNameTxtB.TabIndex = 22;
            // 
            // CompanyLbl
            // 
            this.CompanyLbl.AutoSize = true;
            this.CompanyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyLbl.Location = new System.Drawing.Point(34, 287);
            this.CompanyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyLbl.Name = "CompanyLbl";
            this.CompanyLbl.Size = new System.Drawing.Size(108, 17);
            this.CompanyLbl.TabIndex = 23;
            this.CompanyLbl.Text = "Company Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FrenchChBox);
            this.groupBox2.Controls.Add(this.TurkishChBox);
            this.groupBox2.Controls.Add(this.RussianChBox);
            this.groupBox2.Controls.Add(this.EnglishChBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(35, 351);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(452, 66);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Languages";
            // 
            // FrenchChBox
            // 
            this.FrenchChBox.AutoSize = true;
            this.FrenchChBox.Location = new System.Drawing.Point(339, 30);
            this.FrenchChBox.Margin = new System.Windows.Forms.Padding(2);
            this.FrenchChBox.Name = "FrenchChBox";
            this.FrenchChBox.Size = new System.Drawing.Size(63, 21);
            this.FrenchChBox.TabIndex = 3;
            this.FrenchChBox.Text = "China";
            this.FrenchChBox.UseVisualStyleBackColor = true;
            // 
            // TurkishChBox
            // 
            this.TurkishChBox.AutoSize = true;
            this.TurkishChBox.Location = new System.Drawing.Point(226, 30);
            this.TurkishChBox.Margin = new System.Windows.Forms.Padding(2);
            this.TurkishChBox.Name = "TurkishChBox";
            this.TurkishChBox.Size = new System.Drawing.Size(74, 21);
            this.TurkishChBox.TabIndex = 2;
            this.TurkishChBox.Text = "Turkish";
            this.TurkishChBox.UseVisualStyleBackColor = true;
            // 
            // RussianChBox
            // 
            this.RussianChBox.AutoSize = true;
            this.RussianChBox.Location = new System.Drawing.Point(108, 30);
            this.RussianChBox.Margin = new System.Windows.Forms.Padding(2);
            this.RussianChBox.Name = "RussianChBox";
            this.RussianChBox.Size = new System.Drawing.Size(78, 21);
            this.RussianChBox.TabIndex = 1;
            this.RussianChBox.Text = "Russian";
            this.RussianChBox.UseVisualStyleBackColor = true;
            // 
            // EnglishChBox
            // 
            this.EnglishChBox.AutoSize = true;
            this.EnglishChBox.Location = new System.Drawing.Point(12, 30);
            this.EnglishChBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnglishChBox.Name = "EnglishChBox";
            this.EnglishChBox.Size = new System.Drawing.Size(73, 21);
            this.EnglishChBox.TabIndex = 0;
            this.EnglishChBox.Text = "English";
            this.EnglishChBox.UseVisualStyleBackColor = true;
            // 
            // LastNameTxtB
            // 
            this.LastNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastNameTxtB.ForeColor = System.Drawing.Color.Gray;
            this.LastNameTxtB.Location = new System.Drawing.Point(261, 62);
            this.LastNameTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTxtB.Multiline = true;
            this.LastNameTxtB.Name = "LastNameTxtB";
            this.LastNameTxtB.Size = new System.Drawing.Size(224, 24);
            this.LastNameTxtB.TabIndex = 25;
            this.LastNameTxtB.Text = "Last Name";
            this.LastNameTxtB.MouseEnter += new System.EventHandler(this.LastNameTxtB_MouseEnter);
            this.LastNameTxtB.MouseLeave += new System.EventHandler(this.LastNameTxtB_MouseLeave);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailLbl.Location = new System.Drawing.Point(258, 107);
            this.EmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(42, 17);
            this.EmailLbl.TabIndex = 26;
            this.EmailLbl.Text = "Email";
            // 
            // EmailTxtB
            // 
            this.EmailTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailTxtB.ForeColor = System.Drawing.Color.Gray;
            this.EmailTxtB.Location = new System.Drawing.Point(259, 126);
            this.EmailTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTxtB.Multiline = true;
            this.EmailTxtB.Name = "EmailTxtB";
            this.EmailTxtB.Size = new System.Drawing.Size(226, 21);
            this.EmailTxtB.TabIndex = 27;
            this.EmailTxtB.Text = "example@gmail.com";
            this.EmailTxtB.MouseEnter += new System.EventHandler(this.EmailTxtB_MouseEnter);
            this.EmailTxtB.MouseLeave += new System.EventHandler(this.EmailTxtB_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Phone Number";
            // 
            // IndustryTxtB
            // 
            this.IndustryTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IndustryTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IndustryTxtB.Location = new System.Drawing.Point(261, 306);
            this.IndustryTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.IndustryTxtB.Multiline = true;
            this.IndustryTxtB.Name = "IndustryTxtB";
            this.IndustryTxtB.Size = new System.Drawing.Size(224, 24);
            this.IndustryTxtB.TabIndex = 30;
            // 
            // IndustryLbl
            // 
            this.IndustryLbl.AutoSize = true;
            this.IndustryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IndustryLbl.Location = new System.Drawing.Point(260, 287);
            this.IndustryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IndustryLbl.Name = "IndustryLbl";
            this.IndustryLbl.Size = new System.Drawing.Size(58, 17);
            this.IndustryLbl.TabIndex = 31;
            this.IndustryLbl.Text = "Industry";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.Location = new System.Drawing.Point(35, 522);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(443, 37);
            this.SaveBtn.TabIndex = 32;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(260, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Surname";
            // 
            // PhoneNumberMaskBox
            // 
            this.PhoneNumberMaskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneNumberMaskBox.Location = new System.Drawing.Point(259, 188);
            this.PhoneNumberMaskBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumberMaskBox.Mask = "(+000) 00-0000000";
            this.PhoneNumberMaskBox.Name = "PhoneNumberMaskBox";
            this.PhoneNumberMaskBox.Size = new System.Drawing.Size(225, 23);
            this.PhoneNumberMaskBox.TabIndex = 34;
            // 
            // DepartmentTxtB
            // 
            this.DepartmentTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DepartmentTxtB.Location = new System.Drawing.Point(259, 243);
            this.DepartmentTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.DepartmentTxtB.Multiline = true;
            this.DepartmentTxtB.Name = "DepartmentTxtB";
            this.DepartmentTxtB.Size = new System.Drawing.Size(224, 24);
            this.DepartmentTxtB.TabIndex = 35;
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentLbl.Location = new System.Drawing.Point(258, 224);
            this.DepartmentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(82, 17);
            this.DepartmentLbl.TabIndex = 36;
            this.DepartmentLbl.Text = "Department";
            // 
            // Savebtn1
            // 
            this.Savebtn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Savebtn1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Savebtn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Savebtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Savebtn1.ForeColor = System.Drawing.SystemColors.Control;
            this.Savebtn1.Location = new System.Drawing.Point(35, 421);
            this.Savebtn1.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn1.Name = "Savebtn1";
            this.Savebtn1.Size = new System.Drawing.Size(452, 37);
            this.Savebtn1.TabIndex = 37;
            this.Savebtn1.Text = "Save";
            this.Savebtn1.UseVisualStyleBackColor = false;
            this.Savebtn1.Click += new System.EventHandler(this.Savebtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(497, 490);
            this.Controls.Add(this.Savebtn1);
            this.Controls.Add(this.DepartmentLbl);
            this.Controls.Add(this.DepartmentTxtB);
            this.Controls.Add(this.PhoneNumberMaskBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.IndustryLbl);
            this.Controls.Add(this.IndustryTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTxtB);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.LastNameTxtB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CompanyLbl);
            this.Controls.Add(this.CompanyNameTxtB);
            this.Controls.Add(this.TitleTxtB);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FirstNameTxtB);
            this.Controls.Add(this.NameLbl);
            this.Name = "Form1";
            this.Text = "Fill the form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox FirstNameTxtB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MaleRBtn;
        private System.Windows.Forms.RadioButton FemaleRBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox TitleTxtB;
        private System.Windows.Forms.TextBox CompanyNameTxtB;
        private System.Windows.Forms.Label CompanyLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox FrenchChBox;
        private System.Windows.Forms.CheckBox TurkishChBox;
        private System.Windows.Forms.CheckBox RussianChBox;
        private System.Windows.Forms.CheckBox EnglishChBox;
        private System.Windows.Forms.TextBox LastNameTxtB;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox EmailTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IndustryTxtB;
        private System.Windows.Forms.Label IndustryLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskBox;
        private System.Windows.Forms.TextBox DepartmentTxtB;
        private System.Windows.Forms.Label DepartmentLbl;
        private System.Windows.Forms.Button Savebtn1;
    }
}

