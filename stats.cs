using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTrainer
{
    public partial class stats : Form
    {
        public stats(trainerBase.TrainKind kind)
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            trainerBase.MainFrame.Show();
        }
    }
}
