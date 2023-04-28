namespace AirEase_AMS.Interface
{
    partial class InformationAccountCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationAccountCreationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ErrorMessageBox = new System.Windows.Forms.RichTextBox();
            this.PasswordVerify = new System.Windows.Forms.TextBox();
            this.PasswordFirst = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.BirthDateCalendar = new System.Windows.Forms.DateTimePicker();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirEase_AMS.Properties.Resources.number2;
            this.pictureBox1.Location = new System.Drawing.Point(641, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select birthday";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(487, 132);
            this.PhoneNumberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.PlaceholderText = "Phone Number";
            this.PhoneNumberBox.Size = new System.Drawing.Size(132, 27);
            this.PhoneNumberBox.TabIndex = 17;
            this.PhoneNumberBox.Tag = "PhoneNumberBox";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(487, 93);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.PlaceholderText = "Address";
            this.AddressBox.Size = new System.Drawing.Size(132, 27);
            this.AddressBox.TabIndex = 16;
            this.AddressBox.Tag = "AddressBox";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(487, 55);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.PlaceholderText = "Last name";
            this.LastNameBox.Size = new System.Drawing.Size(132, 27);
            this.LastNameBox.TabIndex = 15;
            this.LastNameBox.Tag = "LastNameBox";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(487, 16);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.PlaceholderText = "First name";
            this.FirstNameBox.Size = new System.Drawing.Size(132, 27);
            this.FirstNameBox.TabIndex = 14;
            this.FirstNameBox.Tag = "FirstNameBox";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(418, 248);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(133, 31);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Tag = "SubmitButton";
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // ErrorMessageBox
            // 
            this.ErrorMessageBox.HideSelection = false;
            this.ErrorMessageBox.Location = new System.Drawing.Point(14, 16);
            this.ErrorMessageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ErrorMessageBox.Name = "ErrorMessageBox";
            this.ErrorMessageBox.ReadOnly = true;
            this.ErrorMessageBox.Size = new System.Drawing.Size(314, 567);
            this.ErrorMessageBox.TabIndex = 20;
            this.ErrorMessageBox.Text = resources.GetString("ErrorMessageBox.Text");
            // 
            // PasswordVerify
            // 
            this.PasswordVerify.Location = new System.Drawing.Point(335, 55);
            this.PasswordVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordVerify.Name = "PasswordVerify";
            this.PasswordVerify.PasswordChar = '*';
            this.PasswordVerify.PlaceholderText = "Re-enter password";
            this.PasswordVerify.Size = new System.Drawing.Size(132, 27);
            this.PasswordVerify.TabIndex = 19;
            this.PasswordVerify.Tag = "PasswordVerify";
            // 
            // PasswordFirst
            // 
            this.PasswordFirst.Location = new System.Drawing.Point(335, 16);
            this.PasswordFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordFirst.Name = "PasswordFirst";
            this.PasswordFirst.PasswordChar = '*';
            this.PasswordFirst.PlaceholderText = "Enter password";
            this.PasswordFirst.Size = new System.Drawing.Size(132, 27);
            this.PasswordFirst.TabIndex = 18;
            this.PasswordFirst.Tag = "PasswordFirst";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // BirthDateCalendar
            // 
            this.BirthDateCalendar.Location = new System.Drawing.Point(335, 209);
            this.BirthDateCalendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BirthDateCalendar.MaxDate = new System.DateTime(9998, 4, 13, 0, 0, 0, 0);
            this.BirthDateCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDateCalendar.Name = "BirthDateCalendar";
            this.BirthDateCalendar.Size = new System.Drawing.Size(284, 27);
            this.BirthDateCalendar.TabIndex = 22;
            this.BirthDateCalendar.Tag = "BirthDateCalendar";
            this.BirthDateCalendar.Value = new System.DateTime(2023, 4, 13, 0, 0, 0, 0);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(487, 171);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PlaceholderText = "Email";
            this.EmailBox.Size = new System.Drawing.Size(132, 27);
            this.EmailBox.TabIndex = 23;
            this.EmailBox.Tag = "EmailBox";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(418, 535);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(133, 31);
            this.Cancel.TabIndex = 24;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // InformationAccountCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.BirthDateCalendar);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ErrorMessageBox);
            this.Controls.Add(this.PasswordVerify);
            this.Controls.Add(this.PasswordFirst);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InformationAccountCreationForm";
            this.Text = "InformationAccountCreationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox PhoneNumberBox;
        private TextBox AddressBox;
        private TextBox LastNameBox;
        private TextBox FirstNameBox;
        private Button SubmitButton;
        private RichTextBox ErrorMessageBox;
        private TextBox PasswordVerify;
        private TextBox PasswordFirst;
        private System.Diagnostics.Process process1;
        private DateTimePicker BirthDateCalendar;
        private TextBox EmailBox;
        private Button Cancel;
    }
}