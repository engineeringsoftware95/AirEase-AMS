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
            tabControl1 = new TabControl();
            HomeTab = new TabPage();
            listBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            MarketsTab = new TabPage();
            label4 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            dataGridView2 = new DataGridView();
            FlightsTab = new TabPage();
            pictureBox5 = new PictureBox();
            flightManifestWindow = new DataGridView();
            button2 = new Button();
            RoutesTab = new TabPage();
            dataGridView1 = new DataGridView();
            pictureBox3 = new PictureBox();
            AddFlightButton = new Button();
            flightTimePicker = new DateTimePicker();
            label3 = new Label();
            comboBox3 = new ComboBox();
            UpdateButton = new Button();
            label2 = new Label();
            label1 = new Label();
            destinationCombo = new ComboBox();
            originView = new ComboBox();
            AccountsTab = new TabPage();
            pictureBox6 = new PictureBox();
            summaryReportWindow = new DataGridView();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            tabControl1.SuspendLayout();
            HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            MarketsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            FlightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightManifestWindow).BeginInit();
            RoutesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            AccountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)summaryReportWindow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(HomeTab);
            tabControl1.Controls.Add(MarketsTab);
            tabControl1.Controls.Add(FlightsTab);
            tabControl1.Controls.Add(RoutesTab);
            tabControl1.Controls.Add(AccountsTab);
            tabControl1.Location = new Point(84, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(705, 432);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // HomeTab
            // 
            HomeTab.Controls.Add(listBox1);
            HomeTab.Controls.Add(pictureBox2);
            HomeTab.Controls.Add(richTextBox1);
            HomeTab.Location = new Point(50, 4);
            HomeTab.Margin = new Padding(3, 2, 3, 2);
            HomeTab.Name = "HomeTab";
            HomeTab.Padding = new Padding(3, 2, 3, 2);
            HomeTab.RightToLeft = RightToLeft.No;
            HomeTab.Size = new Size(651, 424);
            HomeTab.TabIndex = 0;
            HomeTab.Tag = "HomeTab";
            HomeTab.Text = "Home";
            HomeTab.UseVisualStyleBackColor = true;
            HomeTab.Click += HomeTab_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(270, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(378, 409);
            listBox1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBox1.Location = new Point(6, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(258, 330);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "You are a valued employee\nWhy aren't you working?\nWork like your job depends on it (because it does)\n\n";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // MarketsTab
            // 
            MarketsTab.Controls.Add(pictureBox4);
            MarketsTab.Controls.Add(label4);
            MarketsTab.Controls.Add(button3);
            MarketsTab.Controls.Add(comboBox1);
            MarketsTab.Controls.Add(dataGridView2);
            MarketsTab.Location = new Point(50, 4);
            MarketsTab.Margin = new Padding(3, 2, 3, 2);
            MarketsTab.Name = "MarketsTab";
            MarketsTab.Padding = new Padding(3, 2, 3, 2);
            MarketsTab.Size = new Size(651, 424);
            MarketsTab.TabIndex = 1;
            MarketsTab.Tag = "MarketsTab";
            MarketsTab.Text = "Plane Manager";
            MarketsTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 145);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Flight";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(123, 233);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 5;
            button3.Tag = "UpdateButton";
            button3.Text = "Set";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(325, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(320, 418);
            dataGridView2.TabIndex = 14;
            // 
            // FlightsTab
            // 
            FlightsTab.Controls.Add(pictureBox5);
            FlightsTab.Controls.Add(flightManifestWindow);
            FlightsTab.Controls.Add(button2);
            FlightsTab.Location = new Point(50, 4);
            FlightsTab.Name = "FlightsTab";
            FlightsTab.Size = new Size(651, 424);
            FlightsTab.TabIndex = 2;
            FlightsTab.Tag = "FlightsTab";
            FlightsTab.Text = "Print Manifest";
            FlightsTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.number2;
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(163, 79);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // flightManifestWindow
            // 
            flightManifestWindow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            flightManifestWindow.Location = new Point(39, 139);
            flightManifestWindow.Name = "flightManifestWindow";
            flightManifestWindow.ReadOnly = true;
            flightManifestWindow.RowTemplate.Height = 25;
            flightManifestWindow.Size = new Size(568, 242);
            flightManifestWindow.TabIndex = 4;
            flightManifestWindow.Tag = "flightManifestWindow";
            // 
            // button2
            // 
            button2.Location = new Point(39, 110);
            button2.Name = "button2";
            button2.Size = new Size(178, 23);
            button2.TabIndex = 3;
            button2.Text = "Generate Flight Manifest";
            button2.UseVisualStyleBackColor = true;
            // 
            // RoutesTab
            // 
            RoutesTab.Controls.Add(dataGridView1);
            RoutesTab.Controls.Add(pictureBox3);
            RoutesTab.Controls.Add(AddFlightButton);
            RoutesTab.Controls.Add(flightTimePicker);
            RoutesTab.Controls.Add(label3);
            RoutesTab.Controls.Add(comboBox3);
            RoutesTab.Controls.Add(UpdateButton);
            RoutesTab.Controls.Add(label2);
            RoutesTab.Controls.Add(label1);
            RoutesTab.Controls.Add(destinationCombo);
            RoutesTab.Controls.Add(originView);
            RoutesTab.Location = new Point(50, 4);
            RoutesTab.Name = "RoutesTab";
            RoutesTab.Size = new Size(651, 424);
            RoutesTab.TabIndex = 3;
            RoutesTab.Tag = "RoutesTab";
            RoutesTab.Text = "Route Manager";
            RoutesTab.UseVisualStyleBackColor = true;
            RoutesTab.Click += RoutesTab_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(320, 418);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // AddFlightButton
            // 
            AddFlightButton.Location = new Point(84, 370);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(227, 23);
            AddFlightButton.TabIndex = 11;
            AddFlightButton.Tag = "AddFlightButton";
            AddFlightButton.Text = "Add Flight";
            AddFlightButton.UseVisualStyleBackColor = true;
            AddFlightButton.Click += button2_Click_1;
            // 
            // flightTimePicker
            // 
            flightTimePicker.Location = new Point(85, 327);
            flightTimePicker.Name = "flightTimePicker";
            flightTimePicker.Size = new Size(226, 23);
            flightTimePicker.TabIndex = 10;
            flightTimePicker.ValueChanged += flightTimePicker_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 287);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "Route";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(85, 279);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(226, 23);
            comboBox3.TabIndex = 8;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(84, 219);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(227, 29);
            UpdateButton.TabIndex = 7;
            UpdateButton.Tag = "UpdateButton";
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 186);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 136);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Origin";
            label1.Click += label1_Click;
            // 
            // destinationCombo
            // 
            destinationCombo.FormattingEnabled = true;
            destinationCombo.Location = new Point(84, 178);
            destinationCombo.Name = "destinationCombo";
            destinationCombo.Size = new Size(227, 23);
            destinationCombo.TabIndex = 2;
            destinationCombo.Tag = "destinationCombo";
            // 
            // originView
            // 
            originView.FormattingEnabled = true;
            originView.Location = new Point(84, 133);
            originView.Name = "originView";
            originView.Size = new Size(227, 23);
            originView.TabIndex = 1;
            originView.Tag = "originView";
            // 
            // AccountsTab
            // 
            AccountsTab.Controls.Add(pictureBox6);
            AccountsTab.Controls.Add(summaryReportWindow);
            AccountsTab.Controls.Add(button1);
            AccountsTab.Location = new Point(50, 4);
            AccountsTab.Name = "AccountsTab";
            AccountsTab.Size = new Size(651, 424);
            AccountsTab.TabIndex = 4;
            AccountsTab.Tag = "AccountsTab";
            AccountsTab.Text = "Accounts Manager";
            AccountsTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.number2;
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(163, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // summaryReportWindow
            // 
            summaryReportWindow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            summaryReportWindow.Location = new Point(20, 125);
            summaryReportWindow.Name = "summaryReportWindow";
            summaryReportWindow.RowTemplate.Height = 25;
            summaryReportWindow.Size = new Size(568, 242);
            summaryReportWindow.TabIndex = 2;
            summaryReportWindow.Tag = "summaryReportWindow";
            // 
            // button1
            // 
            button1.Location = new Point(20, 96);
            button1.Name = "button1";
            button1.Size = new Size(178, 23);
            button1.TabIndex = 1;
            button1.Text = "Generate Summary Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.number2;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(163, 79);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeForm";
            Text = "Employee View";
            Load += EmployeeForm_Load;
            tabControl1.ResumeLayout(false);
            HomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            MarketsTab.ResumeLayout(false);
            MarketsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            FlightsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightManifestWindow).EndInit();
            RoutesTab.ResumeLayout(false);
            RoutesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            AccountsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)summaryReportWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
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
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label4;
        private Button button3;
        private ComboBox comboBox1;
        private DataGridView dataGridView2;
        private PictureBox pictureBox4;
    }
}