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
            monthCalendar1 = new MonthCalendar();
            upcomingDepartureList = new ListBox();
            NewsFeed = new ListBox();
            AccountHistory = new TabPage();
            dataGridView2 = new DataGridView();
            UpcomingFlights = new TabPage();
            dataGridView3 = new DataGridView();
            Booking = new TabPage();
            label1 = new Label();
            SelectDepartureDate = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            RoundTrip = new CheckBox();
            dataGridView4 = new DataGridView();
            bookingButton = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            FlightID = new DataGridViewTextBoxColumn();
            Search = new Button();
            CustomerTabControl.SuspendLayout();
            Home.SuspendLayout();
            AccountHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            CustomerTabControl.Padding = new Point(80, 10);
            CustomerTabControl.SelectedIndex = 0;
            CustomerTabControl.Size = new Size(693, 447);
            CustomerTabControl.SizeMode = TabSizeMode.Fixed;
            CustomerTabControl.TabIndex = 10;
            // 
            // Home
            // 
            Home.Controls.Add(newPaymentMethod);
            Home.Controls.Add(monthCalendar1);
            Home.Controls.Add(upcomingDepartureList);
            Home.Controls.Add(NewsFeed);
            Home.Location = new Point(41, 4);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.RightToLeft = RightToLeft.No;
            Home.Size = new Size(648, 439);
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
            newPaymentMethod.Click += newPaymentMethod_Click;
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
            upcomingDepartureList.Size = new Size(404, 244);
            upcomingDepartureList.TabIndex = 18;
            upcomingDepartureList.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // NewsFeed
            // 
            NewsFeed.FormattingEnabled = true;
            NewsFeed.ItemHeight = 15;
            NewsFeed.Location = new Point(238, 12);
            NewsFeed.Name = "NewsFeed";
            NewsFeed.Size = new Size(404, 169);
            NewsFeed.TabIndex = 17;
            // 
            // AccountHistory
            // 
            AccountHistory.Controls.Add(dataGridView2);
            AccountHistory.Location = new Point(41, 4);
            AccountHistory.Name = "AccountHistory";
            AccountHistory.Padding = new Padding(3);
            AccountHistory.Size = new Size(648, 439);
            AccountHistory.TabIndex = 1;
            AccountHistory.Text = "Account History";
            AccountHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(636, 429);
            dataGridView2.TabIndex = 5;
            // 
            // UpcomingFlights
            // 
            UpcomingFlights.Controls.Add(dataGridView3);
            UpcomingFlights.Location = new Point(41, 4);
            UpcomingFlights.Name = "UpcomingFlights";
            UpcomingFlights.Padding = new Padding(3);
            UpcomingFlights.Size = new Size(648, 439);
            UpcomingFlights.TabIndex = 2;
            UpcomingFlights.Text = "Upcoming Flights";
            UpcomingFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(636, 429);
            dataGridView3.TabIndex = 4;
            // 
            // Booking
            // 
            Booking.Controls.Add(Search);
            Booking.Controls.Add(label1);
            Booking.Controls.Add(SelectDepartureDate);
            Booking.Controls.Add(dateTimePicker3);
            Booking.Controls.Add(dateTimePicker1);
            Booking.Controls.Add(RoundTrip);
            Booking.Controls.Add(dataGridView4);
            Booking.Controls.Add(bookingButton);
            Booking.Controls.Add(comboBox3);
            Booking.Controls.Add(comboBox2);
            Booking.Location = new Point(41, 4);
            Booking.Name = "Booking";
            Booking.Padding = new Padding(3);
            Booking.Size = new Size(648, 439);
            Booking.TabIndex = 3;
            Booking.Text = "Booking";
            Booking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 242);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 12;
            label1.Text = "Select Return Flight Departure Date";
            label1.Visible = false;
            // 
            // SelectDepartureDate
            // 
            SelectDepartureDate.AutoSize = true;
            SelectDepartureDate.Location = new Point(22, 130);
            SelectDepartureDate.Name = "SelectDepartureDate";
            SelectDepartureDate.Size = new Size(120, 15);
            SelectDepartureDate.TabIndex = 11;
            SelectDepartureDate.Text = "Select Departure Date";
            SelectDepartureDate.Click += label1_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(31, 260);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 10;
            dateTimePicker3.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(22, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // RoundTrip
            // 
            RoundTrip.AutoSize = true;
            RoundTrip.Location = new Point(82, 210);
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
            dataGridView4.Location = new Point(242, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(403, 433);
            dataGridView4.TabIndex = 6;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // bookingButton
            // 
            bookingButton.Location = new Point(55, 370);
            bookingButton.Name = "bookingButton";
            bookingButton.Size = new Size(143, 38);
            bookingButton.TabIndex = 4;
            bookingButton.Text = "Book Flight";
            bookingButton.UseVisualStyleBackColor = true;
            bookingButton.Click += bookingButton_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(9, 26);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(227, 23);
            comboBox3.TabIndex = 1;
            comboBox3.Text = "{Select origin city}";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(9, 60);
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
            // Search
            // 
            Search.Location = new Point(82, 326);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 13;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Button bookingButton;
        private Button button3;
        private TabControl CustomerTabControl;
        private TabPage Home;
        private TabPage AccountHistory;
        private TabPage UpcomingFlights;
        private TabPage Booking;
        private MonthCalendar monthCalendar1;
        private ListBox upcomingDepartureList;
        private ListBox NewsFeed;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn FlightID;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker1;
        private CheckBox RoundTrip;
        private Label SelectDepartureDate;
        private Label label1;
        private Button newPaymentMethod;
        private DataGridView dataGridView2;
        private Button Search;
    }
}