namespace AirEase_AMS.Interface
{
    partial class PaymentInformationEntry
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
            pictureBox1 = new PictureBox();
            cancel = new Button();
            Continue = new Button();
            CCNEntry = new TextBox();
            textBox3 = new TextBox();
            CCN = new Label();
            ExpDate = new Label();
            SecurityCode = new Label();
            Zip = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconLogo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancel.Location = new Point(157, 316);
            cancel.Name = "cancel";
            cancel.Size = new Size(113, 23);
            cancel.TabIndex = 23;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // Continue
            // 
            Continue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Continue.Location = new Point(435, 316);
            Continue.Name = "Continue";
            Continue.Size = new Size(176, 23);
            Continue.TabIndex = 22;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = true;
            Continue.Click += continue_Click;
            // 
            // CCNEntry
            // 
            CCNEntry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CCNEntry.Location = new Point(277, 100);
            CCNEntry.Name = "CCNEntry";
            CCNEntry.Size = new Size(446, 23);
            CCNEntry.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(277, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(446, 23);
            textBox3.TabIndex = 25;
            // 
            // CCN
            // 
            CCN.AutoSize = true;
            CCN.Location = new Point(157, 103);
            CCN.Name = "CCN";
            CCN.Size = new Size(117, 15);
            CCN.TabIndex = 32;
            CCN.Text = "Credit Card Number:";
            // 
            // ExpDate
            // 
            ExpDate.AutoSize = true;
            ExpDate.Location = new Point(157, 132);
            ExpDate.Name = "ExpDate";
            ExpDate.Size = new Size(93, 15);
            ExpDate.TabIndex = 33;
            ExpDate.Text = "Experation Date:";
            // 
            // SecurityCode
            // 
            SecurityCode.AutoSize = true;
            SecurityCode.Location = new Point(157, 161);
            SecurityCode.Name = "SecurityCode";
            SecurityCode.Size = new Size(83, 15);
            SecurityCode.TabIndex = 34;
            SecurityCode.Text = "Security Code:";
            // 
            // Zip
            // 
            Zip.AutoSize = true;
            Zip.Location = new Point(157, 190);
            Zip.Name = "Zip";
            Zip.Size = new Size(94, 15);
            Zip.TabIndex = 36;
            Zip.Text = "Billing Zip Code:";
            Zip.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(277, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 23);
            textBox1.TabIndex = 35;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(446, 23);
            dateTimePicker1.TabIndex = 37;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(435, 298);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.RightToLeft = RightToLeft.Yes;
            ErrorLabel.Size = new Size(60, 15);
            ErrorLabel.TabIndex = 38;
            ErrorLabel.Text = "ErrorLabel";
            ErrorLabel.Visible = false;
            // 
            // PaymentInformationEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrorLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(Zip);
            Controls.Add(textBox1);
            Controls.Add(SecurityCode);
            Controls.Add(ExpDate);
            Controls.Add(CCN);
            Controls.Add(textBox3);
            Controls.Add(CCNEntry);
            Controls.Add(cancel);
            Controls.Add(Continue);
            Controls.Add(pictureBox1);
            Name = "PaymentInformationEntry";
            Text = "New Payment Information";
            Load += PaymentInformationEntry_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button cancel;
        private Button Continue;
        private TextBox CCNEntry;
        private TextBox textBox3;
        private Label CCN;
        private Label ExpDate;
        private Label SecurityCode;
        private Label Zip;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label ErrorLabel;
    }
}