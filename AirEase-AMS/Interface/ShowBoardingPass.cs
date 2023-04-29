using AirEase_AMS.App.Entity.BoardingPass;
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
    public partial class ShowBoardingPass : Form
    {
        public ShowBoardingPass(BoardingPass pass)
        {
            InitializeComponent();
            listBox1.Items.Add(pass);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowBoardingPass_Load(object sender, EventArgs e)
        {

        }
    }
}
