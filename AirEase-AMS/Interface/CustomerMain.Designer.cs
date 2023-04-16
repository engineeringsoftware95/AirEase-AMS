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
            CustomerTabControl = new TabControl();
            Home = new TabPage();
            monthCalendar1 = new MonthCalendar();
            listBox2 = new ListBox();
            NewsFeed = new ListBox();
            AccountHistory = new TabPage();
            tabControl1 = new TabControl();
            PastFlights = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            CanceledFlights = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DepatureDate = new DataGridViewTextBoxColumn();
            DepartureCity = new DataGridViewTextBoxColumn();
            DestinationCity = new DataGridViewTextBoxColumn();
            UpcomingFlights = new TabPage();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            Booking = new TabPage();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            monthCalendar2 = new MonthCalendar();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            FlightID = new DataGridViewTextBoxColumn();
            CustomerTabControl.SuspendLayout();
            Home.SuspendLayout();
            AccountHistory.SuspendLayout();
            tabControl1.SuspendLayout();
            PastFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            CanceledFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            UpcomingFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CustomerTabControl
            // 
            CustomerTabControl.AccessibleDescription = "";
            CustomerTabControl.AccessibleName = "";
            CustomerTabControl.Alignment = TabAlignment.Left;
            CustomerTabControl.AllowDrop = true;
            CustomerTabControl.Controls.Add(Home);
            CustomerTabControl.Controls.Add(AccountHistory);
            CustomerTabControl.Controls.Add(UpcomingFlights);
            CustomerTabControl.Controls.Add(Booking);
            CustomerTabControl.ImeMode = ImeMode.NoControl;
            CustomerTabControl.Location = new Point(102, 2);
            CustomerTabControl.Multiline = true;
            CustomerTabControl.Name = "CustomerTabControl";
            CustomerTabControl.Padding = new Point(50, 50);
            CustomerTabControl.SelectedIndex = 0;
            CustomerTabControl.Size = new Size(700, 447);
            CustomerTabControl.SizeMode = TabSizeMode.Fixed;
            CustomerTabControl.TabIndex = 10;
            // 
            // Home
            // 
            Home.Controls.Add(monthCalendar1);
            Home.Controls.Add(listBox2);
            Home.Controls.Add(NewsFeed);
            Home.Location = new Point(121, 4);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.RightToLeft = RightToLeft.No;
            Home.Size = new Size(561, 439);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 19;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(9, 187);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(546, 244);
            listBox2.TabIndex = 18;
            // 
            // NewsFeed
            // 
            NewsFeed.FormattingEnabled = true;
            NewsFeed.ItemHeight = 15;
            NewsFeed.Location = new Point(248, 12);
            NewsFeed.Name = "NewsFeed";
            NewsFeed.Size = new Size(307, 169);
            NewsFeed.TabIndex = 17;
            // 
            // AccountHistory
            // 
            AccountHistory.Controls.Add(tabControl1);
            AccountHistory.Location = new Point(121, 4);
            AccountHistory.Name = "AccountHistory";
            AccountHistory.Padding = new Padding(3);
            AccountHistory.Size = new Size(561, 439);
            AccountHistory.TabIndex = 1;
            AccountHistory.Text = "Account History";
            AccountHistory.UseVisualStyleBackColor = true;
            AccountHistory.Click += AccountHistory_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PastFlights);
            tabControl1.Controls.Add(CanceledFlights);
            tabControl1.Location = new Point(6, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(552, 426);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // PastFlights
            // 
            PastFlights.Controls.Add(dataGridView2);
            PastFlights.Location = new Point(4, 24);
            PastFlights.Name = "PastFlights";
            PastFlights.Padding = new Padding(3);
            PastFlights.Size = new Size(544, 398);
            PastFlights.TabIndex = 0;
            PastFlights.Text = "Past Flights";
            PastFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(535, 392);
            dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Flight ID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Departure Date";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Departure City";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Destination City";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // CanceledFlights
            // 
            CanceledFlights.Controls.Add(dataGridView1);
            CanceledFlights.Location = new Point(4, 24);
            CanceledFlights.Name = "CanceledFlights";
            CanceledFlights.Padding = new Padding(3);
            CanceledFlights.Size = new Size(544, 398);
            CanceledFlights.TabIndex = 1;
            CanceledFlights.Text = "Canceled Flights";
            CanceledFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, DepatureDate, DepartureCity, DestinationCity });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(535, 392);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Flight ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DepatureDate
            // 
            DepatureDate.HeaderText = "Departure Date";
            DepatureDate.Name = "DepatureDate";
            DepatureDate.ReadOnly = true;
            // 
            // DepartureCity
            // 
            DepartureCity.HeaderText = "Departure City";
            DepartureCity.Name = "DepartureCity";
            DepartureCity.ReadOnly = true;
            // 
            // DestinationCity
            // 
            DestinationCity.HeaderText = "Destination City";
            DestinationCity.Name = "DestinationCity";
            DestinationCity.ReadOnly = true;
            // 
            // UpcomingFlights
            // 
            UpcomingFlights.Controls.Add(dataGridView3);
            UpcomingFlights.Location = new Point(121, 4);
            UpcomingFlights.Name = "UpcomingFlights";
            UpcomingFlights.Padding = new Padding(3);
            UpcomingFlights.Size = new Size(561, 439);
            UpcomingFlights.TabIndex = 2;
            UpcomingFlights.Text = "Upcoming Flights";
            UpcomingFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridView3.Location = new Point(6, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(552, 429);
            dataGridView3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Flight ID";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Departure Date";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Departure City";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Destination City";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Booking
            // 
            Booking.Controls.Add(dataGridView4);
            Booking.Controls.Add(monthCalendar2);
            Booking.Controls.Add(button1);
            Booking.Controls.Add(comboBox3);
            Booking.Controls.Add(comboBox2);
            Booking.Location = new Point(121, 4);
            Booking.Name = "Booking";
            Booking.Padding = new Padding(3);
            Booking.Size = new Size(575, 439);
            Booking.TabIndex = 3;
            Booking.Text = "Booking";
            Booking.UseVisualStyleBackColor = true;
            Booking.Click += Booking_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            dataGridView4.Location = new Point(235, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(337, 433);
            dataGridView4.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Departure Date";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Departure City";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Destination City";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(6, 107);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 5;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(45, 281);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 43);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(227, 23);
            comboBox3.TabIndex = 1;
            comboBox3.Text = "{Select origin city}";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 23);
            comboBox2.TabIndex = 0;
            comboBox2.Text = "{Select destination city}";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconLogo;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FlightID
            // 
            FlightID.HeaderText = "FlightID";
            FlightID.Name = "FlightID";
            // 
            // CustomerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(CustomerTabControl);
            Name = "CustomerMain";
            Text = "CustomerMain";
            Load += CustomerMain_Load;
            CustomerTabControl.ResumeLayout(false);
            Home.ResumeLayout(false);
            AccountHistory.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            PastFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            CanceledFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            UpcomingFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Booking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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