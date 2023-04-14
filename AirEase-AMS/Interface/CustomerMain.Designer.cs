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
            listBox7 = new ListBox();
            listBox6 = new ListBox();
            listBox5 = new ListBox();
            tabControl1 = new TabControl();
            PastFlights = new TabPage();
            listBox3 = new ListBox();
            CanceledFlights = new TabPage();
            listBox4 = new ListBox();
            UpcomingFlights = new TabPage();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            listBox8 = new ListBox();
            Booking = new TabPage();
            listBox9 = new ListBox();
            monthCalendar2 = new MonthCalendar();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            CustomerTabControl.SuspendLayout();
            Home.SuspendLayout();
            AccountHistory.SuspendLayout();
            tabControl1.SuspendLayout();
            PastFlights.SuspendLayout();
            CanceledFlights.SuspendLayout();
            UpcomingFlights.SuspendLayout();
            Booking.SuspendLayout();
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
            CustomerTabControl.Location = new Point(12, 12);
            CustomerTabControl.Multiline = true;
            CustomerTabControl.Name = "CustomerTabControl";
            CustomerTabControl.Padding = new Point(50, 50);
            CustomerTabControl.SelectedIndex = 0;
            CustomerTabControl.Size = new Size(776, 426);
            CustomerTabControl.SizeMode = TabSizeMode.Fixed;
            CustomerTabControl.TabIndex = 10;
            CustomerTabControl.TabStop = false;
            CustomerTabControl.Visible = false;
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
            Home.Size = new Size(651, 418);
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
            listBox2.Location = new Point(9, 186);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(625, 214);
            listBox2.TabIndex = 18;
            // 
            // NewsFeed
            // 
            NewsFeed.FormattingEnabled = true;
            NewsFeed.ItemHeight = 15;
            NewsFeed.Location = new Point(248, 12);
            NewsFeed.Name = "NewsFeed";
            NewsFeed.Size = new Size(386, 169);
            NewsFeed.TabIndex = 17;
            // 
            // AccountHistory
            // 
            AccountHistory.Controls.Add(listBox7);
            AccountHistory.Controls.Add(listBox6);
            AccountHistory.Controls.Add(listBox5);
            AccountHistory.Controls.Add(tabControl1);
            AccountHistory.Location = new Point(121, 4);
            AccountHistory.Name = "AccountHistory";
            AccountHistory.Padding = new Padding(3);
            AccountHistory.Size = new Size(651, 418);
            AccountHistory.TabIndex = 1;
            AccountHistory.Text = "Account History";
            AccountHistory.UseVisualStyleBackColor = true;
            AccountHistory.Click += AccountHistory_Click;
            // 
            // listBox7
            // 
            listBox7.FormattingEnabled = true;
            listBox7.ItemHeight = 15;
            listBox7.Location = new Point(360, 92);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(285, 64);
            listBox7.TabIndex = 4;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(10, 92);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(285, 64);
            listBox6.TabIndex = 3;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(10, 6);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(635, 64);
            listBox5.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PastFlights);
            tabControl1.Controls.Add(CanceledFlights);
            tabControl1.Location = new Point(6, 187);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(639, 228);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // PastFlights
            // 
            PastFlights.Controls.Add(listBox3);
            PastFlights.Location = new Point(4, 24);
            PastFlights.Name = "PastFlights";
            PastFlights.Padding = new Padding(3);
            PastFlights.Size = new Size(631, 200);
            PastFlights.TabIndex = 0;
            PastFlights.Text = "Past Flights";
            PastFlights.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(0, 0);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(631, 199);
            listBox3.TabIndex = 1;
            // 
            // CanceledFlights
            // 
            CanceledFlights.Controls.Add(listBox4);
            CanceledFlights.Location = new Point(4, 24);
            CanceledFlights.Name = "CanceledFlights";
            CanceledFlights.Padding = new Padding(3);
            CanceledFlights.Size = new Size(631, 200);
            CanceledFlights.TabIndex = 1;
            CanceledFlights.Text = "Canceled Flights";
            CanceledFlights.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(0, 1);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(631, 199);
            listBox4.TabIndex = 2;
            // 
            // UpcomingFlights
            // 
            UpcomingFlights.Controls.Add(comboBox1);
            UpcomingFlights.Controls.Add(textBox1);
            UpcomingFlights.Controls.Add(listBox8);
            UpcomingFlights.Location = new Point(121, 4);
            UpcomingFlights.Name = "UpcomingFlights";
            UpcomingFlights.Padding = new Padding(3);
            UpcomingFlights.Size = new Size(651, 418);
            UpcomingFlights.TabIndex = 2;
            UpcomingFlights.Text = "Upcoming Flights";
            UpcomingFlights.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(524, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(639, 23);
            textBox1.TabIndex = 1;
            // 
            // listBox8
            // 
            listBox8.FormattingEnabled = true;
            listBox8.ItemHeight = 15;
            listBox8.Location = new Point(3, 66);
            listBox8.Name = "listBox8";
            listBox8.Size = new Size(642, 349);
            listBox8.TabIndex = 0;
            // 
            // Booking
            // 
            Booking.Controls.Add(listBox9);
            Booking.Controls.Add(monthCalendar2);
            Booking.Controls.Add(button1);
            Booking.Controls.Add(comboBox3);
            Booking.Controls.Add(comboBox2);
            Booking.Location = new Point(121, 4);
            Booking.Name = "Booking";
            Booking.Padding = new Padding(3);
            Booking.Size = new Size(651, 418);
            Booking.TabIndex = 3;
            Booking.Text = "Booking";
            Booking.UseVisualStyleBackColor = true;
            Booking.Click += Booking_Click;
            // 
            // listBox9
            // 
            listBox9.FormattingEnabled = true;
            listBox9.ItemHeight = 15;
            listBox9.Location = new Point(245, 6);
            listBox9.Name = "listBox9";
            listBox9.Size = new Size(403, 409);
            listBox9.TabIndex = 6;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(12, 110);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 5;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(51, 284);
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
            comboBox3.Location = new Point(12, 46);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(227, 23);
            comboBox3.TabIndex = 1;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 23);
            comboBox2.TabIndex = 0;
            // 
            // CustomerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomerTabControl);
            Name = "CustomerMain";
            Text = "CustomerMain";
            CustomerTabControl.ResumeLayout(false);
            Home.ResumeLayout(false);
            AccountHistory.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            PastFlights.ResumeLayout(false);
            CanceledFlights.ResumeLayout(false);
            UpcomingFlights.ResumeLayout(false);
            UpcomingFlights.PerformLayout();
            Booking.ResumeLayout(false);
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
        private ListBox listBox3;
        private TabPage CanceledFlights;
        private ListBox listBox4;
        private ListBox listBox7;
        private ListBox listBox6;
        private ListBox listBox5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ListBox listBox8;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar2;
        private ListBox listBox9;
    }
}