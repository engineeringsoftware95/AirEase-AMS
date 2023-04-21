namespace AirEase_AMS.Interface
{
    partial class CustomerBilling
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
            purchase = new Button();
            makePaymentDefault = new CheckBox();
            flightInfo = new TextBox();
            comboBox1 = new ComboBox();
            cancel = new Button();
            newPaymentMethod = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // purchase
            // 
            purchase.Location = new Point(369, 414);
            purchase.Name = "purchase";
            purchase.Size = new Size(176, 23);
            purchase.TabIndex = 0;
            purchase.Text = "Purchase";
            purchase.UseVisualStyleBackColor = true;
            // 
            // makePaymentDefault
            // 
            makePaymentDefault.AutoSize = true;
            makePaymentDefault.Location = new Point(369, 343);
            makePaymentDefault.Name = "makePaymentDefault";
            makePaymentDefault.Size = new Size(191, 19);
            makePaymentDefault.TabIndex = 1;
            makePaymentDefault.Text = "Make Payment Method Default";
            makePaymentDefault.UseVisualStyleBackColor = true;
            // 
            // flightInfo
            // 
            flightInfo.Location = new Point(124, 12);
            flightInfo.Multiline = true;
            flightInfo.Name = "flightInfo";
            flightInfo.Size = new Size(664, 296);
            flightInfo.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(303, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 23);
            comboBox1.TabIndex = 5;
            // 
            // cancel
            // 
            cancel.Location = new Point(124, 414);
            cancel.Name = "cancel";
            cancel.Size = new Size(113, 23);
            cancel.TabIndex = 6;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // newPaymentMethod
            // 
            newPaymentMethod.Location = new Point(613, 314);
            newPaymentMethod.Name = "newPaymentMethod";
            newPaymentMethod.Size = new Size(163, 23);
            newPaymentMethod.TabIndex = 7;
            newPaymentMethod.Text = "Enter new payment method";
            newPaymentMethod.UseVisualStyleBackColor = true;
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
            // CustomerBilling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(newPaymentMethod);
            Controls.Add(cancel);
            Controls.Add(comboBox1);
            Controls.Add(flightInfo);
            Controls.Add(makePaymentDefault);
            Controls.Add(purchase);
            Name = "CustomerBilling";
            Text = "Billing Preview Page";
            Load += CustomerBilling_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button purchase;
        private CheckBox makePaymentDefault;
        private TextBox flightInfo;
        private ComboBox comboBox1;
        private Button cancel;
        private Button newPaymentMethod;
        private PictureBox pictureBox1;
    }
}