﻿using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirEase_AMS.Interface
{
    public partial class PaymentInformationEntry : Form
    {
        Customer currentUser;
        Form parent;

        public PaymentInformationEntry(Customer loggedIn, Form calledFrom)
        {
            currentUser = loggedIn;
            parent = calledFrom;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yy";
        }

        private void continue_Click(object sender, EventArgs e)
        {
            // update database with payment info
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(CCNEntry.Text))
            {
                CreditCard newCard = new CreditCard(CCNEntry.Text, dateTimePicker1.Value.ToString(), textBox3.Text, textBox1.Text, currentUser.GetUserId().ToString());
                newCard.SaveCreditCard();
                this.Hide();
                parent.Refresh();
                parent.Update();
                parent.Show();
                this.Close();
            }
            else
            {
                ErrorLabel.Text = "Please fill out all fields.";
                ErrorLabel.Visible = true;

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Update();
            parent.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PaymentInformationEntry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
