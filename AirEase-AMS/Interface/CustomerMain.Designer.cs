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
            newPaymentMethod = new Button();
            AccountManagement = new Button();
            monthCalendar1 = new MonthCalendar();
            upcomingDepartureList = new ListBox();
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
            ArrivalTime = new DataGridViewTextBoxColumn();
            Booking = new TabPage();
            label1 = new Label();
            SelectDepartureDate = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            RoundTrip = new CheckBox();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
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
            CustomerTabControl.Location = new Point(109, 2);
            CustomerTabControl.Multiline = true;
            CustomerTabControl.Name = "CustomerTabControl";
            CustomerTabControl.Padding = new Point(50, 50);
            CustomerTabControl.SelectedIndex = 0;
            CustomerTabControl.Size = new Size(693, 447);
            CustomerTabControl.SizeMode = TabSizeMode.Fixed;
            CustomerTabControl.TabIndex = 10;
            // 
            // Home
            // 
            Home.Controls.Add(newPaymentMethod);
            Home.Controls.Add(AccountManagement);
            Home.Controls.Add(monthCalendar1);
            Home.Controls.Add(upcomingDepartureList);
            Home.Controls.Add(NewsFeed);
            Home.Location = new Point(121, 4);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.RightToLeft = RightToLeft.No;
            Home.Size = new Size(568, 439);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // newPaymentMethod
            // 
            newPaymentMethod.Location = new Point(40, 381);
            newPaymentMethod.Name = "newPaymentMethod";
            newPaymentMethod.Size = new Size(163, 23);
            newPaymentMethod.TabIndex = 21;
            newPaymentMethod.Text = "Enter new payment method";
            newPaymentMethod.UseVisualStyleBackColor = true;
            // 
            // AccountManagement
            // 
            AccountManagement.Location = new Point(40, 352);
            AccountManagement.Name = "AccountManagement";
            AccountManagement.Size = new Size(148, 23);
            AccountManagement.TabIndex = 20;
            AccountManagement.Text = "Account Management";
            AccountManagement.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 19;
            // 
            // upcomingDepartureList
            // 
            upcomingDepartureList.FormattingEnabled = true;
            upcomingDepartureList.ItemHeight = 15;
            upcomingDepartureList.Location = new Point(238, 187);
            upcomingDepartureList.Name = "upcomingDepartureList";
            upcomingDepartureList.Size = new Size(317, 244);
            upcomingDepartureList.TabIndex = 18;
            upcomingDepartureList.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // NewsFeed
            // 
            NewsFeed.FormattingEnabled = true;
            NewsFeed.ItemHeight = 15;
            NewsFeed.Location = new Point(238, 12);
            NewsFeed.Name = "NewsFeed";
            NewsFeed.Size = new Size(317, 169);
            NewsFeed.TabIndex = 17;
            // 
            // AccountHistory
            // 
            AccountHistory.Controls.Add(tabControl1);
            AccountHistory.Location = new Point(121, 4);
            AccountHistory.Name = "AccountHistory";
            AccountHistory.Padding = new Padding(3);
            AccountHistory.Size = new Size(568, 439);
            AccountHistory.TabIndex = 1;
            AccountHistory.Text = "Account History";
            AccountHistory.UseVisualStyleBackColor = true;
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
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
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
            UpcomingFlights.Size = new Size(568, 439);
            UpcomingFlights.TabIndex = 2;
            UpcomingFlights.Text = "Upcoming Flights";
            UpcomingFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, ArrivalTime });
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
            // ArrivalTime
            // 
            ArrivalTime.HeaderText = "Arrival Time";
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.ReadOnly = true;
            // 
            // Booking
            // 
            Booking.Controls.Add(label1);
            Booking.Controls.Add(SelectDepartureDate);
            Booking.Controls.Add(dateTimePicker3);
            Booking.Controls.Add(dateTimePicker1);
            Booking.Controls.Add(RoundTrip);
            Booking.Controls.Add(dataGridView4);
            Booking.Controls.Add(button1);
            Booking.Controls.Add(comboBox3);
            Booking.Controls.Add(comboBox2);
            Booking.Location = new Point(121, 4);
            Booking.Name = "Booking";
            Booking.Padding = new Padding(3);
            Booking.Size = new Size(568, 439);
            Booking.TabIndex = 3;
            Booking.Text = "Booking";
            Booking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 264);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 12;
            label1.Text = "Select Return Flight Departure Date";
            label1.Visible = false;
            // 
            // SelectDepartureDate
            // 
            SelectDepartureDate.AutoSize = true;
            SelectDepartureDate.Location = new Point(19, 169);
            SelectDepartureDate.Name = "SelectDepartureDate";
            SelectDepartureDate.Size = new Size(120, 15);
            SelectDepartureDate.TabIndex = 11;
            SelectDepartureDate.Text = "Select Departure Date";
            SelectDepartureDate.Click += label1_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(19, 282);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 10;
            dateTimePicker3.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // RoundTrip
            // 
            RoundTrip.AutoSize = true;
            RoundTrip.Location = new Point(70, 232);
            RoundTrip.Name = "RoundTrip";
            RoundTrip.Size = new Size(83, 19);
            RoundTrip.TabIndex = 7;
            RoundTrip.Text = "Round Trip";
            RoundTrip.UseVisualStyleBackColor = true;
            RoundTrip.CheckedChanged += RoundTrip_CheckedChanged;
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
            // button1
            // 
            button1.Location = new Point(52, 339);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 65);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(227, 23);
            comboBox3.TabIndex = 1;
            comboBox3.Text = "{Select origin city}";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 23);
            comboBox2.TabIndex = 0;
            comboBox2.Text = "{Select destination city}";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconLogo;
            pictureBox1.Location = new Point(12, 12);
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
            Text = "Customer View";
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
            Booking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button1;
        private Button AccountManagement;
        private Button button3;
        private TabControl CustomerTabControl;
        private TabPage Home;
        private TabPage AccountHistory;
        private TabPage UpcomingFlights;
        private TabPage Booking;
        private MonthCalendar monthCalendar1;
        private ListBox upcomingDepartureList;
        private ListBox NewsFeed;
        private TabControl tabControl1;
        private TabPage PastFlights;
        private TabPage CanceledFlights;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
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
        private DataGridViewTextBoxColumn ArrivalTime;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker1;
        private CheckBox RoundTrip;
        private Label SelectDepartureDate;
        private Label label1;
        private Button newPaymentMethod;
    }
}