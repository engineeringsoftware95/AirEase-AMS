namespace AirEase_AMS.Interface
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MarketsTab = new System.Windows.Forms.TabPage();
            this.FlightsTab = new System.Windows.Forms.TabPage();
            this.flightManifestWindow = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.RoutesTab = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.flightTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationCombo = new System.Windows.Forms.ComboBox();
            this.originView = new System.Windows.Forms.ComboBox();
            this.AccountsTab = new System.Windows.Forms.TabPage();
            this.summaryReportWindow = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MarketsTab.SuspendLayout();
            this.FlightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightManifestWindow)).BeginInit();
            this.RoutesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.AccountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryReportWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.HomeTab);
            this.tabControl1.Controls.Add(this.MarketsTab);
            this.tabControl1.Controls.Add(this.FlightsTab);
            this.tabControl1.Controls.Add(this.RoutesTab);
            this.tabControl1.Controls.Add(this.AccountsTab);
            this.tabControl1.Location = new System.Drawing.Point(84, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 320);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.pictureBox2);
            this.HomeTab.Controls.Add(this.richTextBox1);
            this.HomeTab.Location = new System.Drawing.Point(50, 4);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomeTab.Size = new System.Drawing.Size(551, 312);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Tag = "HomeTab";
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(195, 243);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "You are a valued employee\nWhy aren\'t you working?\nWork like your job depends on i" +
    "t (because it does)\n\n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MarketsTab
            // 
            this.MarketsTab.Controls.Add(this.button3);
            this.MarketsTab.Controls.Add(this.label5);
            this.MarketsTab.Controls.Add(this.label4);
            this.MarketsTab.Controls.Add(this.pictureBox4);
            this.MarketsTab.Controls.Add(this.comboBox2);
            this.MarketsTab.Controls.Add(this.comboBox1);
            this.MarketsTab.Location = new System.Drawing.Point(50, 4);
            this.MarketsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarketsTab.Name = "MarketsTab";
            this.MarketsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarketsTab.Size = new System.Drawing.Size(551, 312);
            this.MarketsTab.TabIndex = 1;
            this.MarketsTab.Tag = "MarketsTab";
            this.MarketsTab.Text = "Plane Manager";
            this.MarketsTab.UseVisualStyleBackColor = true;
            // 
            // FlightsTab
            // 
            this.FlightsTab.Controls.Add(this.flightManifestWindow);
            this.FlightsTab.Controls.Add(this.button2);
            this.FlightsTab.Location = new System.Drawing.Point(50, 4);
            this.FlightsTab.Name = "FlightsTab";
            this.FlightsTab.Size = new System.Drawing.Size(551, 312);
            this.FlightsTab.TabIndex = 2;
            this.FlightsTab.Tag = "FlightsTab";
            this.FlightsTab.Text = "Print Manifest";
            this.FlightsTab.UseVisualStyleBackColor = true;
            // 
            // flightManifestWindow
            // 
            this.flightManifestWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightManifestWindow.Location = new System.Drawing.Point(3, 67);
            this.flightManifestWindow.Name = "flightManifestWindow";
            this.flightManifestWindow.ReadOnly = true;
            this.flightManifestWindow.RowTemplate.Height = 25;
            this.flightManifestWindow.Size = new System.Drawing.Size(568, 242);
            this.flightManifestWindow.TabIndex = 4;
            this.flightManifestWindow.Tag = "flightManifestWindow";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate Flight Manifest";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RoutesTab
            // 
            this.RoutesTab.Controls.Add(this.pictureBox3);
            this.RoutesTab.Controls.Add(this.AddFlightButton);
            this.RoutesTab.Controls.Add(this.flightTimePicker);
            this.RoutesTab.Controls.Add(this.label3);
            this.RoutesTab.Controls.Add(this.comboBox3);
            this.RoutesTab.Controls.Add(this.UpdateButton);
            this.RoutesTab.Controls.Add(this.label2);
            this.RoutesTab.Controls.Add(this.label1);
            this.RoutesTab.Controls.Add(this.destinationCombo);
            this.RoutesTab.Controls.Add(this.originView);
            this.RoutesTab.Location = new System.Drawing.Point(50, 4);
            this.RoutesTab.Name = "RoutesTab";
            this.RoutesTab.Size = new System.Drawing.Size(551, 312);
            this.RoutesTab.TabIndex = 3;
            this.RoutesTab.Tag = "RoutesTab";
            this.RoutesTab.Text = "Route Manager";
            this.RoutesTab.UseVisualStyleBackColor = true;
            this.RoutesTab.Click += new System.EventHandler(this.RoutesTab_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.Location = new System.Drawing.Point(317, 266);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(227, 23);
            this.AddFlightButton.TabIndex = 11;
            this.AddFlightButton.Tag = "AddFlightButton";
            this.AddFlightButton.Text = "Add Flight";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // flightTimePicker
            // 
            this.flightTimePicker.Location = new System.Drawing.Point(318, 223);
            this.flightTimePicker.Name = "flightTimePicker";
            this.flightTimePicker.Size = new System.Drawing.Size(226, 23);
            this.flightTimePicker.TabIndex = 10;
            this.flightTimePicker.ValueChanged += new System.EventHandler(this.flightTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Route";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(318, 175);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(226, 23);
            this.comboBox3.TabIndex = 8;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(317, 115);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(227, 29);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Tag = "UpdateButton";
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // destinationCombo
            // 
            this.destinationCombo.FormattingEnabled = true;
            this.destinationCombo.Location = new System.Drawing.Point(317, 74);
            this.destinationCombo.Name = "destinationCombo";
            this.destinationCombo.Size = new System.Drawing.Size(227, 23);
            this.destinationCombo.TabIndex = 2;
            this.destinationCombo.Tag = "destinationCombo";
            // 
            // originView
            // 
            this.originView.FormattingEnabled = true;
            this.originView.Location = new System.Drawing.Point(317, 29);
            this.originView.Name = "originView";
            this.originView.Size = new System.Drawing.Size(227, 23);
            this.originView.TabIndex = 1;
            this.originView.Tag = "originView";
            // 
            // AccountsTab
            // 
            this.AccountsTab.Controls.Add(this.summaryReportWindow);
            this.AccountsTab.Controls.Add(this.button1);
            this.AccountsTab.Location = new System.Drawing.Point(50, 4);
            this.AccountsTab.Name = "AccountsTab";
            this.AccountsTab.Size = new System.Drawing.Size(551, 312);
            this.AccountsTab.TabIndex = 4;
            this.AccountsTab.Tag = "AccountsTab";
            this.AccountsTab.Text = "Accounts Manager";
            this.AccountsTab.UseVisualStyleBackColor = true;
            // 
            // summaryReportWindow
            // 
            this.summaryReportWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryReportWindow.Location = new System.Drawing.Point(3, 67);
            this.summaryReportWindow.Name = "summaryReportWindow";
            this.summaryReportWindow.RowTemplate.Height = 25;
            this.summaryReportWindow.Size = new System.Drawing.Size(568, 242);
            this.summaryReportWindow.TabIndex = 2;
            this.summaryReportWindow.Tag = "summaryReportWindow";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Summary Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(238, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Flight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plane";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MarketsTab.ResumeLayout(false);
            this.MarketsTab.PerformLayout();
            this.FlightsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightManifestWindow)).EndInit();
            this.RoutesTab.ResumeLayout(false);
            this.RoutesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.AccountsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.summaryReportWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage HomeTab;
        private TabPage MarketsTab;
        private TabPage FlightsTab;
        private TabPage RoutesTab;
        private TabPage AccountsTab;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private ComboBox destinationCombo;
        private ComboBox originView;
        private Label label2;
        private Button UpdateButton;
        private Label label3;
        private ComboBox comboBox3;
        private DateTimePicker flightTimePicker;
        private Button AddFlightButton;
        private PictureBox pictureBox3;
        private DataGridView flightManifestWindow;
        private Button button2;
        private DataGridView summaryReportWindow;
        private PictureBox pictureBox4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Button button3;
    }
}