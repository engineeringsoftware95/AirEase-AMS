namespace AirEase_AMS.Interface
{
    partial class AccountCreated
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIDBox = new System.Windows.Forms.RichTextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirEase_AMS.Properties.Resources.number2;
            this.pictureBox1.Location = new System.Drawing.Point(265, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UserIDBox
            // 
            this.UserIDBox.HideSelection = false;
            this.UserIDBox.Location = new System.Drawing.Point(269, 138);
            this.UserIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.ReadOnly = true;
            this.UserIDBox.Size = new System.Drawing.Size(255, 182);
            this.UserIDBox.TabIndex = 21;
            this.UserIDBox.Tag = "UserIDBox";
            this.UserIDBox.Text = "You have successfully created an account.\n\n";
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(341, 345);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(94, 29);
            this.ContinueButton.TabIndex = 22;
            this.ContinueButton.Tag = "ContinueButton";
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // AccountCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.UserIDBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AccountCreated";
            this.Text = "AccountCreated";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox UserIDBox;
        private Button ContinueButton;
    }
}