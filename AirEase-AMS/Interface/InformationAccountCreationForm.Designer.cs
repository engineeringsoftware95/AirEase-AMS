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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PhoneNumberBox = new TextBox();
            AddressBox = new TextBox();
            LastNameBox = new TextBox();
            FirstNameBox = new TextBox();
            SubmitButton = new Button();
            ErrorMessageBox = new RichTextBox();
            PasswordVerify = new TextBox();
            PasswordFirst = new TextBox();
            process1 = new System.Diagnostics.Process();
            BirthDateCalendar = new DateTimePicker();
            EmailBox = new TextBox();
            Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.number2;
            pictureBox1.Location = new Point(561, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 136);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 11;
            label1.Text = "Select birthday";
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(426, 99);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.PlaceholderText = "Phone Number";
            PhoneNumberBox.Size = new Size(116, 23);
            PhoneNumberBox.TabIndex = 17;
            PhoneNumberBox.Tag = "PhoneNumberBox";
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(426, 70);
            AddressBox.Name = "AddressBox";
            AddressBox.PlaceholderText = "Address";
            AddressBox.Size = new Size(116, 23);
            AddressBox.TabIndex = 16;
            AddressBox.Tag = "AddressBox";
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(426, 41);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.PlaceholderText = "Last name";
            LastNameBox.Size = new Size(116, 23);
            LastNameBox.TabIndex = 15;
            LastNameBox.Tag = "LastNameBox";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(426, 12);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.PlaceholderText = "First name";
            FirstNameBox.Size = new Size(116, 23);
            FirstNameBox.TabIndex = 14;
            FirstNameBox.Tag = "FirstNameBox";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(366, 186);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(116, 23);
            SubmitButton.TabIndex = 21;
            SubmitButton.Tag = "SubmitButton";
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ErrorMessageBox
            // 
            ErrorMessageBox.HideSelection = false;
            ErrorMessageBox.Location = new Point(12, 12);
            ErrorMessageBox.Name = "ErrorMessageBox";
            ErrorMessageBox.ReadOnly = true;
            ErrorMessageBox.Size = new Size(275, 426);
            ErrorMessageBox.TabIndex = 20;
            ErrorMessageBox.Text = resources.GetString("ErrorMessageBox.Text");
            // 
            // PasswordVerify
            // 
            PasswordVerify.Location = new Point(293, 41);
            PasswordVerify.Name = "PasswordVerify";
            PasswordVerify.PasswordChar = '*';
            PasswordVerify.PlaceholderText = "Re-enter password";
            PasswordVerify.Size = new Size(116, 23);
            PasswordVerify.TabIndex = 19;
            PasswordVerify.Tag = "PasswordVerify";
            // 
            // PasswordFirst
            // 
            PasswordFirst.Location = new Point(293, 12);
            PasswordFirst.Name = "PasswordFirst";
            PasswordFirst.PasswordChar = '*';
            PasswordFirst.PlaceholderText = "Enter password";
            PasswordFirst.Size = new Size(116, 23);
            PasswordFirst.TabIndex = 18;
            PasswordFirst.Tag = "PasswordFirst";
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // BirthDateCalendar
            // 
            BirthDateCalendar.Location = new Point(293, 157);
            BirthDateCalendar.MaxDate = new DateTime(9998, 4, 13, 0, 0, 0, 0);
            BirthDateCalendar.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            BirthDateCalendar.Name = "BirthDateCalendar";
            BirthDateCalendar.Size = new Size(249, 23);
            BirthDateCalendar.TabIndex = 22;
            BirthDateCalendar.Tag = "BirthDateCalendar";
            BirthDateCalendar.Value = new DateTime(2023, 4, 13, 0, 0, 0, 0);
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(426, 128);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.Size = new Size(116, 23);
            EmailBox.TabIndex = 23;
            EmailBox.Tag = "EmailBox";
            // 
            // Cancel
            // 
            Cancel.Location = new Point(366, 401);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(116, 23);
            Cancel.TabIndex = 24;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // InformationAccountCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancel);
            Controls.Add(EmailBox);
            Controls.Add(BirthDateCalendar);
            Controls.Add(SubmitButton);
            Controls.Add(ErrorMessageBox);
            Controls.Add(PasswordVerify);
            Controls.Add(PasswordFirst);
            Controls.Add(PhoneNumberBox);
            Controls.Add(AddressBox);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "InformationAccountCreationForm";
            Text = "InformationAccountCreationForm";
            Load += InformationAccountCreationForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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