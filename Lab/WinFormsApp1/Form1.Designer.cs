using ClassLibrary1;

namespace WinFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.textBoxPlaceOfResidence = new System.Windows.Forms.TextBox();
            this.labelPlaceOfResidence = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(30, 50);
            this.FirstName.Margin = new System.Windows.Forms.Padding(1);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(230, 23);
            this.FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(30, 108);
            this.LastName.Margin = new System.Windows.Forms.Padding(1);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(228, 23);
            this.LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(30, 224);
            this.Phone.Margin = new System.Windows.Forms.Padding(1);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(228, 23);
            this.Phone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер телефона";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(30, 167);
            this.Email.Margin = new System.Windows.Forms.Padding(1);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(228, 23);
            this.Email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Почта";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(181, 411);
            this.Save.Margin = new System.Windows.Forms.Padding(1);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 21);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.BackColor = System.Drawing.SystemColors.Info;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(32, 445);
            this.ErrorMessage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.ErrorMessage.TabIndex = 9;
            // 
            // textBoxPlaceOfResidence
            // 
            this.textBoxPlaceOfResidence.Location = new System.Drawing.Point(32, 287);
            this.textBoxPlaceOfResidence.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPlaceOfResidence.Name = "textBoxPlaceOfResidence";
            this.textBoxPlaceOfResidence.Size = new System.Drawing.Size(228, 23);
            this.textBoxPlaceOfResidence.TabIndex = 11;
            // 
            // labelPlaceOfResidence
            // 
            this.labelPlaceOfResidence.AutoSize = true;
            this.labelPlaceOfResidence.Location = new System.Drawing.Point(30, 271);
            this.labelPlaceOfResidence.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPlaceOfResidence.Name = "labelPlaceOfResidence";
            this.labelPlaceOfResidence.Size = new System.Drawing.Size(108, 15);
            this.labelPlaceOfResidence.TabIndex = 10;
            this.labelPlaceOfResidence.Text = "Место жительства";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(30, 341);
            this.labelGender.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(30, 15);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(32, 373);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(226, 23);
            this.comboBoxGender.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(324, 601);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxPlaceOfResidence);
            this.Controls.Add(this.labelPlaceOfResidence);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox FirstName;
        private TextBox LastName;
        private Label label2;
        private TextBox Phone;
        private Label label3;
        private TextBox Email;
        private Label label4;
        private Button Save;
        private Label ErrorMessage;
        private TextBox textBoxPlaceOfResidence;
        private Label labelPlaceOfResidence;
        private Label labelGender;
        private ComboBox comboBoxGender;


    }
}