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
            listBox2 = new ListBox();
            UpcomingFlights = new TabPage();
            label7 = new Label();
            label6 = new Label();
            comboBox6 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            comboBox5 = new ComboBox();
            BoardingPass = new Button();
            Cancel = new Button();
            Booking = new TabPage();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            Search = new Button();
            label1 = new Label();
            SelectDepartureDate = new Label();
            DateTimePicker_RT = new DateTimePicker();
            DateTimePicker_OW = new DateTimePicker();
            RoundTrip = new CheckBox();
            dataGridView4 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            bookingButton = new Button();
            OriginCityDropDown = new ComboBox();
            DestinationCityDropDown = new ComboBox();
            pictureBox1 = new PictureBox();
            FlightID = new DataGridViewTextBoxColumn();
            button1 = new Button();
            CustomerTabControl.SuspendLayout();
            Home.SuspendLayout();
            AccountHistory.SuspendLayout();
            UpcomingFlights.SuspendLayout();
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
            CustomerTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            Home.Click += Home_Click;
            // 
            // newPaymentMethod
            // 
            newPaymentMethod.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newPaymentMethod.Location = new Point(25, 378);
            newPaymentMethod.Name = "newPaymentMethod";
            newPaymentMethod.Size = new Size(192, 23);
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
            upcomingDepartureList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            NewsFeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NewsFeed.FormattingEnabled = true;
            NewsFeed.ItemHeight = 15;
            NewsFeed.Location = new Point(238, 12);
            NewsFeed.Name = "NewsFeed";
            NewsFeed.Size = new Size(404, 169);
            NewsFeed.TabIndex = 17;
            // 
            // AccountHistory
            // 
            AccountHistory.Controls.Add(listBox2);
            AccountHistory.Location = new Point(41, 4);
            AccountHistory.Name = "AccountHistory";
            AccountHistory.Padding = new Padding(3);
            AccountHistory.Size = new Size(648, 439);
            AccountHistory.TabIndex = 1;
            AccountHistory.Text = "Account History";
            AccountHistory.UseVisualStyleBackColor = true;
            AccountHistory.Click += AccountHistory_Click;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(639, 424);
            listBox2.TabIndex = 9;
            // 
            // UpcomingFlights
            // 
            UpcomingFlights.Controls.Add(label7);
            UpcomingFlights.Controls.Add(label6);
            UpcomingFlights.Controls.Add(comboBox6);
            UpcomingFlights.Controls.Add(label5);
            UpcomingFlights.Controls.Add(label4);
            UpcomingFlights.Controls.Add(listBox1);
            UpcomingFlights.Controls.Add(comboBox5);
            UpcomingFlights.Controls.Add(BoardingPass);
            UpcomingFlights.Controls.Add(Cancel);
            UpcomingFlights.Location = new Point(41, 4);
            UpcomingFlights.Name = "UpcomingFlights";
            UpcomingFlights.Padding = new Padding(3);
            UpcomingFlights.Size = new Size(648, 439);
            UpcomingFlights.TabIndex = 2;
            UpcomingFlights.Text = "Upcoming Flights";
            UpcomingFlights.UseVisualStyleBackColor = true;
            UpcomingFlights.Click += UpcomingFlights_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 311);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 13;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 119);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(23, 282);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(170, 23);
            comboBox6.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 264);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 10;
            label5.Text = "Select TicketID to cancel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 63);
            label4.Name = "label4";
            label4.Size = new Size(223, 15);
            label4.TabIndex = 9;
            label4.Text = "Select flight ID to print boarding pass for:";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(232, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(413, 424);
            listBox1.TabIndex = 8;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(23, 81);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(170, 23);
            comboBox5.TabIndex = 7;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // BoardingPass
            // 
            BoardingPass.Location = new Point(23, 146);
            BoardingPass.Name = "BoardingPass";
            BoardingPass.Size = new Size(170, 23);
            BoardingPass.TabIndex = 6;
            BoardingPass.Text = "Print Boarding Pass";
            BoardingPass.UseVisualStyleBackColor = true;
            BoardingPass.Click += BoardingPass_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(23, 329);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(170, 23);
            Cancel.TabIndex = 5;
            Cancel.Text = "Cancel Ticket";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Booking
            // 
            Booking.Controls.Add(label3);
            Booking.Controls.Add(comboBox4);
            Booking.Controls.Add(label2);
            Booking.Controls.Add(comboBox1);
            Booking.Controls.Add(Search);
            Booking.Controls.Add(label1);
            Booking.Controls.Add(SelectDepartureDate);
            Booking.Controls.Add(DateTimePicker_RT);
            Booking.Controls.Add(DateTimePicker_OW);
            Booking.Controls.Add(RoundTrip);
            Booking.Controls.Add(dataGridView4);
            Booking.Controls.Add(bookingButton);
            Booking.Controls.Add(OriginCityDropDown);
            Booking.Controls.Add(DestinationCityDropDown);
            Booking.Location = new Point(41, 4);
            Booking.Name = "Booking";
            Booking.Padding = new Padding(3);
            Booking.Size = new Size(648, 439);
            Booking.TabIndex = 3;
            Booking.Text = "Booking";
            Booking.UseVisualStyleBackColor = true;
            Booking.Click += Booking_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 333);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 17;
            label3.Text = "Select Return Ticket:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(3, 351);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(248, 23);
            comboBox4.TabIndex = 16;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 278);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 15;
            label2.Text = "Select Ticket:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Search
            // 
            Search.Location = new Point(89, 115);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 13;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 227);
            label1.Name = "label1";
            label1.Size = new Size(246, 15);
            label1.TabIndex = 12;
            label1.Text = "Select Return Flight Departure Date and Time:";
            label1.Visible = false;
            // 
            // SelectDepartureDate
            // 
            SelectDepartureDate.AutoSize = true;
            SelectDepartureDate.Location = new Point(5, 158);
            SelectDepartureDate.Name = "SelectDepartureDate";
            SelectDepartureDate.Size = new Size(175, 15);
            SelectDepartureDate.TabIndex = 11;
            SelectDepartureDate.Text = "Select Departure Date and Time:";
            SelectDepartureDate.Click += label1_Click;
            // 
            // DateTimePicker_RT
            // 
            DateTimePicker_RT.Format = DateTimePickerFormat.Custom;
            DateTimePicker_RT.Location = new Point(3, 245);
            DateTimePicker_RT.Name = "DateTimePicker_RT";
            DateTimePicker_RT.Size = new Size(245, 23);
            DateTimePicker_RT.TabIndex = 10;
            DateTimePicker_RT.Visible = false;
            DateTimePicker_RT.ValueChanged += DateTimePicker_RT_ValueChanged;
            // 
            // DateTimePicker_OW
            // 
            DateTimePicker_OW.Format = DateTimePickerFormat.Custom;
            DateTimePicker_OW.Location = new Point(6, 176);
            DateTimePicker_OW.Name = "DateTimePicker_OW";
            DateTimePicker_OW.Size = new Size(242, 23);
            DateTimePicker_OW.TabIndex = 8;
            DateTimePicker_OW.ValueChanged += DateTimePicker_OW_ValueChanged;
            // 
            // RoundTrip
            // 
            RoundTrip.AutoSize = true;
            RoundTrip.Location = new Point(64, 205);
            RoundTrip.Name = "RoundTrip";
            RoundTrip.Size = new Size(83, 19);
            RoundTrip.TabIndex = 7;
            RoundTrip.Text = "Round Trip";
            RoundTrip.UseVisualStyleBackColor = true;
            RoundTrip.CheckedChanged += RoundTrip_CheckedChanged;
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column5, Column3, Column4, Column2 });
            dataGridView4.Location = new Point(257, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(388, 433);
            dataGridView4.TabIndex = 6;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ticket ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Price";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Departure Date and Time";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Origin City";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Destination City";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Seats Available";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // bookingButton
            // 
            bookingButton.Location = new Point(51, 384);
            bookingButton.Name = "bookingButton";
            bookingButton.Size = new Size(143, 38);
            bookingButton.TabIndex = 4;
            bookingButton.Text = "Book Ticket";
            bookingButton.UseVisualStyleBackColor = true;
            bookingButton.Click += bookingButton_Click;
            // 
            // OriginCityDropDown
            // 
            OriginCityDropDown.FormattingEnabled = true;
            OriginCityDropDown.Location = new Point(5, 40);
            OriginCityDropDown.Name = "OriginCityDropDown";
            OriginCityDropDown.Size = new Size(243, 23);
            OriginCityDropDown.TabIndex = 1;
            OriginCityDropDown.Text = "{Select origin city}";
            OriginCityDropDown.SelectedIndexChanged += OriginCityDropDownBox_IndexChanged;
            // 
            // DestinationCityDropDown
            // 
            DestinationCityDropDown.FormattingEnabled = true;
            DestinationCityDropDown.Location = new Point(5, 69);
            DestinationCityDropDown.Name = "DestinationCityDropDown";
            DestinationCityDropDown.Size = new Size(243, 23);
            DestinationCityDropDown.TabIndex = 0;
            DestinationCityDropDown.Text = "{Select destination city}";
            DestinationCityDropDown.SelectedIndexChanged += DestinationCityDropDownBox_IndexChanged;
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
            // button1
            // 
            button1.Location = new Point(12, 414);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustomerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(CustomerTabControl);
            Name = "CustomerMain";
            Text = "Customer View";
            Load += CustomerMain_Load;
            CustomerTabControl.ResumeLayout(false);
            Home.ResumeLayout(false);
            AccountHistory.ResumeLayout(false);
            UpcomingFlights.ResumeLayout(false);
            UpcomingFlights.PerformLayout();
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
        private ComboBox OriginCityDropDown;
        private ComboBox DestinationCityDropDown;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn FlightID;
        private DataGridView dataGridView4;
        private DateTimePicker DateTimePicker_RT;
        private DateTimePicker DateTimePicker_OW;
        private CheckBox RoundTrip;
        private Label SelectDepartureDate;
        private Label label1;
        private Button newPaymentMethod;
        private Button Search;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox4;
        private Button button1;
        private ComboBox comboBox5;
        private Button BoardingPass;
        private Button Cancel;
        private ListBox listBox1;
        private ListBox listBox2;
        private ComboBox comboBox6;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private Label label7;
        private Label label6;
    }
}