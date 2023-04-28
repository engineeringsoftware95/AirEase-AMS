namespace AirEase_AMS.Interface
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            linkLabel1 = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            LoginFailureLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.number2;
            pictureBox1.Location = new Point(280, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(345, 284);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameBox.Location = new Point(345, 201);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Username";
            UsernameBox.Size = new Size(100, 23);
            UsernameBox.TabIndex = 2;
            UsernameBox.Tag = "UsernameBox";
            UsernameBox.TextChanged += textBox1_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordBox.Location = new Point(345, 242);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.PlaceholderText = "Password";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 3;
            PasswordBox.Tag = "PasswordBox";
            PasswordBox.TextChanged += textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(345, 330);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // LoginFailureLabel
            // 
            LoginFailureLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginFailureLabel.AutoSize = true;
            LoginFailureLabel.Location = new Point(345, 164);
            LoginFailureLabel.Name = "LoginFailureLabel";
            LoginFailureLabel.Size = new Size(100, 15);
            LoginFailureLabel.TabIndex = 5;
            LoginFailureLabel.Tag = "LoginFailureLabel";
            LoginFailureLabel.Text = "LoginFailureLabel";
            LoginFailureLabel.Visible = false;
            LoginFailureLabel.Click += LoginFailureLabel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginFailureLabel);
            Controls.Add(linkLabel1);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private LinkLabel linkLabel1;
        private ErrorProvider errorProvider1;
        private Label LoginFailureLabel;
        private ErrorProvider errorProvider2;
    }
}