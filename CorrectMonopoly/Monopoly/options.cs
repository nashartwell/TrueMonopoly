using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            start s = new start();
            s.Show();
            this.Hide();
        }

        private void options_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
