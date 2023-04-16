namespace AirEase_AMS.Interface
{
    partial class CustomerMain
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
            this.CustomerTabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.NewsFeed = new System.Windows.Forms.ListBox();
            this.AccountHistory = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PastFlights = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanceledFlights = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepatureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpcomingFlights = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booking = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTabControl.SuspendLayout();
            this.Home.SuspendLayout();
            this.AccountHistory.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PastFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.CanceledFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.UpcomingFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerTabControl
            // 
            this.CustomerTabControl.AccessibleDescription = "";
            this.CustomerTabControl.AccessibleName = "";
            this.CustomerTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.CustomerTabControl.AllowDrop = true;
            this.CustomerTabControl.Controls.Add(this.Home);
            this.CustomerTabControl.Controls.Add(this.AccountHistory);
            this.CustomerTabControl.Controls.Add(this.UpcomingFlights);
            this.CustomerTabControl.Controls.Add(this.Booking);
            this.CustomerTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomerTabControl.Location = new System.Drawing.Point(102, 2);
            this.CustomerTabControl.Multiline = true;
            this.CustomerTabControl.Name = "CustomerTabControl";
            this.CustomerTabControl.Padding = new System.Drawing.Point(50, 50);
            this.CustomerTabControl.SelectedIndex = 0;
            this.CustomerTabControl.Size = new System.Drawing.Size(700, 447);
            this.CustomerTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CustomerTabControl.TabIndex = 10;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.monthCalendar1);
            this.Home.Controls.Add(this.listBox2);
            this.Home.Controls.Add(this.NewsFeed);
            this.Home.Location = new System.Drawing.Point(121, 4);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Home.Size = new System.Drawing.Size(575, 439);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(9, 187);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(546, 244);
            this.listBox2.TabIndex = 18;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // NewsFeed
            // 
            this.NewsFeed.FormattingEnabled = true;
            this.NewsFeed.ItemHeight = 15;
            this.NewsFeed.Location = new System.Drawing.Point(248, 12);
            this.NewsFeed.Name = "NewsFeed";
            this.NewsFeed.Size = new System.Drawing.Size(307, 169);
            this.NewsFeed.TabIndex = 17;
            // 
            // AccountHistory
            // 
            this.AccountHistory.Controls.Add(this.tabControl1);
            this.AccountHistory.Location = new System.Drawing.Point(121, 4);
            this.AccountHistory.Name = "AccountHistory";
            this.AccountHistory.Padding = new System.Windows.Forms.Padding(3);
            this.AccountHistory.Size = new System.Drawing.Size(575, 439);
            this.AccountHistory.TabIndex = 1;
            this.AccountHistory.Text = "Account History";
            this.AccountHistory.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PastFlights);
            this.tabControl1.Controls.Add(this.CanceledFlights);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // PastFlights
            // 
            this.PastFlights.Controls.Add(this.dataGridView2);
            this.PastFlights.Location = new System.Drawing.Point(4, 24);
            this.PastFlights.Name = "PastFlights";
            this.PastFlights.Padding = new System.Windows.Forms.Padding(3);
            this.PastFlights.Size = new System.Drawing.Size(544, 398);
            this.PastFlights.TabIndex = 0;
            this.PastFlights.Text = "Past Flights";
            this.PastFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(535, 392);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Flight ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Departure Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Departure City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Destination City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // CanceledFlights
            // 
            this.CanceledFlights.Controls.Add(this.dataGridView1);
            this.CanceledFlights.Location = new System.Drawing.Point(4, 24);
            this.CanceledFlights.Name = "CanceledFlights";
            this.CanceledFlights.Padding = new System.Windows.Forms.Padding(3);
            this.CanceledFlights.Size = new System.Drawing.Size(544, 398);
            this.CanceledFlights.TabIndex = 1;
            this.CanceledFlights.Text = "Canceled Flights";
            this.CanceledFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DepatureDate,
            this.DepartureCity,
            this.DestinationCity});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(535, 392);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Flight ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DepatureDate
            // 
            this.DepatureDate.HeaderText = "Departure Date";
            this.DepatureDate.Name = "DepatureDate";
            this.DepatureDate.ReadOnly = true;
            // 
            // DepartureCity
            // 
            this.DepartureCity.HeaderText = "Departure City";
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.ReadOnly = true;
            // 
            // DestinationCity
            // 
            this.DestinationCity.HeaderText = "Destination City";
            this.DestinationCity.Name = "DestinationCity";
            this.DestinationCity.ReadOnly = true;
            // 
            // UpcomingFlights
            // 
            this.UpcomingFlights.Controls.Add(this.dataGridView3);
            this.UpcomingFlights.Location = new System.Drawing.Point(121, 4);
            this.UpcomingFlights.Name = "UpcomingFlights";
            this.UpcomingFlights.Padding = new System.Windows.Forms.Padding(3);
            this.UpcomingFlights.Size = new System.Drawing.Size(575, 439);
            this.UpcomingFlights.TabIndex = 2;
            this.UpcomingFlights.Text = "Upcoming Flights";
            this.UpcomingFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView3.Location = new System.Drawing.Point(6, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(552, 429);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Flight ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Departure Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Departure City";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Destination City";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Booking
            // 
            this.Booking.Controls.Add(this.dataGridView4);
            this.Booking.Controls.Add(this.monthCalendar2);
            this.Booking.Controls.Add(this.button1);
            this.Booking.Controls.Add(this.comboBox3);
            this.Booking.Controls.Add(this.comboBox2);
            this.Booking.Location = new System.Drawing.Point(121, 4);
            this.Booking.Name = "Booking";
            this.Booking.Padding = new System.Windows.Forms.Padding(3);
            this.Booking.Size = new System.Drawing.Size(575, 439);
            this.Booking.TabIndex = 3;
            this.Booking.Text = "Booking";
            this.Booking.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView4.Location = new System.Drawing.Point(235, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(337, 433);
            this.dataGridView4.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Departure Date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Departure City";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Destination City";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(6, 107);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 43);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(227, 23);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.Text = "{Select origin city}";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 23);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "{Select destination city}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirEase_AMS.Properties.Resources.IconLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FlightID
            // 
            this.FlightID.HeaderText = "FlightID";
            this.FlightID.Name = "FlightID";
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CustomerTabControl);
            this.Name = "CustomerMain";
            this.Text = "CustomerMain";
            this.CustomerTabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.AccountHistory.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.PastFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.CanceledFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.UpcomingFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Booking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabControl CustomerTabControl;
        private TabPage Home;
        private TabPage AccountHistory;
        private TabPage UpcomingFlights;
        private TabPage Booking;
        private MonthCalendar monthCalendar1;
        private ListBox listBox2;
        private ListBox NewsFeed;
        private TabControl tabControl1;
        private TabPage PastFlights;
        private TabPage CanceledFlights;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DepatureDate;
        private DataGridViewTextBoxColumn DepartureCity;
        private DataGridViewTextBoxColumn DestinationCity;
        private DataGridViewTextBoxColumn FlightID;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}