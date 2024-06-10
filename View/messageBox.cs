using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class messageBox : Form
    {
        public messageBox(string _mess)
        {
            InitializeComponent();
            lbtext.Text = _mess;
        }

        private void messageBox_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(this);
        }

        
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            timer1.Stop();
        }

        private void guna2Transition1_FramePainted(object sender, PaintEventArgs e)
        {
            timer1.Start();
            pictureBox1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            timer1.Stop();
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowMess(string mess)
        {
            messageBox cd = new messageBox(mess);
            cd.ShowDialog();
        }
    }
}
