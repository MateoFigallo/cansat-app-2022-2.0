using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cansat_app
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();
            label1.Text = DateTime.UtcNow.ToString("HH:mm");
            label2.Text = DateTime.Now.Date.ToString("MM-dd-yyyy");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
