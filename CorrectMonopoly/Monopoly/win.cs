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
    public partial class win : Form
    {
        public win()
        {
            InitializeComponent();
        }

        private void win_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
