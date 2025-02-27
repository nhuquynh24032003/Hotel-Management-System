using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            staff1.Visible = false;
            room1.Visible = false;
            service1.Visible = false;
            checkin1.Visible = false;
            mana_customer1.Visible = false;
            booked1.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            staff1.Refresh();
            staff1.Visible = true;
            room1.Visible = false;
            service1.Visible = false;
            checkin1.Visible = false;
            mana_customer1.Visible = false;
            booked1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            room1.Refresh();
            staff1.Visible = false;
            room1.Visible = true;
            service1.Visible = false;
            checkin1.Visible = false;
            mana_customer1.Visible = false;
            booked1.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            service1.Refresh();
            service1.Visible = true;
            staff1.Visible = false;
            room1.Visible = false;
            checkin1.Visible = false;
            mana_customer1.Visible = false;
            booked1.Visible = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            schedule s = new schedule();
            s.ShowDialog();
            checkin1.Refresh();
            checkin1.Visible = true;
            service1.Visible = false;
            staff1.Visible = false;
            room1.Visible = false;
            mana_customer1.Visible = false;
            booked1.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            mana_customer1.Refresh();
            mana_customer1.Visible = true;
            checkin1.Visible = false;
            service1.Visible = false;
            staff1.Visible = false;
            room1.Visible = false;
            booked1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            booked1.Refresh();
            mana_customer1.Visible = false;
            checkin1.Visible = false;
            service1.Visible = false;
            staff1.Visible = false;
            room1.Visible = false;
            booked1.Visible = true;
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
