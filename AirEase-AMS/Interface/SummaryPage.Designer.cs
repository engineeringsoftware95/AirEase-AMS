namespace AirEase_AMS.Interface
{
    partial class SummaryPage
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
            confirmationButton = new Button();
            AccountSummary = new ListBox();
            Reciept = new RichTextBox();
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
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // confirmationButton
            // 
            confirmationButton.Location = new Point(228, 385);
            confirmationButton.Name = "confirmationButton";
            confirmationButton.Size = new Size(75, 23);
            confirmationButton.TabIndex = 24;
            confirmationButton.Text = "Done";
            confirmationButton.UseVisualStyleBackColor = true;
            confirmationButton.Click += confirmationButton_Click;
            // 
            // AccountSummary
            // 
            AccountSummary.FormattingEnabled = true;
            AccountSummary.ItemHeight = 15;
            AccountSummary.Location = new Point(123, 12);
            AccountSummary.Name = "AccountSummary";
            AccountSummary.Size = new Size(295, 319);
            AccountSummary.TabIndex = 26;
            AccountSummary.SelectedIndexChanged += AccountSummary_SelectedIndexChanged;
            // 
            // Reciept
            // 
            Reciept.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Reciept.Location = new Point(424, 12);
            Reciept.Name = "Reciept";
            Reciept.Size = new Size(364, 426);
            Reciept.TabIndex = 27;
            Reciept.Text = "";
            // 
            // SummaryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reciept);
            Controls.Add(AccountSummary);
            Controls.Add(confirmationButton);
            Controls.Add(pictureBox1);
            Name = "SummaryPage";
            Text = "Reciept View";
            Load += SummaryPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button confirmationButton;
        private ListBox AccountSummary;
        private RichTextBox Reciept;
    }
}